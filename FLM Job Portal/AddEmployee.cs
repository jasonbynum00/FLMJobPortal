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
    public partial class AddEmployee : Form
    {
        UserProfile theUser = new UserProfile();
        string[][] WorkListRow = new string[100][];
        ListViewItem[] theWorkList = new ListViewItem[100];
        string theJob;
        int lineCount;       
        string splitDue;

        public AddEmployee(string passedJob)
        {
            InitializeComponent();
            theJob = passedJob;

            GetAddEmployee();

        }

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

                        cmboEmployee.Items.Add(firstFound + " " + lastFound);

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
                    addWork.CommandText = "insert into job_processes values ( '" + theUser.AddID + "', '" + theJob + "', '" + (theUser.AddInitials + lineCount.ToString()) + "', '" + cmboDept.Text + "', '" + cmboComp.Text + "', '" + cmboHours.Text + "', '" + 0 + "', '" + cmboHours.Text +
                        "', '" + dtpDue.Text + "', '" + splitDue.Split('/')[0] + "', '" + splitDue.Split('/')[1] + "', '" + " " + "', '" + 0 + "', '" + 0 + "', '" + " " + "', '" + cmboQty.Text + "');";
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
                    addWork.CommandText = "insert into employee_jobs values ( '" + theUser.AddID + "', '" + theJob + "', '" + lineCount + "');";
                    addWork.CommandType = CommandType.Text;

                    addWork.ExecuteNonQuery();

                    MessageBox.Show("Employee Added");

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("UpdateEmployeeJobs failed");
            }
        }

        //ADDS NEW ITEM TO ARRAY TO PUT INTO LIST VIEW
        private void ShowSubmit(int selectedId)
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
                    commandComp.CommandText = "select * from job_processes where job_number = '" + theJob + "' and user_id = '" + selectedId + "';";
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

        //CLEAR ALL LISTS
        private void ClearList()
        {
            //CLEAR LISTVIEWITEM ARRAY
            for (int k = 0; k < lineCount; k++)
            {
                theWorkList[k].SubItems.Clear();
            }

            //CLEAR LIST VIEW
            lvAdded.Items.Clear();

        }

        //GET SELECTED EMPLOYEE INFORMATION IN ORDER TO ADD TO JOB
        private void cmboEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
           theUser.UserInfoGetAdd(cmboEmployee.SelectedIndex + 1);
        }

        //EVENT FOR ADD LINE BUTTON CLICK
        private void pbAddLine_Click(object sender, EventArgs e)
        {
            cmboEmployee.Enabled = false;
            ClearList();
            SubmitLine();
            ShowSubmit(theUser.AddID);
            for(int k = 0; k < lineCount; k++)
            {
                lvAdded.Items.Add(theWorkList[k]);               
            }
        }

        //CONFIRM EMPLOYEE ADDED AND SUBMIT WORK AMOUNT
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            UpdateEmployeeJobs();
            this.Close();
        }

        //EXIT THE FORM
        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        ///FOR BUTTON DESIGN
        ///
        ///
        // ADD LINE
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
