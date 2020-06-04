using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SchoolManagementSystem
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        public static MDI mdiobj;
        
        private void MDI_Load(object sender, EventArgs e)
        {
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if(File.Exists(MainClass.path +"\\cnt"))
            {
                Login obj = new Login();
                obj.MdiParent = this;
                obj.WindowState = FormWindowState.Maximized; 
                obj.Show();
                
                
            }
            else
            {
                Settings obj = new Settings();
                obj.MdiParent = this;
                obj.WindowState = FormWindowState.Maximized;
                obj.Show();
                
                
            }

            logoutToolStripMenuItem.Enabled = false;
            Login log = new Login();
            log.Show();
            log.MdiParent = this;
            mdiobj = this;
            Sample s1 = new Sample();
            s1.stfname.Visible = false;
            
        }

        
        
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
               Login lg = new Login();
               lg.MdiParent = this;
               lg.WindowState = FormWindowState.Maximized;
               lg.Show();
           
            
            
            
            //Login lg = new Login();
            //lg.MdiParent = this;
            //lg.Show();
            
            
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
                
            Login lg = new Login();
            lg.MdiParent = this;
            lg.WindowState = FormWindowState.Maximized;
            lg.stfname.Visible = false;
            lg.Show();
            logoutToolStripMenuItem.Enabled = false;
            
            
            
        }
    }
}
