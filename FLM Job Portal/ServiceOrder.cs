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
    public partial class ServiceOrder : Form
    {
        public string theJob, thePO;
        bool orderUpdate;

        //DEFAULT CONSTRUCTOR FOR NEW SERVICE FROM HOME
        public ServiceOrder()
        {
            InitializeComponent();

            lblReceived.Visible = false;
            dtpReceived.Visible = false;

            GetJobList();
            GetEmployees();
            GetVendors();

        }

        //CONSTRUCTOR TO CREATE NEW SERVICE ORDER FROM JOBVIEW
        public ServiceOrder(string passedJob)
        {
            InitializeComponent();

            theJob = passedJob;
            cmboJob.Text = theJob;
            cmboJob.Enabled = false;

            lblReceived.Visible = false;
            dtpReceived.Visible = false;

            GetJobList();
            GetEmployees();
            GetVendors();
        }

        //CONSTRUCTOR TO UPDATE EXISTING SERVICE ORDER REQUEST
        public ServiceOrder(string passedJob, string passedPO)
        {
            InitializeComponent();

            orderUpdate = true;

            lblOrderForm.Text = "UPDATE SERVICE" + System.Environment.NewLine + "FORM";

            theJob = passedJob;
            thePO = passedPO;

            GetJobList();
            GetEmployees();
            GetVendors();

            GetServiceOrder();
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

        //GET EXISTING SERVICE ORDER TO BE EDITED
        public void GetServiceOrder()
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
                    jobFound.CommandText = "select * from outside_services where job_number = '" + theJob + "' and po_number = '" + thePO + "';";
                    jobFound.CommandType = CommandType.Text;

                    SqlDataReader jobRead = jobFound.ExecuteReader();


                    while (jobRead.Read())
                    {
                        string jobFind = (string)jobRead["job_number"];
                        cmboJob.Text = jobFind;

                        string poFind = (string)jobRead["po_number"];
                        txtPO.Text = poFind;

                        string requestedFind = (string)jobRead["requested_by"];
                        cmboEmployee.Text = requestedFind;

                        int quantityFind = (int)jobRead["quantity"];
                        cmboQty.Text = quantityFind.ToString();

                        string partFind = (string)jobRead["part"];
                        txtPart.Text = partFind;

                        string serviceFind = (string)jobRead["service"];
                        cmboService.Text = serviceFind;

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
                MessageBox.Show("GetServiceOrder failed");
            }
        }

        //SEND NEW SERVICE ORDER TO DB
        private void SendServiceOrder()
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
                    jobSet.CommandText = "insert into outside_services values ('" + cmboJob.Text + "', '" + txtPO.Text + "', '" + cmboEmployee.Text + "', '" + Convert.ToInt32(cmboQty.Text) +
                        "', '" + txtPart.Text + "', '" + cmboService.Text + "', '" + txtDescription.Text + "', '" + cmboVendor.Text + "', '" + dtpOrdered.Value + "', '" + dtpETA.Value + "', '" + " " + "');";
                    jobSet.CommandType = CommandType.Text;

                    jobSet.ExecuteNonQuery();

                    MessageBox.Show("Service Order Created");

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("SendServiceOrder failed");
            }
        }

        //UPDATES AN EXISTING SERVICE ORDER IN DB
        private void UpdateServiceOrder()
        {
            string[] nameSplit = cmboEmployee.Text.Split(' ');
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
                    jobSet.CommandText = "update outside_services set job_number = '" + cmboJob.Text + "', po_number = '" + txtPO.Text + "', requested_by = '" + cmboEmployee.Text + "', quantity = '" + cmboQty.Text + 
                        "', part = '" + txtPart.Text + "', service = '" + cmboService.Text + "', description = '" + txtDescription.Text + "', vendor = '" + cmboVendor.Text + 
                        "', date_ordered = '" + dtpOrdered.Value + "', eta = '" + dtpETA.Value + "' where po_number = '" + thePO + "';";
                    jobSet.CommandType = CommandType.Text;

                    jobSet.ExecuteNonQuery();

                    MessageBox.Show("Order Updated");

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("UpdateServiceOrder failed");
            }
        }

        //EVENT HANDLER FOR BUTTON SUBMIT
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(orderUpdate == true)
            {
                UpdateServiceOrder();
                this.Close();
            }
            else
            {
                SendServiceOrder();
                this.Close();
            }
        }

        //EVENT HANDLER FOR BUTTON EXIT
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
