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
    class UserProfile
    {
        public static int ID { get; set; }
        public static string First { get; set; }
        public static string Last { get; set; }
        public static string Name { get; set; }
        public static string Password { get; set; }
        public static string Email { get; set; }
        public static int JobAmount { get; set; }
        public static int Admin { get; set; }
        public static string Initials { get; set; }

        //FOR ADD EMPLOYEE
        public int AddID { get; set; }
        public string AddFirst { get; set; }
        public string AddLast { get; set; }
        public string AddName { get; set; }
        public string AddPassword { get; set; }
        public string AddEmail { get; set; }
        public int AddJobAmount { get; set; }
        public int AddAdmin { get; set; }
        public string AddInitials { get; set; }


        //Create array of JobItems according to amount user has 
        public static JobItem[] theJobs = new JobItem[JobAmount];

        //Get info for user when log in successful
        public static void UserInfoGet()
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
                    SqlCommand comFind = new SqlCommand();

                    comFind.Connection = connection;
                    comFind.CommandText = "select * from user_profile where user_id = '" + UserProfile.ID.ToString() + "';";
                    comFind.CommandType = CommandType.Text;

                    SqlDataReader comRead = comFind.ExecuteReader();

                    //Assign User info from DB to UserProfile object
                    while (comRead.Read())
                    {
                        int userFound = (int)comRead["user_id"];

                        string firstFound = (string)comRead["first_name"];
                        string firstComp = string.Format("{0}", firstFound);

                        string lastFound = (string)comRead["last_name"];
                        string lastComp = string.Format("{0}", lastFound);

                        string userNameFound = (string)comRead["user_name"];
                        string userNameComp = string.Format("{0}", userNameFound);

                        string userPassFound = (string)comRead["user_password"];
                        string userPassComp = string.Format("{0}", userPassFound);

                        int currentJobsFound = (int)comRead["job_amount"];

                        int adminFound = (int)comRead["admin"];

                        UserProfile.ID = userFound;
                        UserProfile.First = firstComp.ToString();
                        UserProfile.Last = lastComp.ToString();
                        UserProfile.Initials = First[0].ToString();
                        UserProfile.Initials += Last[0].ToString();
                        UserProfile.Name = userNameComp.ToString();
                        UserProfile.Password = userPassComp.ToString();
                        UserProfile.JobAmount = currentJobsFound;
                        UserProfile.Admin = adminFound;

                    }
                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Could not retrieve user info");
            }
        }


        ///
        /// FUNCTIONS AND CONSTRUCTOR FOR ADDEMPLOYEE FORM
        /// 
        /// 
        //GET INFO FOR USER SELECTED IN ADD EMPLOYEE
        public void UserInfoGetAdd(int passedId)
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
                    SqlCommand comFind = new SqlCommand();

                    comFind.Connection = connection;
                    comFind.CommandText = "select * from user_profile where user_id = '" + passedId + "';";
                    comFind.CommandType = CommandType.Text;

                    SqlDataReader comRead = comFind.ExecuteReader();

                    //Assign User info from DB to UserProfile object
                    while (comRead.Read())
                    {
                        int userFound = (int)comRead["user_id"];

                        string firstFound = (string)comRead["first_name"];
                        string firstComp = string.Format("{0}", firstFound);

                        string lastFound = (string)comRead["last_name"];
                        string lastComp = string.Format("{0}", lastFound);

                        int currentJobsFound = (int)comRead["job_amount"];

                        this.AddID = userFound;
                        this.AddFirst = firstComp.ToString();
                        this.AddLast = lastComp.ToString();
                        this.AddInitials = firstComp[0].ToString();
                        this.AddInitials += lastComp[0].ToString();
                        this.AddJobAmount = currentJobsFound;

                    }
                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Could not retrieve user info");
            }
        }

        //DEFAULT CONSTRUCTOR
        public UserProfile()
        {

        }

        //CONSTRUCTOR FOR ADD EMPLOYEE FORM
        public UserProfile(int selectedId)
        {
            MessageBox.Show(selectedId.ToString());
            UserInfoGetAdd(selectedId);
        }
    }
}
