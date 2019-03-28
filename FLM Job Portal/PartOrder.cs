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
    public partial class PartOrder : Form
    {
        public string theJob, thePO, requestInitials;
        bool orderUpdate;

        //CONSTRUCTOR FOR CREATING A NEW PART ORDER
        public PartOrder()
        {
            InitializeComponent();

            GetEmployees();
            GetJobList();
            GetVendors();
        }

        //CONSTRUCTOR FOR WHEN ADDING AN ORDER FROM JOBVIEW
        public PartOrder(string theJob)
        {
            InitializeComponent();

            GetVendors();
            GetEmployees();

            cmboJob.Text = theJob;
            cmboJob.Enabled = false;
        }

        //CONSTRUCTOR FOR EDITING EXISTING ORDER FROM JOBVIEW
        public PartOrder(string passedJob, string passedPO)
        {
            InitializeComponent();

            lblOrderForm.Text = "EDIT EXISTING/n ORDER";

            theJob = passedJob;
            thePO = passedPO;
            orderUpdate = true;

            GetEmployees();
            GetJobList();
            GetVendors();
            GetOrder();
        }

        //GET LIST OF CURRENT JOBS AND ADD THEM TO COMBO BOX
        public void GetJobList()
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
                    jobFound.CommandText = "select job_number from job_list order by priority_number;";
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

        //GET EMPLOYEES AND ADD THEM TO COMBO BOX
        public void GetEmployees()
        {
            int i = 0;
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

                    SqlCommand commandComp = new SqlCommand();

                    commandComp.Connection = connection;
                    commandComp.CommandText = "select * from user_profile order by user_id;";
                    commandComp.CommandType = CommandType.Text;

                    SqlDataReader readerComp = commandComp.ExecuteReader();

                    while (readerComp.Read())
                    {
                        int iDComp = (int)readerComp["user_id"];

                        string firstFound = (string)readerComp["first_name"];
                        string firstComp = string.Format("{0}", firstFound);

                        string lastFound = (string)readerComp["last_name"];
                        string lastComp = string.Format("{0}", lastFound);

                        cmboEmployee.Items.Add(firstComp + " " + lastComp);

                        i++;
                    }

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("GetEmployees Failed");
            }
        }

        //GET LIST OF VENDORS FROM DB
        public void GetVendors()
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
                    jobFound.CommandText = "select company from vendors;";
                    jobFound.CommandType = CommandType.Text;

                    SqlDataReader jobRead = jobFound.ExecuteReader();


                    while (jobRead.Read())
                    {
                        string vendorFind = (string)jobRead["company"];
                        cmboVendor.Items.Add(vendorFind);
                    }
                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("GetVendors failed");
            }
        }

        //GET ORDER TO BE EDITED FROM DB
        public void GetOrder()
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
                    jobFound.CommandText = "select * from parts_to_order where job_number = '" + theJob + "' and po_number = '" + thePO + "';";
                    jobFound.CommandType = CommandType.Text;

                    SqlDataReader jobRead = jobFound.ExecuteReader();


                    while (jobRead.Read())
                    {
                        string jobFind = (string)jobRead["job_number"];
                        cmboJob.Text = jobFind;

                        int quantityFind = (int)jobRead["quantity"];
                        cmboQty.Text = quantityFind.ToString();

                        string poFind = (string)jobRead["po_number"];
                        txtPO.Text = poFind;

                        string descriptionFind = (string)jobRead["description"];
                        txtDescription.Text = descriptionFind;

                        string vendorFind = (string)jobRead["vendor"];
                        cmboVendor.Text = vendorFind;

                        DateTime orderedFind = (DateTime)jobRead["date_ordered"];
                        dtpOrdered.Text = orderedFind.ToString("MM/dd/yyyy");

                        DateTime etaFind = (DateTime)jobRead["eta"];
                        dtpETA.Text = etaFind.ToString("MM/dd/yyyy");
                    }
                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("GetOrder failed");
            }
        }

        //SEND NEW ORDER TO DB
        private void SendOrder()
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
                    jobSet.CommandText = "insert into parts_to_order values ('" + cmboJob.Text + "', '" + txtPO.Text + "', '" + cmboEmployee.Text + "', '" + cmboQty.Text + "', '" + txtDescription.Text +
                        "', '" + cmboVendor.Text + "', '" + dtpOrdered.Text + "', '" + dtpETA.Text + "');";
                    jobSet.CommandType = CommandType.Text;

                    jobSet.ExecuteNonQuery();

                    MessageBox.Show("Order Created");

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("SendOrder failed");
            }
        }

        //UPDATE EXISTING ORDER
        private void UpdateOrder()
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
                    jobSet.CommandText = "update parts_to_order set job_number = '" + cmboJob.Text + "', quantity = '" + cmboQty.Text + "', po_number = '" + txtPO.Text + "', description = '" + txtDescription.Text +
                        "', vendor = '" + cmboVendor.Text + "', date_ordered = '" + dtpOrdered.Value + "', eta = '" + dtpETA.Value + "' where po_number = '" + thePO + "';";
                    jobSet.CommandType = CommandType.Text;

                    jobSet.ExecuteNonQuery();

                    MessageBox.Show("Order Created");

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("UpdateOrder failed");
            }
        }

        //EVENT HANDLER FOR SUBMIT
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(orderUpdate == false)
            {
                SendOrder();
                this.Close();
            }
            else if(orderUpdate == true)
            {
                UpdateOrder();
                this.Close();
            }
        }

        //EVENT HANDLER FOR EXIT
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
