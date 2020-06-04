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
    public partial class Settings : Sample
    {
        public Settings()
        {
            InitializeComponent();
        }

        
        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if(isCB.Checked)
            {
                if (datasourceTxt.Text == "") { dserrorLabel.Visible = true; } else { dserrorLabel.Visible = false;}
                if (dbTxt.Text == "") { dberrorlabel.Visible = true; } else { dserrorLabel.Visible = false; }
                if(dberrorlabel.Visible || dserrorLabel.Visible)
                {
                    MessageBox.Show("Fields with * are mandatory");
                }
                else
                {
                    sb.Append("Data Source=" + datasourceTxt.Text + ";Initial Catalog=" + dbTxt.Text + ";Integrated Security=true;MultipleActiveResultSets=true");
                    File.WriteAllText(MainClass.path + "\\cnt", sb.ToString());
                    DialogResult dr = MessageBox.Show("Settings saved successfully.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    if(dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        MainClass.showWindow(log, this, MDI.ActiveForm);
                    }
                }
            }
            else
            {
                if (datasourceTxt.Text == "") { dserrorLabel.Visible = true; } else { dserrorLabel.Visible = false; }
                if (dbTxt.Text == "") { dberrorlabel.Visible = true; } else { dserrorLabel.Visible = false; }
                if (usernameTxt.Text == "") { usernameerroelabel.Visible = true; } else { usernameerroelabel.Visible = false; }
                if (passwordTxt.Text == "") { passworderrorlabel.Visible = true; } else { passworderrorlabel.Visible = false; }
                if (dberrorlabel.Visible || dserrorLabel.Visible || usernameerroelabel.Visible || passworderrorlabel.Visible )
                {
                    MessageBox.Show("Fields with * are mandatory");
                }
                else
                {
                    sb.Append("Data Source=" + datasourceTxt.Text + ";Initial Catalog=" + dbTxt.Text + ";User ID="+usernameTxt.Text+";Password="+passwordTxt.Text+";MultipleActiveResultSets=true");
                    File.WriteAllText(MainClass.path + "\\cnt", sb.ToString());
                    DialogResult dr = MessageBox.Show("Settings saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        MainClass.showWindow(log, this, MDI.ActiveForm);
                    }
                }
            }
        }

        private void datasourceTxt_TextChanged(object sender, EventArgs e)
        {
            if(datasourceTxt.Text == "")
            {
                dserrorLabel.Visible = true;

            }
            else
            {
                dserrorLabel.Visible = false;
            }
        }

        private void dbTxt_TextChanged(object sender, EventArgs e)
        {
            if (dbTxt.Text == "")
            {
                dberrorlabel.Visible = true;

            }
            else
            {
                dberrorlabel.Visible = false;
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "")
            {
                usernameerroelabel.Visible = true;

            }
            else
            {
                usernameerroelabel.Visible = false;
            }
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            if (passwordTxt.Text == "")
            {
                passworderrorlabel.Visible = true;

            }
            else
            {
                passworderrorlabel.Visible = false;
            }
        }

        private void isCB_CheckedChanged(object sender, EventArgs e)
        {
            if(isCB.Checked)
            {
                usernameTxt.Text = "";
                usernameTxt.Enabled = false;
                passwordTxt.Text = "";
                passwordTxt.Enabled = false;
                usernameerroelabel.Visible = false;
                passworderrorlabel.Visible = false;
            }
            else
            {
                
                usernameTxt.Enabled = true;
                passwordTxt.Enabled = true;
            }
        }
    }
}
