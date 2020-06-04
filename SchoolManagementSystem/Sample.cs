using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Sample : Form
    {
        public Sample()
        {
            InitializeComponent();
        }

        public static MDI stfobj;

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Sample_Load(object sender, EventArgs e)
        {
            stfname.Text = MainClass.STAFFNAME;
  
        }
    }
}
