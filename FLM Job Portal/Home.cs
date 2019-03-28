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
    public partial class Home : Form
    {
        JobItem[] JobList = new JobItem[UserProfile.JobAmount];
        Button[] JobButton = new Button[UserProfile.JobAmount];
        Label[] CustomerLabel = new Label[UserProfile.JobAmount];
        Label[] DueDateLabel = new Label[UserProfile.JobAmount];
        Label[] StatusLabel = new Label[UserProfile.JobAmount];

        //DEFAULT CONSTRUCTOR
        public Home()
        {
            InitializeComponent();

            lblWelcome.Text += UserProfile.First;

            GetJobList();

            //GENERATES LIST OF JOBS 
            for (int i = 0; i < UserProfile.JobAmount; i++)
            {
                JobList[i] = new JobItem();
                DBPopulateJobList(JobList[i], i + 1);
                JobButtonGen(JobList[i], i+1);
                JobCustomerLabelGen(JobList[i], i+1);
                JobDueLabelGen(JobList[i], i+1);
                JobStatusLabelGen(JobList[i], i+1);
            }

        }

        /// 
        ///FUNCTIONS TO POPULATE THE LIST OF JOBS 
        /// 
        ///
        ///
        //GETS JOBS FROM DB AND PUTS THEM INTO AN ARRAY
        private void DBPopulateJobList(JobItem theJob, int i)
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
     
                    SqlCommand jobFind = new SqlCommand();

                    jobFind.Connection = connection;
                    jobFind.CommandText = "select * from job_list where priority_number = '" + i + "';";
                    jobFind.CommandType = CommandType.Text;

                    SqlDataReader jobRead = jobFind.ExecuteReader();

                    //Assign User info from DB to UserProfile object
                    while (jobRead.Read())
                    {
                        string jobNumFound = (string)jobRead["job_number"];
                        string jobNumComp = string.Format(jobNumFound);
                        theJob.Number = jobNumComp;

                        string jobCustFound = (string)jobRead["customer"];
                        string jobCustComp = string.Format("{0}", jobCustFound);
                        theJob.Customer = jobCustComp;

                        string jobDueFound = (string)jobRead["due_date"];
                        string jobDueComp = string.Format("{0}", jobDueFound);
                        theJob.Due = jobDueComp;

                        string statusFound = (string)jobRead["job_status"];
                        theJob.Status = statusFound;                      
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("DBPopulateList Failed");
            }

        }

        //GENERATES BUTTONS FOR EACH JOB NUMBER
        private void JobButtonGen(JobItem theJob, int i)
        {
            Button button  = new Button();
            button.Name = "btnJob" + theJob.Number;
            button.Text = theJob.Number;
            button.Font = new Font("Microsoft YaHei UI", 14, FontStyle.Bold);
            button.AutoSize = true;
            button.Width = 185;
            button.Height = 73;
            button.BackColor = Color.SteelBlue;
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Popup;
            button.Click += new EventHandler(this.btnJob_Click);
            flpJobNum.Controls.Add(button);
            JobButton[i - 1] = new Button();
        }

        //GENERATES LABELS FOR EACH CUSTOMER ASSOCIATED WITH THE JOB
        private void JobCustomerLabelGen(JobItem theJob, int i)
        {
            Label label = new Label();
            label.Text = theJob.Customer;
            label.Font = new Font("Microsoft YaHei UI", 14, FontStyle.Bold);
            label.ForeColor = Color.Black;
            label.AutoSize = true;
            gbCustomer.Controls.Add(label);
            CustomerLabel[i - 1] = new Label();

            //PUTS LABEL IN LOCATION ACCORDING TO PRIORITY NUMBER
            switch (i)
            {
                case 1:
                    label.Location = new Point(55, 59);
                    break;
                case 2:
                    label.Location = new Point(55, 138);
                    break;
                case 3:
                    label.Location = new Point(55, 217);
                    break;
                case 4:
                    label.Location = new Point(55, 296);
                    break;
                case 5:
                    label.Location = new Point(55, 375);
                    break;
                case 6:
                    label.Location = new Point(55,454);
                    break;
                case 7:
                    label.Location = new Point(55, 533);
                    break;
                case 8:
                    label.Location = new Point(55, 612);
                    break;
                case 9:
                    label.Location = new Point(55, 691);
                    break;
                case 10:
                    label.Location = new Point(55, 770);
                    break;
                case 11:
                    label.Location = new Point(55, 849);
                    break;
                case 12:
                    label.Location = new Point(55, 928);
                    break;
                case 13:
                    label.Location = new Point(55, 1007);
                    break;
                case 14:
                    label.Location = new Point(55, 1086);
                    break;
                case 15:
                    label.Location = new Point(55, 1165);
                    break;
                case 16:
                    label.Location = new Point(55, 1244);
                    break;
                case 17:
                    label.Location = new Point(55, 1323);
                    break;
                case 18:
                    label.Location = new Point(55, 1402);
                    break;
                case 19:
                    label.Location = new Point(55, 1481);
                    break;
                case 20:
                    label.Location = new Point(55, 1560);
                    break;
            }
        }

        //GENERATES LABELS FOR EACH DUE DATE ASSOCIATED WITH THE JOB
        private void JobDueLabelGen(JobItem theJob, int i)
        {
            Label label = new Label();
            label.Text = theJob.Due;
            label.Font = new Font("Microsoft YaHei UI", 14, FontStyle.Bold);
            label.ForeColor = Color.Black;
            label.AutoSize = true;
            gbDueDate.Controls.Add(label);
            DueDateLabel[i - 1] = new Label();

            //PUTS LABEL IN LOCATION ACCORDING TO PRIORITY NUMBER
            switch (i)
            {
                case 1:
                    label.Location = new Point(42, 59);
                    break;
                case 2:
                    label.Location = new Point(42, 138);
                    break;
                case 3:
                    label.Location = new Point(42, 217);
                    break;
                case 4:
                    label.Location = new Point(42, 296);
                    break;
                case 5:
                    label.Location = new Point(42, 375);
                    break;
                case 6:
                    label.Location = new Point(42, 454);
                    break;
                case 7:
                    label.Location = new Point(42, 533);
                    break;
                case 8:
                    label.Location = new Point(42, 612);
                    break;
                case 9:
                    label.Location = new Point(42, 691);
                    break;
                case 10:
                    label.Location = new Point(42, 770);
                    break;
                case 11:
                    label.Location = new Point(42, 849);
                    break;
                case 12:
                    label.Location = new Point(42, 928);
                    break;
                case 13:
                    label.Location = new Point(42, 1007);
                    break;
                case 14:
                    label.Location = new Point(42, 1086);
                    break;
                case 15:
                    label.Location = new Point(42, 1165);
                    break;
                case 16:
                    label.Location = new Point(42, 1244);
                    break;
                case 17:
                    label.Location = new Point(42, 1323);
                    break;
                case 18:
                    label.Location = new Point(42, 1402);
                    break;
                case 19:
                    label.Location = new Point(42, 1481);
                    break;
                case 20:
                    label.Location = new Point(42, 1560);
                    break;
            }
        }

        //GENERATES LABELS FOR EACH STATUS ASSOCIATED WITH THE JOB
        private void JobStatusLabelGen(JobItem theJob, int i)
        {
            Label label = new Label();
            label.Text = theJob.Status;
            label.Font = new Font("Microsoft YaHei UI", 14, FontStyle.Bold);
            StatusLabel[i - 1] = new Label();

            //CHANGES COLOR OF TEXT ACCORDING TO JOB STATUS
            if (theJob.Status == "IN PROGRESS")
            {
                label.ForeColor = Color.ForestGreen;
            }
            else if (theJob.Status == "OUTSIDE SERVICE")
            {
                label.ForeColor = Color.Gold;
            }
            else if (theJob.Status == "ON HOLD")
            {
                label.ForeColor = Color.Chocolate;
            }
            else if (theJob.Status == "IN DESIGN")
            {
                label.ForeColor = Color.MediumTurquoise;
            }
            else if (theJob.Status == "RFQ")
            {
                label.ForeColor = Color.White;
            }

            label.AutoSize = true;
            gbStatus.Controls.Add(label);
            switch (i)
            {
                case 1:
                    label.Location = new Point(24, 59);
                    break;
                case 2:
                    label.Location = new Point(24, 138);
                    break;
                case 3:
                    label.Location = new Point(24, 217);
                    break;
                case 4:
                    label.Location = new Point(24, 296);
                    break;
                case 5:
                    label.Location = new Point(24, 375);
                    break;
                case 6:
                    label.Location = new Point(24, 454);
                    break;
                case 7:
                    label.Location = new Point(24, 533);
                    break;
                case 8:
                    label.Location = new Point(24, 612);
                    break;
                case 9:
                    label.Location = new Point(24, 691);
                    break;
                case 10:
                    label.Location = new Point(24, 770);
                    break;
                case 11:
                    label.Location = new Point(24, 849);
                    break;
                case 12:
                    label.Location = new Point(24, 928);
                    break;
                case 13:
                    label.Location = new Point(24, 1007);
                    break;
                case 14:
                    label.Location = new Point(24, 1086);
                    break;
                case 15:
                    label.Location = new Point(24, 1165);
                    break;
                case 16:
                    label.Location = new Point(24, 1244);
                    break;
                case 17:
                    label.Location = new Point(24, 1323);
                    break;
                case 18:
                    label.Location = new Point(24, 1402);
                    break;
                case 19:
                    label.Location = new Point(24, 1481);
                    break;
                case 20:
                    label.Location = new Point(24, 1560);
                    break;
            }
        }

        //GET INFORMATION OF USER FROM DB AFTER LOGIN CHECK IS DONE
        public void GetJobAmount()
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
                    
                    SqlCommand commandComp = new SqlCommand();

                    commandComp.Connection = connection;
                    commandComp.CommandText = "select job_amount from user_profile where user_id = '" + UserProfile.ID + "';";
                    commandComp.CommandType = CommandType.Text;

                    SqlDataReader readerComp = commandComp.ExecuteReader();

                    while (readerComp.Read())
                    {
                        int amountFound = (int)readerComp["job_amount"];
                        UserProfile.JobAmount = amountFound;

                    }
                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("GetJobAmount Failed");
            }
        }

        //GET JOB LIST FOR UP/DOWN PRIORITY
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
                    jobFound.CommandText = "select job_number from job_list order by priority_number;";
                    jobFound.CommandType = CommandType.Text;

                    SqlDataReader jobRead = jobFound.ExecuteReader();


                    while (jobRead.Read())
                    {
                        string jobFind = (string)jobRead["job_number"];
                        cmboEditor.Items.Add(jobFind);
                        cmboPriority.Items.Add(jobFind);
                    }
                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("GetJobList failed");
            }
        }

        //REFRESH FUNCTION FOR BUTTON CLICK AND UPDATES
        private void RefreshForm()
        {
            flpJobNum.Controls.Clear();
            gbCustomer.Controls.Clear();
            gbDueDate.Controls.Clear();
            gbStatus.Controls.Clear();

            cmboEditor.Items.Clear();
            cmboPriority.Items.Clear();

            GetJobAmount();
            GetJobList();

            //GENERATES LIST OF JOBS 
            for (int i = 0; i < UserProfile.JobAmount; i++)
            {
                JobList[i] = new JobItem();
                DBPopulateJobList(JobList[i], i + 1);
                JobButtonGen(JobList[i], i + 1);
                JobCustomerLabelGen(JobList[i], i + 1);
                JobDueLabelGen(JobList[i], i + 1);
                JobStatusLabelGen(JobList[i], i + 1);
            }
        }

        ///
        /// FOR PUSHING JOB DOWN IN PRIORITY
        ///
        /// 
        /// 
        //SETS TEMPORARY PRIORITY NUMBER FOR JOB BEING PUSHED DOWN
        private void DownJobTemp(ComboBox theJob)
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

                    SqlCommand jobUp = new SqlCommand();

                    jobUp.Connection = connection;
                    jobUp.CommandText = "update job_list set priority_number = 21 where priority_number = " + (theJob.SelectedIndex + 1) + ";";

                    jobUp.CommandType = CommandType.Text;

                    jobUp.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("DownJobTemp Fail");
            }
        }

        //MOVES PRIORITY THAT WAS 1 LOWER THAN SELECTED TO THE SELECTED JOBS ORIGINAL POSITION
        private void DownJob(ComboBox theJob)
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

                    SqlCommand jobUp = new SqlCommand();

                    jobUp.Connection = connection;
                    jobUp.CommandText = "update job_list set priority_number = priority_number - 1 where priority_number = " + (theJob.SelectedIndex + 2) + ";";

                    jobUp.CommandType = CommandType.Text;

                    jobUp.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Down Job Fail");
            }
        }

        //MOVES THE ORIGINAL SELECTED JOB FROM THE TEMPORARY POSITION TO THE LOWERED PRIORITY
        private void DownJobTempFix(ComboBox theJob)
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

                    SqlCommand jobUp = new SqlCommand();

                    jobUp.Connection = connection;
                    jobUp.CommandText = "update job_list set priority_number = " + (theJob.SelectedIndex + 2) + " where priority_number = 21;";

                    jobUp.CommandType = CommandType.Text;

                    jobUp.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Down Job Temp Fix Fail");
            }
        }

        /// 
        /// FOR PUSHING JOB UP IN PRIORITY
        /// 
        /// 
        /// 
        //SETS TEMPORARY PRIORITY NUMBER FOR JOB BEING PUSHED UP
        private void UpJobTemp(ComboBox theJob)
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

                    SqlCommand jobUp = new SqlCommand();

                    jobUp.Connection = connection;
                    jobUp.CommandText = "update job_list set priority_number = 21 where priority_number = " + theJob.SelectedIndex + ";";

                    jobUp.CommandType = CommandType.Text;

                    jobUp.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Job Up Temp Fail");
            }
        }

        //MOVES PRIORITY THAT WAS 1 HIGHER THAN SELECTED TO THE SELECTED JOBS ORIGINAL POSITION
        private void UpJob(ComboBox theJob)
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

                    SqlCommand jobUp = new SqlCommand();

                    jobUp.Connection = connection;
                    jobUp.CommandText = "update job_list set priority_number = priority_number -1 where priority_number = " + (theJob.SelectedIndex + 1) + ";";

                    jobUp.CommandType = CommandType.Text;

                    jobUp.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Job Up Fail");
            }
        }

        //MOVES THE ORIGINAL SELECTED JOB FROM THE TEMPORARY POSITION TO THE RAISED PRIORITY
        private void UpJobTempFix(ComboBox theJob)
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

                    SqlCommand jobUp = new SqlCommand();

                    jobUp.Connection = connection;
                    jobUp.CommandText = "update job_list set priority_number = " + (theJob.SelectedIndex + 1) + " where priority_number = 21;";

                    jobUp.CommandType = CommandType.Text;

                    jobUp.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Job Up Temp Fix Fail");
            }
        }

        ///
        /// BUTTON CLICK EVENT HANDLERS
        ///
        ///
        ///
        //BUTTON CLICK EVENT CALLING THE SINGLE ARGUMENT CONSTRUCTOR OF JOBVIEW
        private void btnJob_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            JobView theJob = new JobView(btn.Text);
            theJob.ShowDialog();
        }

        //REFRESH CLICK
        private void picRefresh_Click(object sender, EventArgs e)
        {
            picRefresh.Visible = false;
            picRefresh.Visible = true;

            RefreshForm();

        }

        //OPENS JOBADD FORM
        private void picAddJob_Click(object sender, EventArgs e)
        {
            picAddJob.Visible = false;
            picAddJob.Visible = true;

            JobAdd adder = new JobAdd();
            adder.ShowDialog();

            GetJobAmount();
            RefreshForm();
        }

        //OPENS JOBDELETE FORM
        private void picDeleteJob_Click(object sender, EventArgs e)
        {
            picDeleteJob.Visible = false;
            picDeleteJob.Visible = true;

            JobDelete deleter = new JobDelete();
            deleter.ShowDialog();

            GetJobAmount();
            RefreshForm();
        }

        //TAKES COMBO BOX SELECTION AND OPENS JOBEDITOR
        private void btnDetailEdit_Click(object sender, EventArgs e)
        {
            if (cmboEditor.SelectedIndex > -1)
            {
                JobEditor theEditor = new JobEditor(cmboEditor.SelectedItem.ToString());
                theEditor.ShowDialog();

                cmboEditor.Text = "";
                RefreshForm();
            }
            else
            {
                MessageBox.Show("SELECT A JOB TO EDIT DETAILS");
            }

        }

        //MOVES THE SELECTED JOB DOWN 1 IN PRIORITY
        private void btnDown_Click(object sender, EventArgs e)
        {
            if(cmboPriority.SelectedIndex >= 0)
            {
                DownJobTemp(cmboPriority);
                DownJob(cmboPriority);
                DownJobTempFix(cmboPriority);
                cmboPriority.Text = "";
                RefreshForm();
            }
            else
            {
                MessageBox.Show("SELECT A JOB TO ADJUST PRIORITY");
            }
        }

        //MOVES THE SELECTED JOB UP 1 IN PRIORITY
        private void btnUp_Click(object sender, EventArgs e)
        {
            if(cmboPriority.SelectedIndex >= 0)
            {
                UpJobTemp(cmboPriority);
                UpJob(cmboPriority);
                UpJobTempFix(cmboPriority);
                cmboPriority.Text = "";
                RefreshForm();
            }
            else
            {
                MessageBox.Show("SELECT A JOB TO ADJUST PRIORITY");
            }

        }

        //OPENS THE SEND TO RECORDS FORM
        private void pbSendRecords_Click(object sender, EventArgs e)
        {
            pbSendRecords.Visible = false;
            pbSendRecords.Visible = true;

            SendToRecords theSender = new SendToRecords();
            theSender.ShowDialog();
            RefreshForm();
        }

        //OPENS JOBSTATUSUPDATE
        private void pbStatusUpdate_Click(object sender, EventArgs e)
        {
            pbStatusUpdate.Visible = false;
            pbStatusUpdate.Visible = true;

            JobStatusUpdate theUpdate = new JobStatusUpdate();
            theUpdate.ShowDialog();
            RefreshForm();
        }

        //EXIT PROGRAM
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        ///
        ///FOR BUTTON DESIGN
        ///
        ///
        ///
        //REFRESH ENTER
        private void picRefresh_MouseEnter(object sender, EventArgs e)
        {
            int width = picRefresh.Size.Width;
            int height = picRefresh.Size.Height;
            int larger = 10;
            picRefresh.Size = new Size(width + larger, height + larger);
        }

        //REFRESH LEAVE
        private void picRefresh_MouseLeave(object sender, EventArgs e)
        {
            int width = picRefresh.Size.Width;
            int height = picRefresh.Size.Height;
            int smaller = 10;
            picRefresh.Size = new Size(width - smaller, height - smaller);
        }

        //ADD JOB ENTER
        private void picAddJob_MouseEnter(object sender, EventArgs e)
        {
            int width = picAddJob.Size.Width;
            int height = picAddJob.Size.Height;
            int larger = 10;
            picAddJob.Size = new Size(width + larger, height + larger);
        }

        //ADD JOB LEAVE
        private void picAddJob_MouseLeave(object sender, EventArgs e)
        {
            int width = picAddJob.Size.Width;
            int height = picAddJob.Size.Height;
            int smaller = 10;
            picAddJob.Size = new Size(width - smaller, height - smaller);
        }

        //DELETE JOB ENTER
        private void picDeleteJob_MouseEnter(object sender, EventArgs e)
        {
            int width = picDeleteJob.Size.Width;
            int height = picDeleteJob.Size.Height;
            int larger = 10;
            picDeleteJob.Size = new Size(width + larger, height + larger);
        }

        //DELETE JOB LEAVE
        private void picDeleteJob_MouseLeave(object sender, EventArgs e)
        {
            int width = picDeleteJob.Size.Width;
            int height = picDeleteJob.Size.Height;
            int smaller = 10;
            picDeleteJob.Size = new Size(width - smaller, height - smaller);
        }

        //SEND RECORDS ENTER
        private void pbSendRecords_MouseEnter(object sender, EventArgs e)
        {
            int width = pbSendRecords.Size.Width;
            int height = pbSendRecords.Size.Height;
            int larger = 5;
            pbSendRecords.Size = new Size(width + larger, height + larger);
        }

        //SEND RECORDS LEAVE
        private void pbSendRecords_MouseLeave(object sender, EventArgs e)
        {
            int width = pbSendRecords.Size.Width;
            int height = pbSendRecords.Size.Height;
            int smaller = 5;
            pbSendRecords.Size = new Size(width - smaller, height - smaller);
        }

        //STATUS UPDATE ENTER
        private void pbStatusUpdate_MouseEnter(object sender, EventArgs e)
        {
            int width = pbStatusUpdate.Size.Width;
            int height = pbStatusUpdate.Size.Height;
            int larger = 5;
            pbStatusUpdate.Size = new Size(width + larger, height + larger);
        }

        //STATUS UPDATE LEAVE
        private void pbStatusUpdate_MouseLeave(object sender, EventArgs e)
        {
            int width = pbStatusUpdate.Size.Width;
            int height = pbStatusUpdate.Size.Height;
            int smaller = 5;
            pbStatusUpdate.Size = new Size(width - smaller, height - smaller);
        }
    }
}
