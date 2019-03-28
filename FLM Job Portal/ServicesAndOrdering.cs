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
    public partial class ServicesAndOrdering : Form
    {
        //VARIABLES TO USE THROUGHOUT THE FORM FOR THE JOB NUMBER, AMOUNT OF ROWS BEING ADDED
        //STRING ARRAY AND LISTVIEWITEM LIST FOR PARTS TO ORDER(ORDERLIST AND ORDERROW)
        public string theJob;
        public string[][] orderList = new string[100][];
        public List<ListViewItem> orderRow = new List<ListViewItem>();
        public int orderRowCount, tempCountOrder;

        //STRING ARRAY AND LISTVIEWITEM LIST FOR OUTSIDE SERVICES
        public string[][] serviceList = new string[100][];
        public List<ListViewItem> serviceRow = new List<ListViewItem>();
        public int serviceRowCount, tempCountService;

        //CONSTRUCTO WHEN VIEWING FROM HOME
        public ServicesAndOrdering()
        {
            InitializeComponent();

            GetJobList();
        }

        //CONSTRUCTOR WHEN VIEWING WORK FOR A JOB
        public ServicesAndOrdering(string passedJob)
        {
            InitializeComponent();
            theJob = passedJob;
            cmboJob.Text = theJob;
            cmboJob.Enabled = false;
            GetParts();
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

        /// 
        /// FUNCTIONS FOR GETTING LIST OF PARTS TO ORDER
        ///
        //GET EXISTING LIST OF PARTS TO ORDER FROM JOBVIEW
        public void GetParts()
        {
            string tempCombo;
            tempCountOrder = 0;
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
                    jobFound.CommandText = "select * from parts_to_order where job_number = '" + theJob + "' order by po_number;";
                    jobFound.CommandType = CommandType.Text;

                    SqlDataReader jobRead = jobFound.ExecuteReader();


                    while (jobRead.Read())
                    {
                        string jobFind = (string)jobRead["job_number"];
                        tempCombo = jobFind;

                        string poFind = (string)jobRead["po_number"];
                        tempCombo += "|" + poFind;
                        cmboPO.Items.Add(tempCombo);
                        cmboOrderComp.Items.Add(poFind);

                        string byFind = (string)jobRead["requested_by"];

                        int quantityFind = (int)jobRead["quantity"];

                        string descriptionFind = (string)jobRead["description"];

                        string vendorFind = (string)jobRead["vendor"];

                        DateTime orderedFind = (DateTime)jobRead["date_ordered"];
                        string orderedComp = orderedFind.ToString("MM/dd/yyyy");

                        DateTime etaFind = (DateTime)jobRead["eta"];
                        string etaComp = etaFind.ToString("MM/dd/yyyy");

                        DateTime receivedFind = (DateTime)jobRead["date_received"];
                        string receivedComp = receivedFind.ToString("MM/dd/yyyy");
                        if (receivedFind.Year < 2000)
                        {
                            receivedComp = " ";
                        }

                        //CREATES ROW FOR EACH ITEM OF WORK FOR THE PASSED USER AND ADDS IT TO ARRAY OF ROWS
                        string[] row = { jobFind, poFind, byFind, quantityFind.ToString(), descriptionFind, vendorFind, orderedComp, etaComp, receivedComp };
                        orderList[orderRowCount] = row;

                        //CREATE LISTVIEW ITEM FOR ROW GENERATED AND ADD IT TO ORDER LISTVIEW
                        ListViewItem tempOrder = new ListViewItem(orderList[orderRowCount]);
                        lvOrder.Items.Add(tempOrder);

                        //INCREMENT COUNTER FOR BOTH TEMPORARY AND OVERALL LISTVIEWROWS
                        orderRowCount++;
                        tempCountOrder++;
                    }
                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("GetParts failed");
            }
        }

        //GET EXISTING LIST OF PARTS TO ORDER FROM HOME BASED ON CMBOJOB
        public void GetPartsPerJob()
        {
            string tempCombo;
            tempCountOrder = 0;
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
                    jobFound.CommandText = "select * from parts_to_order where job_number = '" + cmboJob.Text + "' order by po_number;";
                    jobFound.CommandType = CommandType.Text;

                    SqlDataReader jobRead = jobFound.ExecuteReader();


                    while (jobRead.Read())
                    {

                        string jobFind = (string)jobRead["job_number"];
                        tempCombo = jobFind;

                        string poFind = (string)jobRead["po_number"];
                        tempCombo += "|" + poFind;
                        cmboPO.Items.Add(tempCombo);
                        cmboOrderComp.Items.Add(poFind);

                        string byFind = (string)jobRead["requested_by"];

                        int quantityFind = (int)jobRead["quantity"];

                        string descriptionFind = (string)jobRead["description"];

                        string vendorFind = (string)jobRead["vendor"];

                        DateTime orderedFind = (DateTime)jobRead["date_ordered"];
                        string orderedComp = orderedFind.ToString("MM/dd/yyyy");

                        DateTime etaFind = (DateTime)jobRead["eta"];
                        string etaComp = etaFind.ToString("MM/dd/yyyy");

                        DateTime receivedFind = (DateTime)jobRead["date_received"];
                        string receivedComp = receivedFind.ToString("MM/dd/yyyy");
                        if(receivedFind.Year < 2000)
                        {
                            receivedComp = " ";
                        }

                        //CREATES ROW FOR EACH ITEM OF WORK FOR THE PASSED USER AND ADDS IT TO ARRAY OF ROWS
                        string[] row = { jobFind, poFind, byFind, quantityFind.ToString(), descriptionFind, vendorFind, orderedComp, etaComp, receivedComp };
                        orderList[orderRowCount] = row;

                        //CREATE LISTVIEW ITEM FOR ROW GENERATED AND ADD IT TO ORDER LISTVIEW
                        ListViewItem tempOrder = new ListViewItem(orderList[orderRowCount]);
                        lvOrder.Items.Add(tempOrder);

                        //INCREMENT COUNTER FOR BOTH TEMPORARY AND OVERALL LISTVIEWROWS
                        tempCountOrder++;
                        orderRowCount++;
                    }
                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("GetPartsPerJob failed");
            }
        }

        /// 
        /// FUNCTIONS FOR GETTING LIST OF OUTSIDE SERVICES
        /// 
        //GET EXISTING LIST OF OUTSIDE SERVICES FROM JOBVIEW
        public void GetService()
        {
            string tempCombo;
            tempCountService = 0;
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
                    jobFound.CommandText = "select * from outside_services where job_number = '" + theJob + " order by po_number;";
                    jobFound.CommandType = CommandType.Text;

                    SqlDataReader jobRead = jobFound.ExecuteReader();


                    while (jobRead.Read())
                    {

                        string jobFind = (string)jobRead["job_number"];
                        tempCombo = jobFind;

                        string poFind = (string)jobRead["po_number"];
                        tempCombo += "|" + poFind;
                        cmboService.Items.Add(tempCombo);
                        cmboServComplete.Items.Add(poFind);

                        string byFind = (string)jobRead["requested_by"];

                        int quantityFind = (int)jobRead["quantity"];

                        string partFind = (string)jobRead["part"];

                        string serviceFind = (string)jobRead["service"];

                        string descriptionFind = (string)jobRead["description"];

                        string vendorFind = (string)jobRead["vendor"];

                        DateTime orderedFind = (DateTime)jobRead["date_ordered"];
                        string orderedComp = orderedFind.ToString("MM/dd/yyyy");

                        DateTime etaFind = (DateTime)jobRead["eta"];
                        string etaComp = etaFind.ToString("MM/dd/yyyy");

                        DateTime receivedFind = (DateTime)jobRead["date_received"];
                        string receivedComp = receivedFind.ToString("MM/dd/yyyy");
                        if (receivedFind.Year < 2000)
                        {
                            receivedComp = " ";
                        }

                        //CREATES ROW FOR EACH ITEM OF WORK FOR THE PASSED USER AND ADDS IT TO ARRAY OF ROWS
                        string[] row = { jobFind, poFind, byFind, quantityFind.ToString(), partFind, serviceFind, descriptionFind, vendorFind, orderedComp, etaComp, receivedComp };
                        serviceList[serviceRowCount] = row;

                        //CREATE LISTVIEW ITEM FOR CREATED ROW AND ADD IT TO OUTSIDESERVICES LISTVIEW
                        ListViewItem tempService = new ListViewItem(serviceList[serviceRowCount]);
                        lvOutsideServices.Items.Add(tempService);

                        //INCREMENT COUNTER FOR BOTH TEMPORARY AND OVERALL LISTVIEWROWS
                        serviceRowCount++;
                        tempCountService++;
                    }
                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("GetService failed");
            }
        }

        //GET EXISTING LIST OF OUTSIDE SERVICES FROM DB BASED ON CMBOJOB
        public void GetServicePerJob()
        {
            string tempCombo;
            tempCountService = 0;
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
                    jobFound.CommandText = "select * from outside_services where job_number = '" + cmboJob.Text + "' order by po_number;";
                    jobFound.CommandType = CommandType.Text;

                    SqlDataReader jobRead = jobFound.ExecuteReader();


                    while (jobRead.Read())
                    {
                        string jobFind = (string)jobRead["job_number"];
                        tempCombo = jobFind;

                        string poFind = (string)jobRead["po_number"];
                        tempCombo += "|" + poFind;
                        cmboService.Items.Add(tempCombo);
                        cmboServComplete.Items.Add(poFind);

                        string byFind = (string)jobRead["requested_by"];

                        int quantityFind = (int)jobRead["quantity"];

                        string partFind = (string)jobRead["part"];

                        string serviceFind = (string)jobRead["service"];

                        string descriptionFind = (string)jobRead["description"];

                        string vendorFind = (string)jobRead["vendor"];

                        DateTime orderedFind = (DateTime)jobRead["date_ordered"];
                        string orderedComp = orderedFind.ToString("MM/dd/yyyy");

                        DateTime etaFind = (DateTime)jobRead["eta"];
                        string etaComp = etaFind.ToString("MM/dd/yyyy");

                        DateTime receivedFind = (DateTime)jobRead["date_received"];
                        string receivedComp = receivedFind.ToString("MM/dd/yyyy");
                        if (receivedFind.Year < 2000)
                        {
                            receivedComp = " ";
                        }

                        //CREATES ROW FOR EACH ITEM OF WORK FOR THE PASSED USER AND ADDS IT TO ARRAY OF ROWS
                        string[] row = { jobFind, poFind, byFind, quantityFind.ToString(), partFind, serviceFind, vendorFind, orderedComp, etaComp, receivedComp };
                        serviceList[serviceRowCount] = row;
                        ListViewItem tempService = new ListViewItem(serviceList[serviceRowCount]);
                        lvOutsideServices.Items.Add(tempService);

                        //INCREMENT COUNTER FOR BOTH TEMPORARY AND OVERALL LISTVIEWROWS
                        serviceRowCount++;
                        tempCountService++;
                    }
                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("GetServicePerJob failed");
            }
        }

        /// 
        /// EVENT HANDLERS FOR BUTTON CLICKS AND JOB SELECTS
        ///      
        //EVENT HANDLER FOR OPENING PARTORDER FORM
        private void pbAddOrder_Click(object sender, EventArgs e)
        {
            if(cmboJob.Enabled == true)
            {
                PartOrder theOrder = new PartOrder();
                theOrder.ShowDialog();
            }
            if(cmboJob.Enabled == false)
            {
                PartOrder theOrder = new PartOrder(theJob);
                theOrder.ShowDialog();
            }
        }

        //OPENS OUTSIDE SERVICE ORDER FORM 
        private void pbAddService_Click(object sender, EventArgs e)
        {
            if(cmboJob.Enabled == true)
            {
                ServiceOrder theService = new ServiceOrder();
                theService.ShowDialog();
            }
            if(cmboJob.Enabled == false)
            {
                ServiceOrder theService = new ServiceOrder(theJob);
                theService.ShowDialog();
            }
        }

        //EVENT HANDLER TO GET ORDERED PARTS FOR A SPECIFIED JOB
        private void cmboJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetPartsPerJob();           

            GetServicePerJob();
        }

        //EVENT HANDLER FOR EDITING AN EXISTING ORDER 
        private void cmboPO_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] tempSplit = cmboService.Text.Split('|');
            PartOrder editOrder = new PartOrder(tempSplit[0], tempSplit[1]);
            editOrder.ShowDialog();
        }

        //EVENT HANDLER FOR EDITING AN EXISTING OUTSIDE SERVICE
        private void cmboService_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] tempSplit = cmboService.Text.Split('|');
            ServiceOrder theServiceEdit = new ServiceOrder(tempSplit[0], tempSplit[1]);
            theServiceEdit.ShowDialog();
        }

        //EVENT HANDLER FOR MARKING A SERVICE COMPLETE
        private void cmboServComplete_SelectedIndexChanged(object sender, EventArgs e)
        {
            //PASS 1 AS ARGUMENT TO CHANGED SERVANDORDERCOMP FORM TO UPDATE OUTSIDE_SERVICES TABLE
            ServAndOrderComp theOption = new ServAndOrderComp(1, cmboServComplete.Text);
            theOption.ShowDialog();
        }

        //EVENT HANDLER FOR MARKING A ORDER COMPLETE
        private void cmboOrderComp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] tempSplit = cmboService.Text.Split('|');
            ServAndOrderComp theOrder = new ServAndOrderComp(0, cmboOrderComp.Text);
            theOrder.ShowDialog();    
        }

        //CLEARS LIST VIEW AND JOB LIST COMBO BOX
        private void btnLineClear_Click(object sender, EventArgs e)
        {
            //CLEAR PARTS_TO_ORDER ELEMENTS
            Array.Clear(orderList, 0, orderList.Length);           

            lvOrder.Items.Clear();
            cmboPO.Items.Clear();
            cmboPO.Text = " ";
            orderRowCount = 0;

            cmboOrderComp.Items.Clear();
            cmboOrderComp.Text = " ";

            //CLEAR OUTSIDE SERVICE ELEMENTS
            Array.Clear(serviceList, 0, serviceList.Length);

            lvOutsideServices.Items.Clear();
            cmboService.Items.Clear();            
            cmboService.Text = " ";
            serviceRowCount = 0;
            tempCountService = 0;

            cmboServComplete.Items.Clear();
            cmboServComplete.Text = " ";

            cmboJob.SelectedIndex = -1;
        }

        //EXIT FORM
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// 
        /// FOR BUTTON DESIGN
        /// 
        //ADD ORDER BUTTON
        private void pbAddOrder_MouseEnter(object sender, EventArgs e)
        {
            int width = pbAddOrder.Size.Width;
            int height = pbAddOrder.Size.Height;
            int larger = 5;
            pbAddOrder.Size = new Size(width + larger, height + larger);
        }

        private void pbAddOrder_MouseLeave(object sender, EventArgs e)
        {
            int width = pbAddOrder.Size.Width;
            int height = pbAddOrder.Size.Height;
            int smaller = 5;
            pbAddOrder.Size = new Size(width - smaller, height - smaller);
        }

        //ADD SERVICE BUTTON
        private void pbAddService_MouseEnter(object sender, EventArgs e)
        {
            int width = pbAddService.Size.Width;
            int height = pbAddService.Size.Height;
            int larger = 5;
            pbAddService.Size = new Size(width + larger, height + larger);
        }

        private void pbAddService_MouseLeave(object sender, EventArgs e)
        {
            int width = pbAddService.Size.Width;
            int height = pbAddService.Size.Height;
            int smaller = 5;
            pbAddService.Size = new Size(width - smaller, height - smaller);
        }

    }
}
