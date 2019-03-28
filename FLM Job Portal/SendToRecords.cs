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
    public partial class SendToRecords : Form
    {
        //VARIABLE TO CHECK IF JOB WAS SENT TO COMPLETED BEFORE REMOVING ELEMENTS FROM CURRENT TABLES
        public bool deleteCheck;

        public SendToRecords()
        {
            InitializeComponent();
            GetJobList();
        }

        //EVENT HANDLER FOR WHEN USER SUBMITS JOB TO FILE
        private void btnSend_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Send Job #" + cmboJob.SelectedItem.ToString() + " to your records?", "Caption", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    DeleteSend();
                    if(deleteCheck == true)
                    {
                        DeleteJob();
                        UpdateList();
                        UpdateJobAmount();
                        MoveProcess();
                        DeleteProcess();
                        MessageBox.Show("Job Filed");
                        this.Close();
                    }

                }
                catch (SqlException)
                {
                    MessageBox.Show("Delete click failed");
                }
            }
        }

        //EVENT HANDLER FOR WHEN USER EXITS FORM
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //GETS LIST OF JOB AND POPULATES COMBO BOX
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
                    jobFound.CommandText = "select job_number from job_list;";
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

        //INSERTS SELECTED JOB INTO NEW TABLE FOR SAVED JOBS
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
                    jobDelete.CommandText = "insert into completed_jobs select * from job_list where job_number = '" + cmboJob.Text + "';";
                    jobDelete.CommandType = CommandType.Text;

                    jobDelete.ExecuteNonQuery();

                    deleteCheck = true;

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("DeleteSend Failed");
            }
        }

        //DELETS JOB AFTER SAVE
        private void DeleteJob()
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
                    jobDelete.CommandText = "delete from job_list where job_number = '" + cmboJob.Text + "';";
                    jobDelete.CommandType = CommandType.Text;

                    jobDelete.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Delete Job failed");
            }
        }

        ///
        /// FOR PAST FORMAT, NEED TO REVISE
        /// 
        private void MoveProcess()
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
                    jobDelete.CommandText = "INSERT INTO completed_job_process SELECT * " +
                                            "FROM process_info WHERE job_number = '" + cmboJob.Text + "';";
                    jobDelete.CommandType = CommandType.Text;

                    jobDelete.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Could not move processes");
            }
        }

        private void DeleteProcess()
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
                    jobDelete.CommandText = "DELETE FROM process_info WHERE job_number = '" + cmboJob.Text + "';";
                    jobDelete.CommandType = CommandType.Text;

                    jobDelete.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Could not delete processes");
            }
        }

        //MOVE PRIORITY NUMBER UP ONE FOR JOBS BELOW SELECTED JOB THAT WAS FILED
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
                MessageBox.Show("Could not update job list");
            }
        }

        //UPDATE THE AMOUNT OF JOBS EMPLOYEES ARE ASSIGNED IN DB
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
                MessageBox.Show("UpdateJobAmount failed");
            }
        }

    }
}
