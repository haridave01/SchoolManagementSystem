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
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        

        private void staffBtn_Click(object sender, EventArgs e)
        {
            Staff st = new Staff();
            MainClass.showWindow(st, this, MDI.ActiveForm);
        }

        private void classesBtn_Click(object sender, EventArgs e)
        {
            Classes st = new Classes();
            MainClass.showWindow(st, this, MDI.ActiveForm);
        }

        private void rolesBtn_Click(object sender, EventArgs e)
        {
            Roles st = new Roles();
            MainClass.showWindow(st, this, MDI.ActiveForm);
        }

        private void sectionBtn_Click(object sender, EventArgs e)
        {
            Sections st = new Sections();
            MainClass.showWindow(st, this, MDI.ActiveForm);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Subjects st = new Subjects();
            MainClass.showWindow(st, this, MDI.ActiveForm);
        }

        private void classTimeBtn_Click(object sender, EventArgs e)
        {
            ClassTimings st = new ClassTimings();
            MainClass.showWindow(st, this, MDI.ActiveForm);
        }

        private void shiftsBtn_Click(object sender, EventArgs e)
        {
            Shifts st = new Shifts();
            MainClass.showWindow(st, this, MDI.ActiveForm);
        }

        private void houseBtn_Click(object sender, EventArgs e)
        {
            Houses st = new Houses();
            MainClass.showWindow(st, this, MDI.ActiveForm);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void levelBtn_Click(object sender, EventArgs e)
        {
            levels lv = new levels();
            MainClass.showWindow(lv, this, MDI.ActiveForm);
        }
    }
}
