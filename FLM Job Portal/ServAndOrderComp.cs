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
    public partial class ServAndOrderComp : Form
    {
        string thePO;
        DateTime selectedDate;
        int orderOrService;

        public ServAndOrderComp(int passedOrderOrService, string passedPO)
        {
            InitializeComponent();

            thePO = passedPO;
            orderOrService = passedOrderOrService;

            lblPO.Text += " " + passedPO;

            //IF THE FORM WAS CREATED BY UPDATING ORDER, CHANGE THE FORM PROPERTIES
            if(orderOrService == 0)
            {
                var bmp = new Bitmap(FLM_Job_Portal.Properties.Resources.shipping);
                pbServAndOrder.Image = bmp;

                lblComplete.Text = "MARK ORDER\n COMPLETE";
            }

        }

        //EVENT HANDLER TO SEND THE COMPLETED DATE TO THE ITEM IN THE DB
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //SEND UPDATES ACCORDING TO IF THE UPDATE IS FOR AN ORDER OR SERVICE
            switch(orderOrService)
            {
                case 0:
                    UpdateOrders();
                    break;
                case 1:
                    UpdateService();
                    break;
            }

            this.Close();
        }

        //EVENT HANDLER TO CLOSE THE FORM
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //SEND UPDATE TO OUTSIDE SERVICE TABLE IN DB
        private void UpdateService()
        {
            selectedDate = Convert.ToDateTime(calComplete.SelectionRange.Start.ToString());
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
                    jobSet.CommandText = "update outside_services set date_received = '" + selectedDate + "' where po_number = '" + thePO + "';";
                    jobSet.CommandType = CommandType.Text;

                    jobSet.ExecuteNonQuery();

                    MessageBox.Show("Service Complete");

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("UpdateService failed");
            }
        }

        //SEND UPDATE TO PARTS TO ORDER IN DB
        private void UpdateOrders()
        {
            selectedDate = Convert.ToDateTime(calComplete.SelectionRange.Start.ToString());
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
                    jobSet.CommandText = "update parts_to_order set date_received = '" + selectedDate + "' where po_number = '" + thePO + "';";
                    jobSet.CommandType = CommandType.Text;

                    jobSet.ExecuteNonQuery();

                    MessageBox.Show("Service Complete");

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("UpdateService failed");
            }
        }

    }
}
