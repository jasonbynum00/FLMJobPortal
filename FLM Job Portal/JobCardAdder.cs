using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FLM_Job_Portal
{
    public partial class JobCardAdder : Form
    {

        //TO HOLD DATA OF EMPLOYEES ON LIST
        UserProfile theUser = new UserProfile();
        string[][] WorkListRow = new string[100][];
        ListViewItem[] theWorkList = new ListViewItem[100];

        public string theJob;
        int workCounter, j;
        decimal allotted, newSpent, newLeft;
        string department, component;
        bool sendCard, lineInfo, shopCard;

        //CONSTRUCTOR FOR ADDING JOB CARD
        public JobCardAdder()
        {
            InitializeComponent();
            shopCard = true;

            lblJob.Text = "FOR SHOP HOURS";
            cmboItem.Text = "SHOP";
            cmboItem.Enabled = false;

            cmboHours.SelectedIndex = 0;
            cmboOvertime.SelectedIndex = 0;

            //CHANGE COLUMN NAMES FOR SHOP CARDS
            lvCurrent.Columns.Remove(colJob);
            lvCurrent.Columns.Remove(colItem);
            lvCurrent.Columns.Remove(colDept);
            lvCurrent.Columns.Remove(colComponent);
            lvCurrent.Columns.Remove(colHoursAllotted);
            lvCurrent.Columns.Remove(colHoursSpent);
            lvCurrent.Columns.Remove(colNotes);

            lvCurrent.Columns.Add("JOB");
            lvCurrent.Columns.Add("CARD DATE");
            lvCurrent.Columns.Add("HOURS");
            lvCurrent.Columns.Add("OVERTIME");
            lvCurrent.Columns.Add("NOTES");


            GetUserInfo();

            GetShopCards();

            for (int i = 0; i < workCounter; i++)
            {
                lvCurrent.Items.Add(theWorkList[i]);
            }

            lvCurrent.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvCurrent.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        //ONE ARGUMENT CONSTRUCTOR
        public JobCardAdder(string passedJob)
        {
            InitializeComponent();
            theJob = passedJob;
            lblJob.Text = "FOR J# " + theJob;

            cmboHours.SelectedIndex = 0;
            cmboOvertime.SelectedIndex = 0;

            GetUserInfo();
            GetWork(theJob, UserProfile.ID);

            for (int i = 0; i < workCounter; i++)
            {
                lvCurrent.Items.Add(theWorkList[i]);
            }

            theJob = passedJob;
            cmboHours.SelectedIndex = 0;
            cmboOvertime.SelectedIndex = 0;


        }

        //GET THE PROFILE INFORMATION OF USER
        private void GetUserInfo()
        {
            int k = 0;
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "jbfineline.database.windows.net";
                builder.UserID = "jasonbynum";
                builder.Password = "Jb975774";
                builder.InitialCatalog = "Fineline";
                SqlConnection connection = new SqlConnection(builder.ConnectionString);
                using (connection)
                {
                    connection.Open();

                    //
                    ///GET JOB PROCESSES FROM DB SPECIFIC TO LISTED EMPLOYEE
                    //       
                    SqlCommand commandComp = new SqlCommand();

                    commandComp.Connection = connection;
                    commandComp.CommandText = "select * from user_profile where user_id = '" + UserProfile.ID + "';";
                    commandComp.CommandType = CommandType.Text;

                    SqlDataReader readerComp = commandComp.ExecuteReader();

                    while (readerComp.Read())
                    {
                        int idFound = (int)readerComp["user_id"];
                        theUser.AddID = idFound;

                        string firstFound = (string)readerComp["first_name"];
                        theUser.AddFirst = firstFound;

                        string lastFound = (string)readerComp["last_name"];
                        theUser.AddLast = lastFound;

                        int amountFound = (int)readerComp["job_amount"];
                        theUser.AddJobAmount = amountFound;

                        string initialsFound = (string)readerComp["initials"];
                        theUser.AddInitials = initialsFound;
                        
                    }

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("GetAddEmployee Failed");
            }
        }

        //GET WORK CURRENTLY ASSIGNED TO SELECTED EMPLOYEE AND ADD ITEMS TO COMBO BOX
        private void GetWork(string passedJob, int passedEmployee)
        {
            j = 0;
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "jbfineline.database.windows.net";
                builder.UserID = "jasonbynum";
                builder.Password = "Jb975774";
                builder.InitialCatalog = "Fineline";
                SqlConnection connection = new SqlConnection(builder.ConnectionString);
                using (connection)
                {
                    connection.Open();

                    //
                    ///GET JOB PROCESSES FROM DB SPECIFIC TO LISTED EMPLOYEE
                    //       
                    SqlCommand commandComp = new SqlCommand();

                    commandComp.Connection = connection;
                    commandComp.CommandText = "select * from job_processes where job_number = '" + passedJob + "' and user_id = '" + passedEmployee + "';";
                    commandComp.CommandType = CommandType.Text;

                    SqlDataReader readerComp = commandComp.ExecuteReader();

                    while (readerComp.Read())
                    {
                        string jobFound = (string)readerComp["job_number"];
                        string jobComp = string.Format("{0}", jobFound);

                        string itemFound = (string)readerComp["item"];
                        string itemComp = string.Format("{0}", itemFound);
                        cmboItem.Items.Add(itemComp);

                        string departmentFound = (string)readerComp["department"];
                        string departmentComp = string.Format("{0}", departmentFound);

                        string componentFound = (string)readerComp["component"];
                        string componentComp = string.Format("{0}", componentFound);

                        decimal allottedFound = (decimal)readerComp["hrs_allotted"];

                        decimal spentFound = (decimal)readerComp["hrs_spent"];

                        string notesFound = (string)readerComp["notes"];
                        string notesComp = string.Format("{0}", notesFound);


                        //CREATES ROW FOR EACH ITEM OF WORK FOR THE PASSED USER AND ADDS IT TO ARRAY OF ROWS
                        string[] row = { jobComp, itemComp, departmentComp, componentComp, allottedFound.ToString(), spentFound.ToString(), notesComp };
                        WorkListRow[j] = row;
                        theWorkList[j] = new ListViewItem(WorkListRow[j]);

                        workCounter++;
                        j++;
                    }

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("GetEmployeeWork Failed");
            }
        }

        //GET SHOP CARDS FOR THE CURRENT PAY PERIOD
        private void GetShopCards()
        {
            DateTime dt2 = DateTime.Now.StartOfWeek(DayOfWeek.Sunday);

            j = 0;
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "jbfineline.database.windows.net";
                builder.UserID = "jasonbynum";
                builder.Password = "Jb975774";
                builder.InitialCatalog = "Fineline";
                SqlConnection connection = new SqlConnection(builder.ConnectionString);
                using (connection)
                {
                    connection.Open();

                    //
                    ///GET JOB PROCESSES FROM DB SPECIFIC TO LISTED EMPLOYEE
                    //       
                    SqlCommand commandComp = new SqlCommand();

                    commandComp.Connection = connection;
                    commandComp.CommandText = "select * from job_cards where job_number = 'SHOP' and card_date > '" + dt2 + "' and user_id = '" + UserProfile.ID + "' order by card_date;";
                    commandComp.CommandType = CommandType.Text;

                    SqlDataReader readerComp = commandComp.ExecuteReader();

                    while (readerComp.Read())
                    {
                        string jobFound = (string)readerComp["job_number"];
                        string jobComp = string.Format("{0}", jobFound);                        

                        DateTime dateFound = (DateTime)readerComp["card_date"];
                        string dateComp = dateFound.ToString("MM/dd/yyyy");

                        decimal hoursFound = (decimal)readerComp["hours"];

                        decimal overtimeFound = (decimal)readerComp["overtime"];

                        string notesFound = (string)readerComp["notes"];
                        string notesComp = string.Format("{0}", notesFound);

                        cmboItem.Items.Add(jobComp + "|" + dateFound);


                        //CREATES ROW FOR EACH ITEM OF WORK FOR THE PASSED USER AND ADDS IT TO ARRAY OF ROWS
                        string[] row = { jobComp, dateComp, hoursFound.ToString(), overtimeFound.ToString(), notesComp };
                        WorkListRow[j] = row;
                        theWorkList[j] = new ListViewItem(WorkListRow[j]);

                        workCounter++;
                        j++;
                    }

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("GetEmployeeWork Failed");
            }
        }

        //GET INFO OF ITEM TO BE ADJUSTED
        public void GetLineInfo()
        {
            j = 0;
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "jbfineline.database.windows.net";
                builder.UserID = "jasonbynum";
                builder.Password = "Jb975774";
                builder.InitialCatalog = "Fineline";
                SqlConnection connection = new SqlConnection(builder.ConnectionString);
                using (connection)
                {
                    connection.Open();

                    //
                    ///GET JOB PROCESSES FROM DB SPECIFIC TO LISTED EMPLOYEE
                    //       
                    SqlCommand commandComp = new SqlCommand();

                    commandComp.Connection = connection;
                    commandComp.CommandText = "select * from job_processes where item = '" + cmboItem.Text + "' and user_id = '" + UserProfile.ID + "' and job_number = '" + theJob +"';";
                    commandComp.CommandType = CommandType.Text;

                    SqlDataReader readerComp = commandComp.ExecuteReader();

                    while (readerComp.Read())
                    {
                        decimal allottedFound = (decimal)readerComp["hrs_allotted"];
                        allotted = allottedFound;

                        decimal spentFound = (decimal)readerComp["hrs_spent"];
                        newSpent = spentFound;

                        decimal leftFound = (decimal)readerComp["hrs_left"];
                        newLeft = leftFound;

                        string departmentFound = (string)readerComp["department"];
                        string departmentComp = string.Format("{0}", departmentFound);
                        department = departmentComp;

                        string componentFound = (string)readerComp["department"];
                        string componentComp = string.Format("{0}", componentFound);
                        component = componentFound;
                    }

                    lineInfo = true;

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("GetLineInfo Failed");
            }
        }

        //SUBMIT COMPLETE DATE TO ITEM IN DB
        private void SubmitComplete()
        {
            int monthComplete = Convert.ToInt32(DateTime.Today.ToString("MM"));
            int dayComplete = Convert.ToInt32(DateTime.Today.ToString("dd"));

            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "jbfineline.database.windows.net";
                builder.UserID = "jasonbynum";
                builder.Password = "Jb975774";
                builder.InitialCatalog = "Fineline";
                SqlConnection connection = new SqlConnection(builder.ConnectionString);
                using (connection)
                {
                    connection.Open();

                    //
                    ///Check username + password in DB
                    //       
                    SqlCommand addWork = new SqlCommand();

                    addWork.Connection = connection;
                    addWork.CommandText = "update job_processes set date_complete = '" + DateTime.Today + "', month_complete = '" + monthComplete + "', day_complete = '" + 
                        dayComplete + "' where job_number = '" + theJob + "' and item = '" + cmboItem.Text + "';";
                    addWork.CommandType = CommandType.Text;

                    addWork.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("adjustspenthours failed");
            }
        }

        //SUBMIT CARD TO DB
        private void SendCard()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "jbfineline.database.windows.net";
                builder.UserID = "jasonbynum";
                builder.Password = "Jb975774";
                builder.InitialCatalog = "Fineline";
                SqlConnection connection = new SqlConnection(builder.ConnectionString);
                using (connection)
                {
                    connection.Open();

                    //
                    ///Check username + password in DB
                    //       
                    SqlCommand addWork = new SqlCommand();

                    addWork.Connection = connection;
                    addWork.CommandText = "insert into job_cards values ('" + UserProfile.ID + "', '" + UserProfile.First + "', '" + UserProfile.Last + "', '" + theJob + "', '" + dtpDate.Text + "', '" + cmboItem.Text + "', '" +
                        department + "', '" + component + "', '" + cmboHours.Text + "', '" + cmboOvertime.Text + "', '" + rtbNotes.Text + "');";
                    addWork.CommandType = CommandType.Text;

                    addWork.ExecuteNonQuery();

                    MessageBox.Show("Card Added");

                    sendCard = true;

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("SendCard failed");
            }
        }

        //SUBMIT CARD TO DB FOR SHOP
        private void SendCardShop()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "jbfineline.database.windows.net";
                builder.UserID = "jasonbynum";
                builder.Password = "Jb975774";
                builder.InitialCatalog = "Fineline";
                SqlConnection connection = new SqlConnection(builder.ConnectionString);
                using (connection)
                {
                    connection.Open();

                    //
                    ///Check username + password in DB
                    //       
                    SqlCommand addWork = new SqlCommand();

                    addWork.Connection = connection;
                    addWork.CommandText = "insert into job_cards values ('" + UserProfile.ID + "', '" + UserProfile.First + "', '" + UserProfile.Last + "', '" + "SHOP" + "', '" + dtpDate.Value + "', '" + "N/A" + "', '" +
                        "N/A" + "', '" + "N/A" + "', '" + cmboHours.Text + "', '" + cmboOvertime.Text + "', '" + rtbNotes.Text + "');";
                    addWork.CommandType = CommandType.Text;

                    addWork.ExecuteNonQuery();

                    MessageBox.Show("Card Added");

                    sendCard = true;

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("SendCardShop failed");
            }
        }

        //ADJUST SPENT AND LEFT HOURS FOR JOB PROCESSES TABLE IN DB
        private void AdjustSpentHours()
        {
            newSpent = newSpent + Convert.ToDecimal(cmboHours.Text) + Convert.ToDecimal(cmboOvertime.Text);

            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "jbfineline.database.windows.net";
                builder.UserID = "jasonbynum";
                builder.Password = "Jb975774";
                builder.InitialCatalog = "Fineline";
                SqlConnection connection = new SqlConnection(builder.ConnectionString);
                using (connection)
                {
                    connection.Open();

                    //
                    ///Check username + password in DB
                    //       
                    SqlCommand addWork = new SqlCommand();

                    addWork.Connection = connection;
                    addWork.CommandText = "update job_processes set hrs_spent = '" + newSpent + "' where job_number = '" + theJob + "' and item = '" + cmboItem.Text + "';";
                    addWork.CommandType = CommandType.Text;

                    addWork.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("adjustspenthours failed");
            }
        }

        //ADJUST SPENT AND LEFT HOURS FOR JOB PROCESSES TABLE IN DB
        private void AdjustLeftHours()
        {
            newLeft = allotted - newSpent;

            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "jbfineline.database.windows.net";
                builder.UserID = "jasonbynum";
                builder.Password = "Jb975774";
                builder.InitialCatalog = "Fineline";
                SqlConnection connection = new SqlConnection(builder.ConnectionString);
                using (connection)
                {
                    connection.Open();

                    //
                    ///Check username + password in DB
                    //       
                    SqlCommand addWork = new SqlCommand();

                    addWork.Connection = connection;
                    addWork.CommandText = "update job_processes set hrs_left = '" + newLeft + "' where job_number = '" + theJob + "' and item = '" + cmboItem.Text + "';";
                    addWork.CommandType = CommandType.Text;

                    addWork.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("adjustlefthours failed");
            }
        }

        //CLEAR LISTVIEW TO ADD NEWLY ADDED JOB CARD
        private void ClearForm()
        {
            //CLEAR OUT LIST VIEW ITEMS
            for(int i = 0; i < workCounter; i++)
            {
                theWorkList[i].SubItems.Clear();               
            }

            //RESET ALL INPUT AND COMBO BOXES
            cmboItem.SelectedIndex = -1;
            cmboHours.SelectedIndex = 0;
            cmboOvertime.SelectedIndex = 0;
            dtpDate.Value = DateTime.Today;

            lvCurrent.Items.Clear();

            cmboItem.Items.Clear();

            workCounter = 0;
        }

        //ADD JOB CARD TO DATABASE, CLEAR OUT THE FORM AND START AGAIN
        private void pbAddLine_Click(object sender, EventArgs e)
        {
            if(cbFinished.Checked == true)
            {
                SubmitComplete();
            }

            //IF THE USER ADDS A JOB CARD FOR A SPECIFIC JOB
            if(shopCard == false)
            {
                GetLineInfo();
                if (lineInfo == true)
                {
                    SendCard();
                    if (sendCard == true)
                    {
                        AdjustSpentHours();
                        AdjustLeftHours();
                        ClearForm();
                        GetWork(theJob, UserProfile.ID);

                        for (int i = 0; i < workCounter; i++)
                        {
                            lvCurrent.Items.Add(theWorkList[i]);
                        }
                        lvCurrent.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                        lvCurrent.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    }

                }
            }

            //IF THE USERS ADD A JOB CARD FOR SHOP HOURS
            if(shopCard == true)
            {
                SendCardShop();
                if (sendCard == true)
                {
                    ClearForm();
                    GetShopCards();

                    for (int i = 0; i < workCounter; i++)
                    {
                        lvCurrent.Items.Add(theWorkList[i]);
                    }
                }
            }
        }

        /// 
        /// DESIGN EVENTS
        /// 
        /// 
        //FOR ADD BUTTON DESIGN
        private void pbAddLine_MouseEnter(object sender, EventArgs e)
        {
            int width = pbAddLine.Size.Width;
            int height = pbAddLine.Size.Height;
            int larger = 5;
            pbAddLine.Size = new Size(width + larger, height + larger);
        }

        private void pbAddLine_MouseLeave(object sender, EventArgs e)
        {
            int width = pbAddLine.Size.Width;
            int height = pbAddLine.Size.Height;
            int smaller = 5;
            pbAddLine.Size = new Size(width - smaller, height - smaller);
        }

    }
}
