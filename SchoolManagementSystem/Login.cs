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
    public partial class Login : Sample
    {
        public Login()
        {
            InitializeComponent();
        }

        MainClass mai = new MainClass();
        
        
        private void Login_Load(object sender, EventArgs e)
        {
            //MDI obj = new MDI();
            //obj.logoutToolStripMenuItem.Enabled = true;
            
        }

        
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "") { usernameErrorLabel.Visible = true; } else { usernameErrorLabel.Visible = false; }
            if (passwordtxt.Text == "") { passwordErrorLabel.Visible = true; } else { passwordErrorLabel.Visible = false; }
            
            if(usernameErrorLabel.Visible || passwordErrorLabel.Visible)
            {
                MainClass.ShowMSG("Fields with * are mandatory.", "Error", "Error");
            }
            else
            {
               
                if(mai.getStaffLogin(usernameTxt.Text,passwordtxt.Text))
                {
                    if (MainClass.STAFFROLE == "Faculty")
                    {
                        FacultyDB hs = new FacultyDB();
                        MainClass.showWindow(hs, this, MDI.ActiveForm);
                        MDI.mdiobj.logoutToolStripMenuItem.Enabled = true;
                        this.Close();
                    }
                    else if (MainClass.STAFFROLE == "Admin")
                    {
                        HomeScreen hs = new HomeScreen();
                        MainClass.showWindow(hs, this, MDI.ActiveForm);
                        MDI.mdiobj.logoutToolStripMenuItem.Enabled = true;
                        this.Close();
                    }
                  

                }
                else
                {
                    MainClass.ShowMSG("Invalid login details.", "Error", "Error");
                }
                
            }
            
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "") { usernameErrorLabel.Visible = true; } else { usernameErrorLabel.Visible = false; }
        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {
            if (passwordtxt.Text == "") { passwordErrorLabel.Visible = true; } else { passwordErrorLabel.Visible = false; }
        }
    }
}
