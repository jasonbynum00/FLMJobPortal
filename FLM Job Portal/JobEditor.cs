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
    public partial class JobEditor : Form
    {
        //HOLDS ORIGINAL VALUE FOR REFERENCED JOB WHEN EDITING
        public static string TheJob { get; set; }

        //DEFAULT CONSTRUCTOR
        public JobEditor()
        {
            InitializeComponent();
        }

        //CONSTRUCTOR FOR GETTING COMBO BOX IN HOME
        public JobEditor(string theJob)
        {
            InitializeComponent();
            TheJob = theJob;
            GetEdited();
        }

        //EXECUTED EDIT QUERY TO DB
        private void btnEdit_Click(object sender, EventArgs e)
        {
            SubmitEdited();
        }

        //CLOSE FORM
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //RETRIEVE INFO FOR SELECTED JOB AND POPULATES FORM OBJECTS
        private void GetEdited()
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

                    SqlCommand editGet = new SqlCommand();

                    editGet.Connection = connection;
                    editGet.CommandText = "select * from job_list where job_number = '" + TheJob + "';";
                    editGet.CommandType = CommandType.Text;

                    SqlDataReader editRead = editGet.ExecuteReader();

                    //Assign User info from DB to UserProfile object
                    while (editRead.Read())
                    {
                        string numEditFound = (string)editRead["job_number"];
                        txtNumber.Text = numEditFound;

                        string custEditFound = (string)editRead["customer"];
                        txtCustomer.Text = custEditFound;

                        string dueEditFound = (string)editRead["due_date"];
                        dtpDue.Text = dueEditFound;

                        decimal quotedEditFound = (decimal)editRead["quoted_hours"];
                        txtQuoted.Text = quotedEditFound.ToString();
                    }
                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("GetEdited Failed");
            }
        }

        //SENDS QUERY TO DB EDITING THE SELECTED JOB
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
                    editSet.CommandText = "UPDATE job_list set job_number = '" + txtNumber.Text + "', customer = '" + txtCustomer.Text.ToUpper() + "', due_date = '" +
                                            dtpDue.Text + "', quoted_hours = '" + txtQuoted.Text + "' where job_number = '" + TheJob + "';";
                    editSet.CommandType = CommandType.Text;

                    editSet.ExecuteNonQuery();

                    MessageBox.Show("Job Edit Successful");

                    connection.Close();
                    this.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("SubmitEdited failed");
            }
        }
    }
}
