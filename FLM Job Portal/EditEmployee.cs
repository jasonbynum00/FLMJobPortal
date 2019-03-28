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
    public partial class EditEmployee : Form
    {
        //TO HOLD DATA OF EMPLOYEES ON LIST
        List<UserProfile> theUser = new List<UserProfile>();
        string[][] WorkListRow = new string[100][];
        ListViewItem[] theWorkList = new ListViewItem[100];
        string theJob, splitDue;
        int j, workCounter;


        //DEFAULT CONSTRUCTOR
        public EditEmployee()
        {
            InitializeComponent();
        }

        //CONSTRUCTOR TO EDIT EXISTING EMPLOYEE WORK
        public EditEmployee(string passedJob)
        {
            InitializeComponent();           
            theJob = passedJob;

            GetAddEmployee();
        }

        //GET THE EMPLOYEE INFO FOR ADD COMBO BOX
        private void GetAddEmployee()
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
                    commandComp.CommandText = "select user_profile.user_id, user_profile.first_name, user_profile.last_name, user_profile.job_amount, user_profile.initials " +
                        "from user_profile inner join employee_jobs on user_profile.user_id = employee_jobs.id; ; ";
                    commandComp.CommandType = CommandType.Text;

                    SqlDataReader readerComp = commandComp.ExecuteReader();

                    while (readerComp.Read())
                    {
                        theUser.Add(new UserProfile());
                        int idFound = (int)readerComp["user_id"];
                        theUser[k].AddID = idFound;

                        string firstFound = (string)readerComp["first_name"];
                        theUser[k].AddFirst = firstFound;

                        string lastFound = (string)readerComp["last_name"];
                        theUser[k].AddLast = lastFound;

                        int amountFound = (int)readerComp["job_amount"];
                        theUser[k].AddJobAmount = amountFound;

                        string initialsFound = (string)readerComp["initials"];
                        theUser[k].AddInitials = initialsFound;

                        cmboSelectEmp.Items.Add(firstFound + " " + lastFound);
                        k++;
                    }

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("GetAddEmployee Failed");
            }
        }

        //GET WORK CURRENTLY ASSIGNED TO SELECTED EMPLOYEE
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
                        string itemFound = (string)readerComp["item"];
                        string itemComp = string.Format("{0}", itemFound);

                        string departmentFound = (string)readerComp["department"];
                        string departmentComp = string.Format("{0}", departmentFound);

                        string componentFound = (string)readerComp["component"];
                        string componentComp = string.Format("{0}", componentFound);

                        decimal allottedFound = (decimal)readerComp["hrs_allotted"];

                        string dueFound = (string)readerComp["date_due"];
                        string dueComp = string.Format("{0}", dueFound);

                        int qtyComp = (int)readerComp["quantity"];


                        //CREATES ROW FOR EACH ITEM OF WORK FOR THE PASSED USER AND ADDS IT TO ARRAY OF ROWS
                        string[] row = { qtyComp.ToString(), itemComp, departmentComp, componentComp, allottedFound.ToString(), dueComp };
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

        //SUBMIT INFO FOR ADD LINE TO DB
        private void SubmitLine()
        {
            workCounter++;
            splitDue = dtpDue.Text;

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
                    addWork.CommandText = "insert into job_processes values ( '" + theUser[cmboSelectEmp.SelectedIndex].AddID + "', '" + theJob + "', '" + (theUser[cmboSelectEmp.SelectedIndex].AddInitials + workCounter.ToString()) + "', '" + cmboDept.Text + "', '" + cmboComp.Text + "', '" + cmboHours.Text + "', '" + 0 + "', '" + cmboHours.Text +
                        "', '" + dtpDue.Text + "', '" + splitDue.Split('/')[0] + "', '" + splitDue.Split('/')[1] + "', '" + " " + "', '" + 0 + "', '" + 0 + "', '" + " " + "', '" + cmboQty.Text + "');";
                    addWork.CommandType = CommandType.Text;

                    addWork.ExecuteNonQuery();

                    MessageBox.Show("Work Added");

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("SubmitLine failed");
            }
        }

        //CLEAR ALL LISTS
        private void ClearForm()
        {
            //CLEAR LISTVIEWITEM ARRAY
            for (int k = 0; k < workCounter - 1; k++)
            {
                MessageBox.Show("Hello");
                theWorkList[k].SubItems.Clear();
            }

            workCounter = 0;
            cmboDept.SelectedIndex = -1;
            cmboComp.SelectedIndex = -1;
            cmboHours.SelectedIndex = -1;
            dtpDue.Value = DateTime.Today.AddDays(-1);

            //CLEAR LIST VIEW
            lvAdded.Items.Clear();

        }

        //UPDATE THE EMPLOYEE JOBS TABLE IN DB
        private void UpdateEmployeeJobs()
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
                    addWork.CommandText = "update employee_jobs set work_amount = '" + workCounter + "' where id = '" + theUser[cmboSelectEmp.SelectedIndex].AddID + "' and job_number = '" + theJob + "';";
                    addWork.CommandType = CommandType.Text;

                    addWork.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("UpdateEmployeeJobs failed");
            }
        }

        //GET SELECTED EMPLOYEES WORK FROM DB AND PUTS IT ON THE LIST VIEW
        private void cmboSelectEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetWork(theJob, theUser[cmboSelectEmp.SelectedIndex].AddID);

            for (int k = 0; k < workCounter; k++)
            {
                lvAdded.Items.Add(theWorkList[k]);
            }
        }

        //FOR ADDING A LINE OF WORK TO ALREADY EXISTING LIST
        private void pbAddLine_Click(object sender, EventArgs e)
        {
            cmboSelectEmp.Enabled = false;

            SubmitLine();
            UpdateEmployeeJobs();
            ClearForm();            

            GetWork(theJob, theUser[cmboSelectEmp.SelectedIndex].AddID);
            for (int k = 0; k < workCounter; k++)
            {
                lvAdded.Items.Add(theWorkList[k]);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


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
