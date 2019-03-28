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
    public partial class JobViewNonAdmin : Form
    {
        GroupBox[] theEmployeeGB = new GroupBox[10];
        ListView[] theEmployeeLV = new ListView[10];
        List<EmployeesOnJob> EmployeesOnJob = new List<EmployeesOnJob>();
        ListViewItem[] theWorkList = new ListViewItem[100];
        List<ListViewItem> theDayList = new List<ListViewItem>();
        List<int> EmployeeWorkingIDList = new List<int>();
        CalendarMonthJobView theMonth = new CalendarMonthJobView(Convert.ToInt32(DateTime.Now.ToString("MM")));
        string[][] WorkListRow = new string[100][];
        string[][] DayListRow = new string[100][];
        bool workDayCheck = false;
        int i, j;
        int addedWorkCount = 0;
        int passedWorkAmount;
        string theJob, weekDay;

        public JobViewNonAdmin()
        {
            InitializeComponent();
        }

        //CONSTRUCTOR FOR WHEN JOB VIEW IS OPENED BY JOB PRESS IN HOME FORM
        public JobViewNonAdmin(string passedJob)
        {
            InitializeComponent();
            lblJob.Text = "JOB # " + passedJob;

            /*
            ///
            ///FOR TIMER
            ///
            ///
            //timer interval
            theTimer.Interval = 1000;  //in milliseconds

            theTimer.Tick += new EventHandler(this.theTimer_Tick);

            //start timer when form loads
            theTimer.Start();  //this will use t_Tick() method
            */


            //VARIABLE FOR JOB# TO USE THROUGHOUT FORM
            theJob = passedJob;
            GetEmployeeIDList(theJob);

            //GENERATE EMPLOYEE WORK ON LEFT
            for (int j = 0; j < EmployeeWorkingIDList.Count; j++)
            {
                GetEmployeeList(theJob, EmployeeWorkingIDList[j]);
                CreateUserGB(j, EmployeesOnJob[j].ID, EmployeesOnJob[j].FirstName + " " + EmployeesOnJob[j].LastName);
            }

            //SET MONTH LABEL
            lblMonth.Text = theMonth.Month;

            //CREATE BLANK DAYS FOR PREVIOUS AND UPCOMING MONTHS
            for (int j = 0; j < theMonth.blankDays; j++)
            {
                AddBlankCalendarDays(j);
            }

            //GENERATE AMOUNT OF DAYS ON CALENDAR FLOWLAYOUTPANEL EQUAL TO THE 
            for (int j = 1; j <= theMonth.MonthDayAmount; j++)
            {
                AddCalendarDays(j, passedWorkAmount);
            }

        }

        //GET AMOUNT OF EMPLOYEES ON JOB
        private void GetEmployeeIDList(string passedJob)
        {
            i = 0;
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
                    ///GET JOB PROCESSES FROM DB SPECIFIC TO LISTED EMPLOYEE
                    //       
                    SqlCommand commandComp = new SqlCommand();

                    commandComp.Connection = connection;
                    commandComp.CommandText = "select id, work_amount from employee_jobs where job_number = '" + passedJob + "';";
                    commandComp.CommandType = CommandType.Text;

                    SqlDataReader readerComp = commandComp.ExecuteReader();

                    while (readerComp.Read())
                    {
                        int idFound = (int)readerComp["id"];
                        EmployeeWorkingIDList.Add(idFound);

                        passedWorkAmount = (int)readerComp["work_amount"];
                        EmployeesOnJob.Add(new EmployeesOnJob(idFound, passedWorkAmount));
                    }

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("GetEmployeeIDList Failed");
            }
        }

        //GETS EMPLOYEES CURRENTLY WORKING ON THE JOB
        private void GetEmployeeList(string passedJob, int theEmployee)
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
                    ///GET JOB PROCESSES FROM DB SPECIFIC TO LISTED EMPLOYEE
                    //       
                    SqlCommand commandComp = new SqlCommand();

                    commandComp.Connection = connection;
                    commandComp.CommandText = "select * from user_profile where user_id = '" + theEmployee + "';";
                    commandComp.CommandType = CommandType.Text;

                    SqlDataReader readerComp = commandComp.ExecuteReader();

                    while (readerComp.Read())
                    {
                        int iDComp = (int)readerComp["user_id"];

                        string firstFound = (string)readerComp["first_name"];
                        string firstComp = string.Format("{0}", firstFound);
                        EmployeesOnJob[i].FirstName = firstComp;

                        string lastFound = (string)readerComp["last_name"];
                        string lastComp = string.Format("{0}", lastFound);
                        EmployeesOnJob[i].LastName = lastComp;

                        string initialsFound = (string)readerComp["initials"];
                        string initialsComp = string.Format("{0}", initialsFound);
                        EmployeesOnJob[i].Initials = initialsComp;

                        i++;
                    }

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("GetEmployeeList Failed");
            }

        }

        //GETS LIST OF WORK FOR EACH EMPLOYEE
        private void GetEmployeeWork(string passedJob, int passedEmployee)
        {

            j = 0;
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
                    ///GET JOB PROCESSES FROM DB SPECIFIC TO LISTED EMPLOYEE
                    //       
                    SqlCommand commandComp = new SqlCommand();

                    commandComp.Connection = connection;
                    commandComp.CommandText = "select * from job_processes where job_number = '" + passedJob + "' and user_id = '" + passedEmployee + "';";
                    commandComp.CommandType = CommandType.Text;

                    SqlDataReader readerComp = commandComp.ExecuteReader();

                    while (readerComp.Read())
                    {
                        string itemFound = (string)readerComp["item"];
                        string itemComp = string.Format("{0}", itemFound);

                        string departmentFound = (string)readerComp["department"];
                        string departmentComp = string.Format("{0}", departmentFound);

                        string componentFound = (string)readerComp["component"];
                        string componentComp = string.Format("{0}", componentFound);

                        decimal allottedFound = (decimal)readerComp["hrs_allotted"];

                        decimal spentFound = (decimal)readerComp["hrs_spent"];

                        decimal leftFound = (decimal)readerComp["hrs_left"];

                        string dueFound = (string)readerComp["date_due"];
                        string dueComp = string.Format("{0}", dueFound);

                        int monthDueComp = (int)readerComp["month_due"];

                        int dayDueComp = (int)readerComp["day_due"];

                        string completeFound = (string)readerComp["date_complete"];
                        string completeComp = string.Format("{0}", completeFound);

                        int monthCompleteComp = (int)readerComp["month_complete"];

                        int dayCompleteComp = (int)readerComp["day_complete"];

                        string notesFound = (string)readerComp["notes"];
                        string notesComp = string.Format("{0}", notesFound);

                        //CREATES ROW FOR EACH ITEM OF WORK FOR THE PASSED USER AND ADDS IT TO ARRAY OF ROWS
                        string[] row = { itemComp, departmentComp, componentComp, allottedFound.ToString(), spentFound.ToString(), leftFound.ToString(), dueComp, completeComp, notesComp };
                        WorkListRow[j] = row;
                        theWorkList[j] = new ListViewItem(WorkListRow[j]);

                        j++;
                    }

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("GetEmployeeWork Failed");
            }
        }

        //GENERATES GROUP BOXES AND LIST PANELS FOR EACH EMPLOYEE WORKING ON JOB
        private void CreateUserGB(int i, int iDNum, string empName)
        {
            //FIRST CREATES GROUP BOX
            GroupBox gB = new GroupBox();
            gB.Name = "employee" + i;
            gB.Text = empName;
            gB.Font = new Font("Microsoft YaHei UI", 14, FontStyle.Bold);
            gB.ForeColor = Color.White;
            gB.Width = 723;
            gB.Height = 325;
            gB.BackColor = Color.Transparent;

            //SECOND CREATES LIST VIEW AND INSERTS INTO GROUP BOX
            ListView lV = new ListView();
            lV.Name = "lvEmployee" + i;
            lV.Font = new Font("Microsoft YaHei UI", 8, FontStyle.Regular);
            lV.Width = 700;
            lV.Height = 291;
            lV.Location = new Point(6, 28);
            lV.View = View.Details;
            lV.GridLines = true;

            //ADD COLUMNS WITH PROPER NAMES
            lV.Columns.Add("Item", -2, HorizontalAlignment.Left);
            lV.Columns.Add("Department", -2, HorizontalAlignment.Left);
            lV.Columns.Add("Component", -2, HorizontalAlignment.Left);
            lV.Columns.Add("Hrs Allotted", -2, HorizontalAlignment.Left);
            lV.Columns.Add("Hrs Spent", -2, HorizontalAlignment.Left);
            lV.Columns.Add("Hrs Left", -2, HorizontalAlignment.Left);
            lV.Columns.Add("Date Due", -2, HorizontalAlignment.Left);
            lV.Columns.Add("Date Complete", -2, HorizontalAlignment.Left);
            lV.Columns.Add("Notes", -2, HorizontalAlignment.Left);

            gB.Controls.Add(lV);

            GetEmployeeWork(theJob, EmployeeWorkingIDList[i]);

            if (EmployeesOnJob.Count > 0)
            {
                for (int j = 0; j < EmployeesOnJob[i].WorkAmount; j++)
                {
                    lV.Items.Add(theWorkList[j]);
                }
            }

            //ADD GENERATED EMPLOYEE GROUP BOX INTO ARRAY
            theEmployeeGB[i] = new GroupBox();
            theEmployeeGB[i].Controls.Add(gB);

            //ADD CREATED USER TO THE FORM
            flpEmployees.Controls.Add(gB);
        }

        //CLEARS ALL ELEMENTS ON FORM AND REPOPULATES THEM
        private void RefreshForm()
        {
            for (int k = 0; k < EmployeesOnJob.Count; k++)
            {
                theEmployeeGB[k].Controls.Clear();
            }
            /*
            for (int k = 0; k < theWorkList.Length; k++)
            {
                theWorkList[k].SubItems.Clear();
            }
            */
            for (int k = 0; k < theDayList.Count; k++)
            {
                theDayList[k].SubItems.Clear();
            }

            EmployeesOnJob.Clear();
            EmployeeWorkingIDList.Clear();
            flpEmployees.Controls.Clear();
            flpCalendar.Controls.Clear();
            Array.Clear(WorkListRow, 0, 100);
            Array.Clear(DayListRow, 0, 100);
            workDayCheck = false;

            i = 0;
            j = 0;
            passedWorkAmount = 0;
            addedWorkCount = 0;

            //GET ALL WORK INFORMATION THAT IS REFRESHED
            GetEmployeeIDList(theJob);

            //GENERATE EMPLOYEE WORK ON LEFT
            for (int j = 0; j < EmployeeWorkingIDList.Count; j++)
            {
                GetEmployeeList(theJob, EmployeeWorkingIDList[j]);
                CreateUserGB(j, EmployeesOnJob[j].ID, EmployeesOnJob[j].FirstName + " " + EmployeesOnJob[j].LastName);
            }

            //SET MONTH LABEL
            lblMonth.Text = theMonth.Month;

            //CREATE BLANK DAYS FOR PREVIOUS AND UPCOMING MONTHS
            for (int j = 0; j < theMonth.blankDays; j++)
            {
                AddBlankCalendarDays(j);
            }

            //GENERATE AMOUNT OF DAYS ON CALENDAR FLOWLAYOUTPANEL EQUAL TO THE 
            for (int j = 1; j <= theMonth.MonthDayAmount; j++)
            {
                AddCalendarDays(j, passedWorkAmount);
            }

        }

        //GETS DAY OF WEEK FOR CALENDAR DAY ACCORDING TO AMOUNT OF ELEMENTS ON THE LIST VIEW
        private void GetWeekDay(int i)
        {
            switch (i)
            {
                case 1:
                    weekDay = "SUNDAY";
                    break;
                case 2:
                    weekDay = "MONDAY";
                    break;
                case 3:
                    weekDay = "TUESDAY";
                    break;
                case 4:
                    weekDay = "WEDNESDAY";
                    break;
                case 5:
                    weekDay = "THURSDAY";
                    break;
                case 6:
                    weekDay = "FRIDAY";
                    break;
                case 7:
                    weekDay = "SATURDAY";
                    break;
                case 8:
                    weekDay = "SUNDAY";
                    break;
                case 9:
                    weekDay = "MONDAY";
                    break;
                case 10:
                    weekDay = "TUESDAY";
                    break;
                case 11:
                    weekDay = "WEDNESDAY";
                    break;
                case 12:
                    weekDay = "THURSDAY";
                    break;
                case 13:
                    weekDay = "FRIDAY";
                    break;
                case 14:
                    weekDay = "SATURDAY";
                    break;
                case 15:
                    weekDay = "SUNDAY";
                    break;
                case 16:
                    weekDay = "MONDAY";
                    break;
                case 17:
                    weekDay = "TUESDAY";
                    break;
                case 18:
                    weekDay = "WEDNESDAY";
                    break;
                case 19:
                    weekDay = "THURSDAY";
                    break;
                case 20:
                    weekDay = "FRIDAY";
                    break;
                case 21:
                    weekDay = "SATURDAY";
                    break;
                case 22:
                    weekDay = "SUNDAY";
                    break;
                case 23:
                    weekDay = "MONDAY";
                    break;
                case 24:
                    weekDay = "TUESDAY";
                    break;
                case 25:
                    weekDay = "WEDNESDAY";
                    break;
                case 26:
                    weekDay = "THURSDAY";
                    break;
                case 27:
                    weekDay = "FRIDAY";
                    break;
                case 28:
                    weekDay = "SATURDAY";
                    break;
                case 29:
                    weekDay = "SUNDAY";
                    break;
                case 30:
                    weekDay = "MONDAY";
                    break;
                case 31:
                    weekDay = "TUESDAY";
                    break;

            }
        }

        //CREATE BLANK CALENDAR DAYS TO CORRELATE WEEK DAYS TO LAYOUT
        private void AddBlankCalendarDays(int i)
        {
            //CREATES LIST VIEW AND INSERTS INTO FLOW LAYOUT PANEL
            PictureBox lV = new PictureBox();
            lV.Name = "lvBlankDay" + i;
            lV.Font = new Font("Microsoft YaHei UI", 8, FontStyle.Regular);
            lV.Width = 151;
            lV.Height = 139;
            lV.BackColor = Color.Transparent;

            flpCalendar.Controls.Add(lV);
        }

        //GENERATE CALENDAR DAYS ACCORDING TO THE CURRENT MONTH AND ADD WORK 
        private void AddCalendarDays(int i, int theWorkAmount)
        {
            //CREATES LIST VIEW AND INSERTS INTO FLOW LAYOUT PANEL
            ListView lV = new ListView();
            lV.Name = "lvDay" + i;
            lV.Font = new Font("Microsoft YaHei UI", 8, FontStyle.Regular);
            lV.Width = 151;
            lV.Height = 139;
            lV.View = View.Details;
            lV.GridLines = true;
            lV.Columns.Add(i.ToString());
            GetWeekDay(i + theMonth.blankDays);
            lV.Columns.Add(weekDay);

            flpCalendar.Controls.Add(lV);

            lV.Columns[0].Width = 30;
            lV.Columns[1].Width = 150;

            GetCalendarWork(theJob, Convert.ToInt32(DateTime.Now.ToString("MM")), i);


            //IF GETCALENDARWORK RETURNS WORK FOR THE DAY IT WILL ADD THE SINGLE LINE OF WORK FOR THE DAY
            if (workDayCheck == true)
            {
                //ADDS ALL WORK DUE THAT DAY INTO THE GENERATED DAY 
                for (int k = 0; k < addedWorkCount; k++)
                {
                    lV.Items.Add(theDayList[k]);
                }

                //CLEAR THE ARRAY LIST, ARRAY AND SET CHECK TO FALSE FOR THE WORK DUE ON GENERATED DAY
                theDayList.Clear();
                Array.Clear(DayListRow, 0, DayListRow.Length);
                workDayCheck = false;
                lV.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lV.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            lV.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lV.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        //RETRIEVE WORK FROM DB TO ADD TO THE CALENDAR
        private void GetCalendarWork(string passedJob, int passedMonth, int passedDay)
        {
            j = 0;
            addedWorkCount = 0;
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
                    //
                    ///GET JOB PROCESSES FROM DB SPECIFIC TO LISTED EMPLOYEE
                    //       
                    SqlCommand commandComp = new SqlCommand();

                    commandComp.Connection = connection;
                    commandComp.CommandText = "select * from job_processes where job_number = '" + passedJob + "' and month_due = '" + passedMonth + "' and day_due = '" + passedDay + "';";
                    commandComp.CommandType = CommandType.Text;

                    connection.Open();

                    SqlDataReader readerComp = commandComp.ExecuteReader();

                    while (readerComp.Read())
                    {
                        workDayCheck = true;

                        string itemFound = (string)readerComp["item"];
                        string itemComp = string.Format("{0}", itemFound);

                        string departmentFound = (string)readerComp["department"];
                        string departmentComp = string.Format("{0}", departmentFound);

                        string componentFound = (string)readerComp["component"];
                        string componentComp = string.Format("{0}", componentFound);

                        //CREATES ROW FOR EACH ITEM OF WORK FOR THE PASSED USER AND ADDS IT TO ARRAY OF ROWS
                        string[] row = { itemComp, (departmentComp + " | " + componentComp) };

                        DayListRow[j] = row;
                        theDayList.Add(new ListViewItem(DayListRow[j]));
                        addedWorkCount++;

                        j++;
                    }

                    readerComp.Close();
                    connection.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("GetEmployeeWork Failed");
            }
        }

        //OPENS JOB CARD ADDER FOR THE JOB
        private void pbJobCard_Click(object sender, EventArgs e)
        {
            JobCardAdder theJobCardAdder = new JobCardAdder(theJob);
            theJobCardAdder.ShowDialog();
        }

        //OPENS SERVICES AND ORDERING FORM
        private void pbOutside_Click(object sender, EventArgs e)
        {
            ServicesAndOrdering theSandO = new ServicesAndOrdering(theJob);
            theSandO.ShowDialog();
        }

        //OPENS WORK COMPLETE FORM
        private void pbComplete_Click(object sender, EventArgs e)
        {
            WorkComplete theComplete = new WorkComplete(theJob);
            theComplete.ShowDialog();
        }

        //OPENS ADD EMPLOYEE FORM
        private void pbAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee theAdd = new AddEmployee(theJob);
            theAdd.ShowDialog();
            RefreshForm();
        }

        //CLOSE FORM
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
        ///
        ///FOR CLOCK
        ///
        ///
        Timer theTimer = new Timer();
        private void theTimer_Tick(object sender, EventArgs e)
        {
            //get current time
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            //time
            string time = "";

            //padding leading zero
            if (hh < 10)
            {
                time += "0" + hh;                
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            //update label
            lblClock.Text = time;
        }
        */

        /// 
        ///FOR BUTTON DESIGN
        /// 
        /// 
        //JOB CARD 
        private void pbJobCard_MouseEnter(object sender, EventArgs e)
        {
            int width = pbJobCard.Size.Width;
            int height = pbJobCard.Size.Height;
            int larger = 5;
            pbJobCard.Size = new Size(width + larger, height + larger);
        }

        private void pbJobCard_MouseLeave(object sender, EventArgs e)
        {
            int width = pbJobCard.Size.Width;
            int height = pbJobCard.Size.Height;
            int smaller = 5;
            pbJobCard.Size = new Size(width - smaller, height - smaller);
        }

        //FINISH JOB
        private void pbComplete_MouseEnter(object sender, EventArgs e)
        {
            int width = pbComplete.Size.Width;
            int height = pbComplete.Size.Height;
            int larger = 5;
            pbComplete.Size = new Size(width + larger, height + larger);
        }

        private void pbComplete_MouseLeave(object sender, EventArgs e)
        {
            int width = pbComplete.Size.Width;
            int height = pbComplete.Size.Height;
            int smaller = 5;
            pbComplete.Size = new Size(width - smaller, height - smaller);
        }


        //OUTSIDE SERVICES AND ORDERING
        private void pbOutside_MouseEnter(object sender, EventArgs e)
        {
            int width = pbOutside.Size.Width;
            int height = pbOutside.Size.Height;
            int larger = 5;
            pbOutside.Size = new Size(width + larger, height + larger);
        }

        private void pbOutside_MouseLeave(object sender, EventArgs e)
        {
            int width = pbOutside.Size.Width;
            int height = pbOutside.Size.Height;
            int smaller = 5;
            pbOutside.Size = new Size(width - smaller, height - smaller);
        }

    }
}
