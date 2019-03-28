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
    public partial class EditWork : Form
    {
        //USE JOB NUMBER THROUGHOUT THE PROGRAM
        string theJob;
        //USE FOR COUNTING CLICKS OF ADD FOR ADDLIST
        int addClickCount = 0;

        /// 
        /// FOR GETTING EMPLOYEE WORK
        /// 
        List<int> EmployeeWorkingIDList = new List<int>();
        List<EmployeesOnJob> EmployeesOnJob = new List<EmployeesOnJob>();
        GroupBox[] theEmployeeGB = new GroupBox[10];
        ListView[] theEmployeeLV = new ListView[10];        
        ListViewItem[] theWorkList = new ListViewItem[100];
        string[][] WorkListRow = new string[100][];
        int passedWorkAmount;
        int i, j;

        /// 
        /// FOR GETTING EMPLOYEE PROFILE
        /// 
        List<EmployeesOnJob> EmployeeProfile = new List<EmployeesOnJob>();
        ListViewItem[] AddWorkList = new ListViewItem[100];
        string[][] AddListRow = new string[100][];
        int addCounter = 0;

        /// 
        /// FOR ADDING WORK TO EXISTING EMPLOYEE
        ///
        UserProfile theAddUser = new UserProfile();
        string[][] AddWorkListRow = new string[100][];
        ListViewItem[] AddtheWorkList = new ListViewItem[100];
        string theAddJob;
        int lineCount;
        string splitDue;

        /// 
        /// CONSTRUCTORS
        /// 
        public EditWork()
        {
            InitializeComponent();
        }

        public EditWork(string passedJob)
        {
            InitializeComponent();

            //VARIABLE FOR JOB# TO USE THROUGHOUT FORM
            theJob = passedJob;
            GetEmployeeIDList(theJob);

            //GENERATE EMPLOYEE WORK ON LEFT
            for (int j = 0; j < EmployeeWorkingIDList.Count; j++)
            {
                GetEmployeeList(theJob, EmployeeWorkingIDList[j]);
                CreateUserGB(j, EmployeesOnJob[j].ID, EmployeesOnJob[j].FirstName + " " + EmployeesOnJob[j].LastName);
            }

            //FILLING ADD COMBO BOX
            GetAddEmployee();

        }

        //OPENS ADD EMPLOYEE FORM
        private void pbAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee theAdd = new AddEmployee(theJob);
            theAdd.ShowDialog();
            this.Hide();
        }

        /// 
        /// FOR ADDING WORK ON EMPLOYEES CURRENTLY ON JOB
        /// 
        //GET THE EMPLOYEE INFO FOR ADD COMBO BOX
        private void GetAddEmployee()
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
                    commandComp.CommandText = "select * from user_profile order by user_id;";
                    commandComp.CommandType = CommandType.Text;

                    SqlDataReader readerComp = commandComp.ExecuteReader();

                    while (readerComp.Read())
                    {
                        int idFound = (int)readerComp["user_id"];

                        string firstFound = (string)readerComp["first_name"];

                        string lastFound = (string)readerComp["last_name"];

                        int amountFound = (int)readerComp["job_amount"];

                        string initialsFound = (string)readerComp["initials"];

                        cmboAddEmployee.Items.Add(firstFound + " " + lastFound);

                    }

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("GetAddEmployee Failed");
            }
        }

        //SUBMIT INFO FOR ADD LINE TO DB
        private void SubmitLine()
        {
            lineCount++;
            splitDue = dtpAddDue.Text;

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
                    addWork.CommandText = "insert into job_processes values ( '" + theAddUser.AddID + "', '" + theJob + "', '" + (theAddUser.AddInitials + lineCount.ToString()) + "', '" + cmboAddDept.Text + "', '" + cmboAddComp.Text + "', '" + cmboAddAllotted.Text + "', '" + 0 + "', '" + cmboAddAllotted.Text +
                        "', '" + dtpAddDue.Text + "', '" + splitDue.Split('/')[0] + "', '" + splitDue.Split('/')[1] + "', '" + " " + "', '" + 0 + "', '" + 0 + "', '" + " " + "');";
                    addWork.CommandType = CommandType.Text;

                    addWork.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("SubmitLine failed");
            }
        }

        //INSERT EMPLOYEE WORK INTO EMPLOYEE JOBS TABLE
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
                    addWork.CommandText = "update employee_jobs set work_amount = '" + theAddJob + "' where user_id = '" + cmboAddEmployee.SelectedIndex +"' and job_number = '" + theJob + "';";
                    addWork.CommandType = CommandType.Text;

                    addWork.ExecuteNonQuery();

                    MessageBox.Show("Work Added");

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("UpdateEmployeeJobs failed");
            }
        }

        //GET SELECTED EMPLOYEE INFORMATION AND SAVES FOR LINE SUBMIT
        private void cmboAddEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            theAddUser.UserInfoGetAdd(cmboAddEmployee.SelectedIndex + 1);
        }

        //CLEAR ALL GROUP BOXES AND REMAKE THEM WITH UPDATED INFORMATION
        private void ClearWork()
        {
            EmployeeWorkingIDList.Clear();
            EmployeesOnJob.Clear();
            for(int i = 0; i < 100; i++)
            {
                theWorkList[i].SubItems.Clear();
            }

            Array.Clear(WorkListRow, 0, WorkListRow.Length);

            flpEmployees.Controls.Clear();
        }

        //SEND ADDED WORK TO DB
        private void btnAddSubmit_Click(object sender, EventArgs e)
        {
            SubmitLine();
            UpdateEmployeeJobs();

            ClearWork();

            GetEmployeeIDList(theJob);

            //REGENERATE EMPLOYEE WORK ON LEFT
            for (int j = 0; j < EmployeeWorkingIDList.Count; j++)
            {
                GetEmployeeList(theJob, EmployeeWorkingIDList[j]);
                CreateUserGB(j, EmployeesOnJob[j].ID, EmployeesOnJob[j].FirstName + " " + EmployeesOnJob[j].LastName);
            }

            //CLEARS ALL COMBO BOX INFORMATION
            cmboAddEmployee.SelectedIndex = -1;
            cmboAddDept.SelectedIndex = -1;
            cmboAddComp.SelectedIndex = -1;
            cmboAddAllotted.SelectedIndex = -1;
        }


        /// 
        /// FILL CURRENT EMPLOYEE WORK
        /// 
        /// 
        //GET AMOUNT OF EMPLOYEES ON JOB
        private void GetEmployeeIDList(string passedJob)
        {
            i = 0;
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
                    commandComp.CommandText = "select id, work_amount from employee_jobs where job_number = '" + passedJob + "';";
                    commandComp.CommandType = CommandType.Text;

                    SqlDataReader readerComp = commandComp.ExecuteReader();

                    while (readerComp.Read())
                    {
                        int idFound = (int)readerComp["id"];
                        EmployeeWorkingIDList.Add(idFound);

                        passedWorkAmount = (int)readerComp["work_amount"];
                        EmployeesOnJob.Add(new EmployeesOnJob(idFound, passedWorkAmount));
                    }

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("GetEmployeeIDList Failed");
            }
        }

        //GETS EMPLOYEES CURRENTLY WORKING ON THE JOB
        private void GetEmployeeList(string passedJob, int theEmployee)
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
                    commandComp.CommandText = "select * from user_profile where user_id = '" + theEmployee + "';";
                    commandComp.CommandType = CommandType.Text;

                    SqlDataReader readerComp = commandComp.ExecuteReader();

                    while (readerComp.Read())
                    {
                        int iDComp = (int)readerComp["user_id"];

                        string firstFound = (string)readerComp["first_name"];
                        string firstComp = string.Format("{0}", firstFound);
                        EmployeesOnJob[i].FirstName = firstComp;

                        string lastFound = (string)readerComp["last_name"];
                        string lastComp = string.Format("{0}", lastFound);
                        EmployeesOnJob[i].LastName = lastComp;

                        string initialsFound = (string)readerComp["initials"];
                        string initialsComp = string.Format("{0}", initialsFound);
                        EmployeesOnJob[i].Initials = initialsComp;

                        i++;
                    }

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("GetEmployeeList Failed");
            }

        }

        //GENERATES GROUP BOXES AND LIST PANELS FOR EACH EMPLOYEE WORKING ON JOB
        private void CreateUserGB(int i, int iDNum, string empName)
        {
            //FIRST CREATES GROUP BOX
            GroupBox gB = new GroupBox();
            gB.Name = "employee" + i;
            gB.Text = empName;
            gB.Font = new Font("Microsoft YaHei UI", 14, FontStyle.Bold);
            gB.ForeColor = Color.White;
            gB.Width = 723;
            gB.Height = 325;
            gB.BackColor = Color.Transparent;

            //SECOND CREATES LIST VIEW AND INSERTS INTO GROUP BOX
            ListView lV = new ListView();
            lV.Name = "lvEmployee" + i;
            lV.Font = new Font("Microsoft YaHei UI", 8, FontStyle.Regular);
            lV.Width = 700;
            lV.Height = 291;
            lV.Location = new Point(6, 28);
            lV.View = View.Details;
            lV.GridLines = true;

            //ADD COLUMNS WITH PROPER NAMES
            lV.Columns.Add("Item", -2, HorizontalAlignment.Left);
            lV.Columns.Add("Qty", -2, HorizontalAlignment.Left);
            lV.Columns.Add("Department", -2, HorizontalAlignment.Left);
            lV.Columns.Add("Component", -2, HorizontalAlignment.Left);
            lV.Columns.Add("Hrs Allotted", -2, HorizontalAlignment.Left);
            lV.Columns.Add("Hrs Spent", -2, HorizontalAlignment.Left);
            lV.Columns.Add("Hrs Left", -2, HorizontalAlignment.Left);
            lV.Columns.Add("Date Due", -2, HorizontalAlignment.Left);
            lV.Columns.Add("Date Complete", -2, HorizontalAlignment.Left);
            lV.Columns.Add("Notes", -2, HorizontalAlignment.Left);

            gB.Controls.Add(lV);

            GetEmployeeWork(theJob, EmployeeWorkingIDList[i]);

            for (int j = 0; j < EmployeesOnJob[i].WorkAmount; j++)
            {
                lV.Items.Add(theWorkList[j]);
            }

            //ADD GENERATED EMPLOYEE GROUP BOX INTO ARRAY
            theEmployeeGB[i] = new GroupBox();
            theEmployeeGB[i].Controls.Add(gB);

            //ADD CREATED USER TO THE FORM
            flpEmployees.Controls.Add(gB);
        }

        //GETS LIST OF WORK FOR EACH EMPLOYEE
        private void GetEmployeeWork(string passedJob, int passedEmployee)
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

                        decimal spentFound = (decimal)readerComp["hrs_spent"];

                        decimal leftFound = (decimal)readerComp["hrs_left"];

                        string dueFound = (string)readerComp["date_due"];
                        string dueComp = string.Format("{0}", dueFound);

                        int monthDueComp = (int)readerComp["month_due"];

                        int dayDueComp = (int)readerComp["day_due"];

                        string completeFound = (string)readerComp["date_complete"];
                        string completeComp = string.Format("{0}", completeFound);

                        int monthCompleteComp = (int)readerComp["month_complete"];

                        int dayCompleteComp = (int)readerComp["day_complete"];

                        string notesFound = (string)readerComp["notes"];
                        string notesComp = string.Format("{0}", notesFound);

                        int qtyComp = (int)readerComp["quantity"];

                        //CREATES ROW FOR EACH ITEM OF WORK FOR THE PASSED USER AND ADDS IT TO ARRAY OF ROWS
                        string[] row = { itemComp, qtyComp.ToString(), departmentComp, componentComp, allottedFound.ToString(), spentFound.ToString(), leftFound.ToString(), dueComp, completeComp, notesComp };
                        WorkListRow[j] = row;
                        theWorkList[j] = new ListViewItem(WorkListRow[j]);

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

    }
}
