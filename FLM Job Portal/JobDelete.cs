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
    public partial class JobDelete : Form
    {
        public JobDelete()
        {
            InitializeComponent();
        }

        //CHECKS IF USER SELECTS A JOB, CONFIRMS SELECTION, DELETES JOB, CLOSES FORM
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure? Deleting this job will remove\n the job and all job cards from your records.", "Caption", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (cmboJob.SelectedIndex > -1)
                {
                    try
                    {
                        DeleteSend();
                        UpdateList();
                        UpdateJobAmount();
                        MessageBox.Show("Job Removed");
                        this.Close();
                    }
                    catch (SqlException)
                    {

                    }
                }
                else
                {
                    MessageBox.Show("You must select a job to delete");
                }
            }
            else
            {
                MessageBox.Show("Job Delete Cancelled");
            }
        }

        //CLOSES FORM
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //POPULATE LIST OF JOBS INTO COMBO BOX
        private void GetJobList()
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

                    SqlCommand jobFound = new SqlCommand();

                    jobFound.Connection = connection;
                    jobFound.CommandText = "select job_number from job_list order by priority_number";
                    jobFound.CommandType = CommandType.Text;

                    SqlDataReader jobRead = jobFound.ExecuteReader();


                    while (jobRead.Read())
                    {
                        string jobFind = (string)jobRead["job_number"];
                        cmboJob.Items.Add(jobFind);
                    }
                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("GetJobList failed");
            }
        }

        //DELETE QUERY TO DB
        private void DeleteSend()
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
                    SqlCommand jobDelete = new SqlCommand();

                    jobDelete.Connection = connection;
                    jobDelete.CommandText = "delete from job_list where job_number = '" + cmboJob.SelectedItem + "';";
                    jobDelete.CommandType = CommandType.Text;

                    jobDelete.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Could not delete job");
            }
        }

        //ADJUST THE PRIORITIES TO SHIFT IN PLACE OF THE DELETED JOB IN DB
        private void UpdateList()
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
                    SqlCommand jobUpdate = new SqlCommand();

                    jobUpdate.Connection = connection;
                    jobUpdate.CommandText = "UPDATE job_list set priority_number = priority_number - 1 where priority_number > '" + (cmboJob.SelectedIndex + 1) + "';";
                    jobUpdate.CommandType = CommandType.Text;

                    jobUpdate.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Could not delete job");
            }
        }

        //DECREASE THE JOB AMOUNT FOR ALL USER PROFILES IN DB
        private void UpdateJobAmount()
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
                    SqlCommand jobUpdate = new SqlCommand();

                    jobUpdate.Connection = connection;
                    jobUpdate.CommandText = "update user_profile set job_amount = job_amount - 1;";
                    jobUpdate.CommandType = CommandType.Text;

                    jobUpdate.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Could not update job amount");
            }
        }

    }
}
