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
    public partial class HomeNonAdmin : Form
    {
        JobItem[] JobList = new JobItem[UserProfile.JobAmount];
        Button[] JobButton = new Button[UserProfile.JobAmount];
        Label[] CustomerLabel = new Label[UserProfile.JobAmount];
        Label[] DueDateLabel = new Label[UserProfile.JobAmount];
        Label[] StatusLabel = new Label[UserProfile.JobAmount];

        public HomeNonAdmin()
        {
            InitializeComponent();

            lblWelcome.Text += UserProfile.First;

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
            Button button = new Button();
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
                    label.Location = new Point(55, 454);
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

            //PUTS LABEL IN LOCATION ACCORDING TO PRIORITY NUMBER
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

        //REFRESH FUNCTION FOR BUTTON CLICK AND UPDATES
        private void RefreshForm()
        {
            flpJobNum.Controls.Clear();
            gbCustomer.Controls.Clear();
            gbDueDate.Controls.Clear();
            gbStatus.Controls.Clear();

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
        ///BUTTON CLICK EVENT HANDLERS
        ///
        ///
        ///
        //BUTTON CLICK EVENT CALLING THE SINGLE ARGUMENT CONSTRUCTOR OF JOBVIEW
        private void btnJob_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            JobViewNonAdmin theJob = new JobViewNonAdmin(btn.Text);
            theJob.ShowDialog();
        }

        //REFRESH CLICK
        private void picRefresh_Click(object sender, EventArgs e)
        {
            picRefresh.Visible = false;
            picRefresh.Visible = true;

            RefreshForm();
        }

        //TODAYS WORK CLICK 
        private void pbTodaysWork_Click(object sender, EventArgs e)
        {
            WorkViewer theViewer = new WorkViewer();
            theViewer.ShowDialog();
        }

        //JOB CARDS CLICK
        private void pbJobCards_Click(object sender, EventArgs e)
        {
            JobCardEditor theEditor = new JobCardEditor();
            theEditor.ShowDialog();
        }

        //SERVICES AND ORDERING CLICK
        private void pbSandO_Click(object sender, EventArgs e)
        {
            ServicesAndOrdering theSandO = new ServicesAndOrdering();
            theSandO.ShowDialog();
        }

        //EXIT
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// 
        /// BUTTON DESIGN
        /// 
        ///
        /// 
        //REFRESH
        private void picRefresh_MouseEnter(object sender, EventArgs e)
        {
            int width = picRefresh.Size.Width;
            int height = picRefresh.Size.Height;
            int larger = 10;
            picRefresh.Size = new Size(width + larger, height + larger);
        }

        private void picRefresh_MouseLeave(object sender, EventArgs e)
        {
            int width = picRefresh.Size.Width;
            int height = picRefresh.Size.Height;
            int smaller = 10;
            picRefresh.Size = new Size(width - smaller, height - smaller);
        }

        //TODAYS WORK
        private void pbTodaysWork_MouseEnter(object sender, EventArgs e)
        {
            int width = pbTodaysWork.Size.Width;
            int height = pbTodaysWork.Size.Height;
            int larger = 10;
            pbTodaysWork.Size = new Size(width + larger, height + larger);
        }

        private void pbTodaysWork_MouseLeave(object sender, EventArgs e)
        {
            int width = pbTodaysWork.Size.Width;
            int height = pbTodaysWork.Size.Height;
            int smaller = 10;
            pbTodaysWork.Size = new Size(width - smaller, height - smaller);
        }

        //JOB CARDS
        private void pbJobCards_MouseEnter(object sender, EventArgs e)
        {
            int width = pbJobCards.Size.Width;
            int height = pbJobCards.Size.Height;
            int larger = 10;
            pbJobCards.Size = new Size(width + larger, height + larger);
        }

        private void pbJobCards_MouseLeave(object sender, EventArgs e)
        {
            int width = pbJobCards.Size.Width;
            int height = pbJobCards.Size.Height;
            int smaller = 10;
            pbJobCards.Size = new Size(width - smaller, height - smaller);
        }

        //OUTSIDE WORK
        private void pbOutsideWork_MouseEnter(object sender, EventArgs e)
        {
            int width = pbSandO.Size.Width;
            int height = pbSandO.Size.Height;
            int larger = 10;
            pbSandO.Size = new Size(width + larger, height + larger);
        }

        private void pbOutsideWork_MouseLeave(object sender, EventArgs e)
        {
            int width = pbSandO.Size.Width;
            int height = pbSandO.Size.Height;
            int smaller = 10;
            pbSandO.Size = new Size(width - smaller, height - smaller);
        }

    }
}
