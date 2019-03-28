using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLM_Job_Portal
{
    class CalendarMonthJobView
    {
        public string Month;
        public int MonthDayAmount, blankDays;
        public string day, sDate;
        public string dayEnd;

        public CalendarMonthJobView(int theMonth)
        {
            dayEnd = "th";
            sDate = DateTime.Now.ToString();
            DateTime dateValue = (Convert.ToDateTime(sDate.ToString()));
            day = dateValue.Day.ToString();

            switch(day)
            {
                case "1":
                    dayEnd = "st";
                    break;
                case "2":
                    dayEnd = "nd";
                    break;
                case "3":
                    dayEnd = "rd";
                    break;

            }

            switch (theMonth)
            {
                case 1:
                    Month = "January " + day.ToString() + dayEnd;
                    MonthDayAmount = 31;
                    blankDays = 2;
                    break;
                case 2:
                    Month = "February " + day.ToString() + dayEnd;
                    MonthDayAmount = 28;
                    blankDays = 5;
                    break;
                case 3:
                    Month = "March " + day.ToString() + dayEnd;
                    MonthDayAmount = 31;
                    blankDays = 5;
                    break;
                case 4:
                    Month = "April " + day.ToString() + dayEnd;
                    MonthDayAmount = 30;
                    blankDays = 1;
                    break;
                case 5:
                    Month = "May " + day.ToString() + dayEnd;
                    MonthDayAmount = 31;
                    blankDays = 3;
                    break;
                case 6:
                    Month = "June " + day.ToString() + dayEnd;
                    MonthDayAmount = 30;
                    blankDays = 6;
                    break;
                case 7:
                    Month = "July " + day.ToString() + dayEnd;
                    MonthDayAmount = 31;
                    blankDays = 1;
                    break;
                case 8:
                    Month = "August " + day.ToString() + dayEnd;
                    MonthDayAmount = 31;
                    blankDays = 4;
                    break;
                case 9:
                    Month = "September " + day.ToString() + dayEnd;
                    MonthDayAmount = 30;
                    blankDays = 0;
                    break;
                case 10:
                    Month = "October " + day.ToString() + dayEnd;
                    MonthDayAmount = 31;
                    blankDays = 2;
                    break;
                case 11:
                    Month = "November " + day.ToString() + dayEnd;
                    MonthDayAmount = 30;
                    blankDays = 5;
                    break;
                case 12:
                    Month = "December " + day.ToString() + dayEnd;
                    MonthDayAmount = 31;
                    blankDays = 0;
                    break;
            }
        }

    }
}
