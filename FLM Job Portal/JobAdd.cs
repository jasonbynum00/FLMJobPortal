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
    public partial class JobAdd : Form
    {
        //USED IN PRIORITYCHECK FUNCTION
        public static int PriorityCatch { get; set; }

        public JobAdd()
        {
            InitializeComponent();
        }

        //SUBMIT FORM
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            JobSend();
            UserProfile.JobAmount++;
            JobAmountUpdate();
            this.Close();
        }

        //CLOSE FORM
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //ENSURES THE PRIORITY NUMBER BEING ADDED IS NOT ALREADY PRESENT IN DB
        private void PriorityCheck(int priorityPick)
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
                    SqlCommand priorityFind = new SqlCommand();

                    priorityFind.Connection = connection;
                    priorityFind.CommandText = "select priority_number from job_list where priority_number = '" + priorityPick + "';";
                    priorityFind.CommandType = CommandType.Text;

                    SqlDataReader priorityRead = priorityFind.ExecuteReader();

                    //Assign User info from DB to UserProfile object
                    while (priorityRead.Read())
                    {
                        int priorityFound = (int)priorityRead["priority_number"];
                        JobAdd.PriorityCatch = priorityFound;
                    }
                    connection.Close();
                }
            }
            catch (SqlException)
            {
                JobAdd.PriorityCatch = 0;
            }
        }

        //INSERT STATEMENT INTO JOB LIST TABLE IN DB
        private void JobSend()
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
                    SqlCommand jobSet = new SqlCommand();

                    jobSet.Connection = connection;
                    jobSet.CommandText = "insert into job_list(job_number, customer, due_date, priority_number, job_status, quoted_hours)" +
                                            " VALUES ('" + txtNumber.Text.ToUpper() + "', '" + txtCustomer.Text.ToUpper() + "', '" + dtpDue.Text + "', '" +
                                            (UserProfile.JobAmount + 1) + "', '" + cmboStatus.Text + "', '" + txtQuoted.Text + "');";
                    jobSet.CommandType = CommandType.Text;

                    jobSet.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("jobsend failed");
            }
        }

        //UPDATE THE AMOUNT OF JOBS LISTED ON ALL USER PROFILES
        private void JobAmountUpdate()
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
                    SqlCommand jobSet = new SqlCommand();

                    jobSet.Connection = connection;
                    jobSet.CommandText = "update user_profile set job_amount = '" + UserProfile.JobAmount + "';";
                    jobSet.CommandType = CommandType.Text;

                    jobSet.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("amount update failed");
            }
        }
    }
}
