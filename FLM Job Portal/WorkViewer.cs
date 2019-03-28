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
    public partial class WorkViewer : Form
    {
        string[][] WorkRow = new string[100][];
        ListViewItem[] WorkList = new ListViewItem[100];

        public WorkViewer()
        {
            InitializeComponent();
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
                    commandComp.CommandText = "select * from job_list order by priority_number;";
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

        //GET LIST OF WORK FOR THE SELECTED JOB
        private void GetWorkByJob()
        {
            string[] jobElements = cmboJob.Text.Split('|');

            int j = 0;
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
                    commandComp.CommandText = "select * from job_processes where job_number = '" + jobElements[0] + "' and user_id = '" + UserProfile.ID + "';";
                    commandComp.CommandType = CommandType.Text;

                    SqlDataReader readerComp = commandComp.ExecuteReader();

                    while (readerComp.Read())
                    {
                        string jobFound = (string)readerComp["job_number"];
                        string jobComp = string.Format("{0}", jobFound);

                        string itemFound = (string)readerComp["item"];
                        string itemComp = string.Format("{0}", itemFound);

                        string departmentFound = (string)readerComp["department"];
                        string departmentComp = string.Format("{0}", departmentFound);

                        string componentFound = (string)readerComp["component"];
                        string componentComp = string.Format("{0}", componentFound);

                        decimal allottedComp = (decimal)readerComp["hrs_allotted"];

                        decimal spentComp = (decimal)readerComp["hrs_spent"];

                        decimal leftComp = (decimal)readerComp["hrs_left"];

                        string dueFound = (string)readerComp["date_due"];
                        string dueComp = string.Format("{0}", dueFound);

                        string completeFound = (string)readerComp["date_complete"];
                        string completeComp = string.Format("{0}", completeFound);

                        string notesFound = (string)readerComp["notes"];
                        string notesComp = string.Format("{0}", notesFound);

                        int qtyComp = (int)readerComp["quantity"];

                        //CREATES ROW FOR EACH ITEM OF WORK FOR THE PASSED USER AND ADDS IT TO ARRAY OF ROWS
                        string[] row = {jobComp, qtyComp.ToString(), itemComp, departmentComp, componentComp, allottedComp.ToString(), spentComp.ToString(), leftComp.ToString(), dueComp, completeComp, notesComp };
                        WorkRow[j] = row;
                        WorkList[j] = new ListViewItem(WorkRow[j]);
                        lvWork.Items.Add(WorkList[j]);

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

        //GETS WORK FOR JOB SELECTED IN COMBO BOX
        private void cmboJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetWorkByJob();           
        }

        //OPENS WORK COMPLETE FORM
        private void pbComplete_Click(object sender, EventArgs e)
        {
            WorkComplete theComplete = new WorkComplete();
            theComplete.ShowDialog();
        }

        //CLEAR GENERATED WORK ON FORM
        private void btnClear_Click(object sender, EventArgs e)
        {
            lvWork.Items.Clear();
            cmboJob.Text = "";
        }

        /// 
        ///BUTTON DESIGN
        ///
        ///
        //FOR COMPLETE BUTTON
        private void pbComplete_MouseEnter(object sender, EventArgs e)
        {
            int width = pbComplete.Size.Width;
            int height = pbComplete.Size.Height;
            int larger = 7;
            pbComplete.Size = new Size(width + larger, height + larger);
        }

        private void pbComplete_MouseLeave(object sender, EventArgs e)
        {
            int width = pbComplete.Size.Width;
            int height = pbComplete.Size.Height;
            int smaller = 7;
            pbComplete.Size = new Size(width - smaller, height - smaller);
        }
    }
}

/*
//GET WORK BASED ON RANGE SPECIFIED IN COMBO BOXES
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
            commandComp.CommandText = "select * from job_processes where date_due > '" + Convert.ToString(DateTime.Text("MM/dd/yyyy") + "';";
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
*/
