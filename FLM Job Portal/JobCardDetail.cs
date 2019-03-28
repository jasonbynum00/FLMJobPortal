using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLM_Job_Portal
{
    public partial class JobCardDetail : Form
    {
        public JobCardDetail()
        {
            InitializeComponent();
        }

        public JobCardDetail(string[] theCard)
        {
            InitializeComponent();

            dtpDate.Text = theCard[0];
            cmboJob.Text = theCard[1];
            cmboItem.Text = theCard[2];
            cmboHours.Text = theCard[3];
            cmboOvertime.Text = theCard[4];


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
