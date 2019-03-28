using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace FLM_Job_Portal
{
    public partial class Login : Form
    {
        private static int LoginSuccess { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        //CHECK IF LOGIN INFORMATION IS CORRECT
        private void DBLoginCheck()
        {
            LoginSuccess = 0;
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
                    SqlCommand loginGet = new SqlCommand();

                    loginGet.Connection = connection;
                    loginGet.CommandText = "select * from user_profile where user_name = '" + txtName.Text +
                                                "' AND user_password = '" + txtPassword.Text + "';";
                    loginGet.CommandType = CommandType.Text;

                    SqlDataReader loginComp = loginGet.ExecuteReader();

                    while (loginComp.Read())
                    {
                        int loginFound = (int)loginComp["user_id"];
                        LoginSuccess = 1;
                    }

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Login Check Failed");
            }
        }

        //GET INFORMATION OF USER FROM DB AFTER LOGIN CHECK IS DONE
        public void DBGetUser()
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

                    //Assign user input to variables
                    string theName = txtName.Text;
                    string thePassword = txtPassword.Text;

                    //
                    ///Check username + password in DB
                    //       
                    SqlCommand commandComp = new SqlCommand();

                    commandComp.Connection = connection;
                    commandComp.CommandText = "select * from user_profile where user_name = '" + theName +
                                                "' AND user_password = '" + thePassword + "';";
                    commandComp.CommandType = CommandType.Text;

                    SqlDataReader readerComp = commandComp.ExecuteReader();

                    while (readerComp.Read())
                    {
                        int userFound = (int)readerComp["user_id"];
                        string userKey = string.Format("{0}", Convert.ToInt32(userFound));
                        UserProfile.ID = userFound;

                        string uNameFound = (string)readerComp["user_name"];
                        string uNameComp = string.Format("{0}", uNameFound);
                        UserProfile.Name = uNameComp;

                        string passwordFound = (string)readerComp["user_password"];
                        string passwordComp = string.Format("{0}", passwordFound);
                        UserProfile.Password = passwordComp;

                        string firstFound = (string)readerComp["first_name"];
                        string firstComp = string.Format("{0}", firstFound);
                        UserProfile.First = firstComp;

                        string lastFound = (string)readerComp["last_name"];
                        string lastComp = string.Format("{0}", lastFound);
                        UserProfile.Last = lastComp;

                        string emailFound = (string)readerComp["email"];
                        string emailComp = string.Format("{0}", emailFound);
                        UserProfile.Email = emailComp;

                        int amountFound = (int)readerComp["job_amount"];
                        UserProfile.JobAmount = amountFound;

                        MessageBox.Show("Login Successful");

                        //Variable used throughout program to reference user that logged in
                        UserProfile.ID = Convert.ToInt32(userFound);
                        UserProfile.UserInfoGet();
                    }

                }
            }
            catch (SqlException)
            {
                MessageBox.Show("\t\tIncorrect Login \n" +
                                "Please enter the correct information and try again");
            }
        }

        //WHEN USER CLICKS SUBMIT CHECKS INFO AND ASSIGNS INFO TO STATIC CLASS ITEM
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DBLoginCheck();

            //IF ELSE FOR LOGIN INFORMATION CHECK
            if (LoginSuccess == 1)
            {
                DBGetUser();

                if (UserProfile.Admin == 0)
                {
                    //OPENS HOME FORM FOR NON ADMIN USERS
                    this.Hide();
                    HomeNonAdmin theHomeNonAdmin = new HomeNonAdmin();
                    theHomeNonAdmin.ShowDialog();
                    this.Close();
                }
                else if(UserProfile.Admin == 1)
                {
                    //OPENS HOME FORM AND HIDES LOGIN FORM
                    this.Hide();
                    Home theHome = new Home();
                    theHome.ShowDialog();
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("\t       Incorrect Login \n" +
                               "Please check information entered try again");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

