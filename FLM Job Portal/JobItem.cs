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
    class JobItem
    {
        public int Priority { get; set; }
        public string Number { get; set; }
        public string Customer { get; set; }
        public string Due { get; set; }
        public int NoteCheck { get; set; }
        public string Status { get; set; }

        //DEFAULT CONSTRUCTOR
        public JobItem()
        {

        }

        //Get info from DB and create new class item with retrieved info
        public void DBGetJobList(int priorityNumber)
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
                    SqlCommand getJobList = new SqlCommand();

                    getJobList.Connection = connection;
                    getJobList.CommandText = "select * from job_list where priority_number = '" + priorityNumber + "';";
                    getJobList.CommandType = CommandType.Text;

                    SqlDataReader jobRead = getJobList.ExecuteReader();

                    //Assign User info from DB to UserProfile object
                    while (jobRead.Read())
                    {
                        int jobPriorityFound = (int)jobRead["priority_number"];
                        this.Priority = jobPriorityFound;

                        string jobNumFound = (string)jobRead["job_number"];
                        string jobNumComp = string.Format(jobNumFound);
                        this.Number = jobNumComp;

                        string jobCustFound = (string)jobRead["customer"];
                        string jobCustComp = string.Format("{0}", jobCustFound);
                        this.Customer = jobCustComp;

                        string jobDueFound = (string)jobRead["due_date"];
                        string jobDueComp = string.Format("{0}", jobDueFound);
                        this.Due = jobDueComp;

                        string statusFound = (string)jobRead["job_status"];
                        this.Status = statusFound;
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("DBGetJobList Failed");
            }
        }

        //Adding job into database
        public JobItem(string theNumber, string theCustomer, string theDate, int thePriority)
        {
            Number = theNumber;
            Customer = theCustomer;
            Due = theDate;
            Priority = thePriority;

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
                    ///Add components from DB
                    //       
                    SqlCommand jobInsert = new SqlCommand();

                    jobInsert.Connection = connection;
                    jobInsert.CommandText = "INSERT INTO job_list (job_number, customer, due_date, priority_number) " +
                                                "VALUES ( '" + Number + "', '" + Customer + "', '" + Due + "' ,'" + Priority + "' );";
                    jobInsert.CommandType = CommandType.Text;
                    SqlDataReader lineReader = jobInsert.ExecuteReader();

                    //Increment Job Counter
                    UserProfile.JobAmount++;

                    MessageBox.Show("Job # " + Number + " Added");

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Could not add job");
            }
        }

    }
}
