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
    public partial class JobCardEditor : Form
    {

        string[][] CardRow = new string[100][];
        ListViewItem[] CardList = new ListViewItem[100];
        public string[] theRow = new string[5];
        string theJob;
        int j;
        bool deleteRequest, shopCard;

        public JobCardEditor()
        {
            InitializeComponent();
            GetJobs();
        }

        public JobCardEditor(string passedJob)
        {
            InitializeComponent();
            theJob = passedJob;
            GetJobs();

        }

        //GET LIST OF CURRENT AND COMPLETED JOBS FOR SELECT COMBO BOX
        private void GetJobs()
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
                    ///GET JOB PROCESSES FROM DB SPECIFIC TO LISTED EMPLOYEE
                    //       
                    SqlCommand commandComp = new SqlCommand();

                    commandComp.Connection = connection;
                    commandComp.CommandText = "select * from job_list;";
                    commandComp.CommandType = CommandType.Text;

                    SqlDataReader readerComp = commandComp.ExecuteReader();

                    while (readerComp.Read())
                    {
                        string jobFound = (string)readerComp["job_number"];
                        string jobComp = string.Format("{0}", jobFound);

                        string customerFound = (string)readerComp["customer"];
                        string customerComp = string.Format("{0}", customerFound);

                        string addCombo = jobComp + "|" + customerComp;
                        cmboJob.Items.Add(addCombo);
                    }

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("GetEmployeeWork Failed");
            }
        }

        //GET CARDS FROM DB BY JOB NUMBER AND STORE THEM
        private void GetCardsJobDB()
        {
            string[] jobSplit = cmboJob.Text.Split('|');

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
                    commandComp.CommandText = "select * from job_cards where job_number = '" + jobSplit[0] + "' and user_id = '" + UserProfile.ID + "' order by card_date;";
                    commandComp.CommandType = CommandType.Text;

                    SqlDataReader readerComp = commandComp.ExecuteReader();

                    while (readerComp.Read())
                    {
                        DateTime dateFound = (DateTime)readerComp["card_date"];
                        string cmboAdd = dateFound.ToString("MM/dd/yyyy");

                        string jobFound = (string)readerComp["job_number"];
                        string jobComp = string.Format("{0}", jobFound);
                        cmboAdd += "|" + jobComp;

                        string itemFound = (string)readerComp["item"];
                        string itemComp = string.Format("{0}", itemFound);
                        cmboAdd += "|" + itemComp;

                        string departmentFound = (string)readerComp["department"];
                        string departmentComp = string.Format("{0}", departmentFound);
                        cmboAdd += "|" + departmentComp;

                        string componentFound = (string)readerComp["component"];
                        string componentComp = string.Format("{0}", componentFound);
                        cmboAdd += "|" + componentFound;

                        decimal hoursComp = (decimal)readerComp["hours"];
                        cmboAdd += "|" + hoursComp.ToString();

                        decimal overtimeComp = (decimal)readerComp["overtime"];
                        cmboAdd += "|" + overtimeComp.ToString();

                        string notesFound = (string)readerComp["notes"];
                        string notesComp = string.Format("{0}", notesFound);

                        //CREATES ROW FOR EACH ITEM OF WORK FOR THE PASSED USER AND ADDS IT TO ARRAY OF ROWS
                        string[] row = { dateFound.ToString("MM/dd/yyyy"), jobComp, itemComp, departmentComp, componentComp, hoursComp.ToString(), overtimeComp.ToString(), notesComp };
                        CardRow[j] = row;
                        CardList[j] = new ListViewItem(CardRow[j]);
                        lvCards.Items.Add(CardList[j]);

                        cmboCards.Items.Add(cmboAdd);

                        j++;
                    }

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("GetCardsJobDB Failed");
            }
        }

        //GET CARDS BASED ON RANGE SPECIFIED IN COMBO BOXES
        private void GetCardsRangeDB()
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
                    commandComp.CommandText = "select * from job_cards where card_date between '" + dtpStart.Text + "' and '" + dtpEnd.Text + "' and user_id = '" + UserProfile.ID + "';";
                    commandComp.CommandType = CommandType.Text;

                    SqlDataReader readerComp = commandComp.ExecuteReader();

                    while (readerComp.Read())
                    {
                        DateTime dateFound = (DateTime)readerComp["card_date"];
                        string cmboAdd = dateFound.ToString("MM/dd/yyyy");

                        string jobFound = (string)readerComp["job_number"];
                        string jobComp = string.Format("{0}", jobFound);
                        cmboAdd += "|" + jobComp;

                        string itemFound = (string)readerComp["item"];
                        string itemComp = string.Format("{0}", itemFound);
                        cmboAdd += "|" + itemComp;

                        string departmentFound = (string)readerComp["department"];
                        string departmentComp = string.Format("{0}", departmentFound);
                        cmboAdd += "|" + departmentComp;

                        string componentFound = (string)readerComp["component"];
                        string componentComp = string.Format("{0}", componentFound);
                        cmboAdd += "|" + componentFound;

                        decimal hoursComp = (decimal)readerComp["hours"];
                        cmboAdd += "|" + hoursComp.ToString();

                        decimal overtimeComp = (decimal)readerComp["overtime"];
                        cmboAdd += "|" + overtimeComp.ToString();

                        string notesFound = (string)readerComp["notes"];
                        string notesComp = string.Format("{0}", notesFound);


                        //CREATES ROW FOR EACH ITEM OF WORK FOR THE PASSED USER AND ADDS IT TO ARRAY OF ROWS
                        string[] row = { dateFound.ToString("MM/dd/yyyy"), jobComp, itemComp, departmentComp, componentComp, hoursComp.ToString(), overtimeComp.ToString(), notesComp };
                        CardRow[j] = row;
                        CardList[j] = new ListViewItem(CardRow[j]);
                        lvCards.Items.Add(CardList[j]);

                        cmboCards.Items.Add(cmboAdd);

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

        //GET JOB CARD INFO AND SEND IT TO JOBCARDDETAIL BY OBJECT INSTANCE
        private void GetCardSend()
        {
            string[] cardElements = cmboCards.Text.Split('|');

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
                    MessageBox.Show("here");
                    connection.Open();

                    //
                    ///GET JOB PROCESSES FROM DB SPECIFIC TO LISTED EMPLOYEE
                    //       
                    SqlCommand commandComp = new SqlCommand();

                    commandComp.Connection = connection;
                    commandComp.CommandText = "delete from job_cards where card_date = '" + cardElements[0] + "' and job_number = '" + cardElements[1] + "' and item = '" + cardElements[2] + "' and department = '" + cardElements[3] +
                        "' and component = '" + cardElements[4] + "' and hours = '" + cardElements[5] + "' and overtime = '" + cardElements[6] + "' and user_id = '" + UserProfile.ID + "';";
                    commandComp.CommandType = CommandType.Text;

                    SqlDataReader readerComp = commandComp.ExecuteReader();

                    while (readerComp.Read())
                    {
                        DateTime dateFound = (DateTime)readerComp["card_date"];
                        string dateComp = dateFound.ToString("MM/dd/yyyy");
                        theRow[0] = dateComp;

                        string jobFound = (string)readerComp["job_number"];
                        string jobComp = string.Format("{0}", jobFound);
                        theRow[1] = jobComp;

                        string itemFound = (string)readerComp["item"];
                        string itemComp = string.Format("{0}", itemFound);
                        theRow[2] = itemComp;

                        decimal hoursComp = (decimal)readerComp["hours"];
                        theRow[3] = hoursComp.ToString();

                        decimal overtimeComp = (decimal)readerComp["overtime"];
                        theRow[4] = overtimeComp.ToString();

                    }

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("GetCardSend Failed");
            }
        }

        //SELECT JOB CARD IN DB TO DELETE
        private void DeleteRequestDB()
        {
            string[] cardElements = cmboCards.Text.Split('|');

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
                    SqlCommand jobSet = new SqlCommand();

                    jobSet.Connection = connection;
                    jobSet.CommandText = "delete from job_cards where card_date = '" + cardElements[0] + "' and job_number = '" + cardElements[1] + "' and item = '" + cardElements[2] + "' and department = '" + cardElements[3] +
                        "' and component = '" + cardElements[4] + "' and hours = '" + cardElements[5] + "' and overtime = '" + cardElements[6] + "' and user_id = '" + UserProfile.ID + "';";
                    jobSet.CommandType = CommandType.Text;

                    jobSet.ExecuteNonQuery();


                    deleteRequest = true;

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("DeleteRequestDB failed");
            }
        }

        //UPDATE TIME FOR ITEM AFFECTED BY DELETED JOB CARD
        private void UpdateItemTimeDB()
        {
            string[] cardElements = cmboCards.Text.Split('|');
            decimal hoursSpent = Convert.ToDecimal(cardElements[5]);
            hoursSpent += Convert.ToDecimal(cardElements[6]);

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
                    SqlCommand jobSet = new SqlCommand();

                    jobSet.Connection = connection;
                    jobSet.CommandText = "update job_processes set hrs_spent = hrs_spent - " + hoursSpent + ", hrs_left = hrs_left + " + hoursSpent + "  where job_number = '" + cardElements[1] + "' and item = '" + cardElements[2] + "';";
                    jobSet.CommandType = CommandType.Text;

                    jobSet.ExecuteNonQuery();

                    MessageBox.Show("Job Card Removed");

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("UpdateItemTimeDB failed");
            }
        }

        //EVENT HANDLER FOR SELECTING JOB CARD RANGE
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            GetCardsRangeDB();

            if(lvCards.Items.Count == 0)
            {
                MessageBox.Show("No cards made");
            }
        }

        //FOR ADDING SHOP JOB CARD
        private void pbJobCards_Click(object sender, EventArgs e)
        {
            JobCardAdder theAdder = new JobCardAdder();
            theAdder.ShowDialog();
        }

        //EVENT HANDLER FOR WHEN USER SELECTS JOB CARDS BY JOB NUMBER
        private void cmboJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCardsJobDB();

            if (lvCards.Items.Count == 0)
            {
                MessageBox.Show("No cards made");
            }
        }

        //EVENT HANDLER WHEN USER WANTS TO DELETE A SELECTED JOB CARD
        private void cmboCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] cardElements = cmboCards.Text.Split('|');
            if(cardElements[1] == "SHOP")
            {
                shopCard = true;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete your job card for Job#: " + cardElements[1], "Caption", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                DeleteRequestDB();
                if (deleteRequest == true && shopCard == false)
                {
                    UpdateItemTimeDB();
                    cmboCards.Text = "";
                }
                cmboCards.Text = "";
            }
            else
            {
                cmboCards.Text = "";
                MessageBox.Show("Delete Cancelled");
            }
        }

        //CLEAR ENTIRE FORM AND RESET TO DEFAULT VALUES
        private void btnClear_Click(object sender, EventArgs e)
        {
            lvCards.Items.Clear();
            cmboCards.Items.Clear();
            cmboJob.Text = " ";
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;
        }


        ///
        ///FOR BUTTON DESIGN
        ///
        ///
        ///
        private void pbJobCards_MouseEnter(object sender, EventArgs e)
        {
            int width = pbJobCards.Size.Width;
            int height = pbJobCards.Size.Height;
            int larger = 7;
            pbJobCards.Size = new Size(width + larger, height + larger);
        }

        private void pbJobCards_MouseLeave(object sender, EventArgs e)
        {
            int width = pbJobCards.Size.Width;
            int height = pbJobCards.Size.Height;
            int smaller = 7;
            pbJobCards.Size = new Size(width - smaller, height - smaller);
        }

    }
}
