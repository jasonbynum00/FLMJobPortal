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
    public partial class WorkComplete : Form
    {
        string[][] WorkRow = new string[100][];
        ListViewItem[] WorkList = new ListViewItem[100];
        string theJob, cmboAdder;

        //DEFAULT CONSTRUCTOR GETS ALL WORK ASSIGNED TO USER
        public WorkComplete()
        {
            InitializeComponent();

            GetAllWork();
        }

        //CONSTRUCTOR FOR GETTING WORK TO MARK COMPLETE FROM JOBVIEW
        public WorkComplete(string passedJob)
        {
            InitializeComponent();

            theJob = passedJob;

            GetWork();
        }

        //EVENT HANDLER FOR SELECTING A PROCESS TO MARK COMPLETE
        private void cmboCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] cardElements = cmboItem.Text.Split('|');

            var confirmResult = MessageBox.Show("Are you sure you want to mark [" + cardElements[0] + " | " + cardElements[1] + " | " + cardElements[2] + "] complete?", "Caption", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                MarkCompleteDB();
                cmboItem.Text = "";
            }
            else
            {
                cmboItem.Text = "";
                MessageBox.Show("Cancelled");
            }
        }

        //EVENT HANDLER TO EXIT THE FORM
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //GETS THE WORK ASSIGNED TO THE USER AND DISPLAYS IN LISTVIEW
        public void GetWork()
        {
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
                    commandComp.CommandText = "select * from job_processes where job_number = '" + theJob + "' and user_id = '" + UserProfile.ID + "';";
                    commandComp.CommandType = CommandType.Text;

                    SqlDataReader readerComp = commandComp.ExecuteReader();

                    while (readerComp.Read())
                    {
                        string jobFound = (string)readerComp["job_number"];
                        string jobComp = string.Format("{0}", jobFound);

                        int qtyComp = (int)readerComp["quantity"];
                        cmboAdder = qtyComp.ToString();

                        string itemFound = (string)readerComp["item"];
                        string itemComp = string.Format("{0}", itemFound);
                        cmboAdder += "|" + itemComp;

                        string departmentFound = (string)readerComp["department"];
                        string departmentComp = string.Format("{0}", departmentFound);
                        cmboAdder += "|" + departmentComp;

                        string componentFound = (string)readerComp["component"];
                        string componentComp = string.Format("{0}", componentFound);
                        cmboAdder += "|" + componentComp;

                        decimal allottedComp = (decimal)readerComp["hrs_allotted"];

                        decimal spentComp = (decimal)readerComp["hrs_spent"];

                        decimal leftComp = (decimal)readerComp["hrs_left"];

                        string dueFound = (string)readerComp["date_due"];
                        string dueComp = string.Format("{0}", dueFound);

                        string completeFound = (string)readerComp["date_complete"];
                        string completeComp = string.Format("{0}", completeFound);

                        string notesFound = (string)readerComp["notes"];
                        string notesComp = string.Format("{0}", notesFound);

                        //ADD WORK TO COMBO BOX
                        cmboItem.Items.Add(cmboAdder);

                        //CREATES ROW FOR EACH ITEM OF WORK FOR THE PASSED USER AND ADDS IT TO ARRAY OF ROWS
                        string[] row = { jobComp, qtyComp.ToString(), itemComp, departmentComp, componentComp, allottedComp.ToString(), spentComp.ToString(), dueComp };
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
                MessageBox.Show("GetWork Failed");
            }
        }

        //GETS ALL THE WORK ASSIGNED TO THE USER AND DISPLAYS IN LISTVIEW
        public void GetAllWork()
        {
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
                    commandComp.CommandText = "select * from job_processes where user_id = '" + UserProfile.ID + "';";
                    commandComp.CommandType = CommandType.Text;

                    SqlDataReader readerComp = commandComp.ExecuteReader();

                    while (readerComp.Read())
                    {
                        string jobFound = (string)readerComp["job_number"];
                        string jobComp = string.Format("{0}", jobFound);

                        int qtyComp = (int)readerComp["quantity"];
                        cmboAdder = qtyComp.ToString();

                        string itemFound = (string)readerComp["item"];
                        string itemComp = string.Format("{0}", itemFound);
                        cmboAdder += "|" + itemComp;

                        string departmentFound = (string)readerComp["department"];
                        string departmentComp = string.Format("{0}", departmentFound);
                        cmboAdder += "|" + departmentComp;

                        string componentFound = (string)readerComp["component"];
                        string componentComp = string.Format("{0}", componentFound);
                        cmboAdder += "|" + componentComp;

                        decimal allottedComp = (decimal)readerComp["hrs_allotted"];

                        decimal spentComp = (decimal)readerComp["hrs_spent"];

                        decimal leftComp = (decimal)readerComp["hrs_left"];

                        string dueFound = (string)readerComp["date_due"];
                        string dueComp = string.Format("{0}", dueFound);

                        string completeFound = (string)readerComp["date_complete"];
                        string completeComp = string.Format("{0}", completeFound);

                        string notesFound = (string)readerComp["notes"];
                        string notesComp = string.Format("{0}", notesFound);

                        //ADD WORK TO COMBO BOX
                        cmboItem.Items.Add(cmboAdder);

                        //CREATES ROW FOR EACH ITEM OF WORK FOR THE PASSED USER AND ADDS IT TO ARRAY OF ROWS
                        string[] row = { jobComp, qtyComp.ToString(), itemComp, departmentComp, componentComp, allottedComp.ToString(), spentComp.ToString(), dueComp };
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
                MessageBox.Show("GetAllWork Failed");
            }
        }

        //SENDS COMPLETE DATE TO DB
        public void MarkCompleteDB()
        {
            //VARIABLES FOR PROCESS WORK AND COMPLETE TIME
            string[] processElements = cmboItem.Text.Split('|');
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
                    SqlCommand jobSet = new SqlCommand();

                    jobSet.Connection = connection;
                    jobSet.CommandText = "update job_processes set date_complete = '" + DateTime.Today + "', month_complete = '" + monthComplete + "', day_complete = '" +
                        dayComplete + "'  where item = '" + processElements[1] + "' and job_number = '" + theJob + "';";
                    jobSet.CommandType = CommandType.Text;

                    jobSet.ExecuteNonQuery();

                    MessageBox.Show(processElements[1] + " Complete!");

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("MarkCompleteDB failed");
            }
        }
    }
}
