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
    public partial class JobStatusUpdate : Form
    {
        public JobStatusUpdate()
        {
            InitializeComponent();
            GetEdit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SubmitEdited();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetEdit()
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
                    SqlCommand jobEdit = new SqlCommand();

                    jobEdit.Connection = connection;
                    jobEdit.CommandText = "select job_number from job_list order by priority_number;";
                    jobEdit.CommandType = CommandType.Text;

                    SqlDataReader jobEditRead = jobEdit.ExecuteReader();

                    //Assign User info from DB to UserProfile object
                    while (jobEditRead.Read())
                    {
                        string editFound = (string)jobEditRead["job_number"];
                        cmboJob.Items.Add(editFound);
                    }
                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("GetEdit Failed");
            }
        }

        private void SubmitEdited()
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
                    SqlCommand editSet = new SqlCommand();

                    editSet.Connection = connection;
                    editSet.CommandText = "UPDATE job_list set job_status = '" + cmboStatus.Text + "' where job_number = '" + cmboJob.Text + "';";
                    editSet.CommandType = CommandType.Text;

                    editSet.ExecuteNonQuery();

                    MessageBox.Show("Status Updated");

                    connection.Close();
                    this.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Job Edit failed");
            }
        }

    }
}
