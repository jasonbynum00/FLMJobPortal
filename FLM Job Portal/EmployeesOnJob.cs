using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLM_Job_Portal
{
    public class EmployeesOnJob
    {
        public int ID;
        public string FirstName;
        public string LastName;
        public string Initials;
        public int WorkAmount;
        public List<ListViewItem> Work;

        public EmployeesOnJob()
        {

        }

        public EmployeesOnJob(int theId, int theWorkAmount)
        {
            ID = theId;
            WorkAmount = theWorkAmount;
        }

        //CONSTRUCTOR FOR JOBVIEW FORM
        public EmployeesOnJob(int theId, string theFirst, string theLast, string theInitials, int theWorkAmount)
        {
            FirstName = theFirst;
            LastName = theLast;
            Initials = theInitials;
            ID = theId;
            WorkAmount = theWorkAmount;
        }

        //CONSTRUCTOR FOR EDITWORK
        public EmployeesOnJob(int theId, string theFirst, string theLast, int theJobAmount, string theInitials)
        {
            ID = theId;
            FirstName = theFirst;
            LastName = theLast;
            WorkAmount = theJobAmount;
            Initials = theInitials;

        }

    }
}
