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
using System.Drawing.Imaging;
using System.Data.SqlClient;

namespace SchoolManagementSystem
{
    public partial class Staff : Sample2
    {
        public Staff()
        {
            InitializeComponent();
        }

        int edit = 0;
        myDBDataContext obj = new myDBDataContext();

        public void loadList()
        {
            var li = (from s in obj.roles select new { s.r_id, s.r_name }).ToList();
            li.Insert(0, new { r_id = 0, r_name = "Select" });
            roleDD.DataSource = li;
            roleDD.DisplayMember = "r_name";
            roleDD.ValueMember = "r_id";
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(panel6);
            imagePathTxt.Enabled = false;
            edit = 0;
            loadList();
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(panel6);
            imagePathTxt.Enabled = false;
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text == "") { nameErrorLabel.Visible = true; } else { nameErrorLabel.Visible = false; }
            if (usernameTxt.Text == "") { usernameErrorLabel.Visible = true; } else { usernameErrorLabel.Visible = false; }
            if (passwordTxt.Text == "") { passwordErrorLabel.Visible = true; } else { passwordErrorLabel.Visible = false; }
            if (confirmPassTxt.Text == "") { confirmPassErrorLabel.Visible = true; } else { confirmPassErrorLabel.Visible = false; }
            if (passwordTxt.Text != confirmPassTxt.Text) { mismatchedErrorLabel.Visible = true; } else { mismatchedErrorLabel.Visible = false; }
            if (phone1Txt.Text == "") { phone1ErrorLabel.Visible = true; } else { phone1ErrorLabel.Visible = false; }
            if (roleDD.SelectedIndex == -1) { roleErrorLabel.Visible = true; } else { roleErrorLabel.Visible = false; }
            if (statusDD.SelectedIndex == -1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }
            
            if(nameErrorLabel.Visible || usernameErrorLabel.Visible || passwordErrorLabel.Visible || confirmPassErrorLabel.Visible || mismatchedErrorLabel.Visible || phone1ErrorLabel.Visible || roleErrorLabel.Visible || statusErrorLabel.Visible )
            {
                MainClass.ShowMSG("Fields with * are mandatory.", "Stop...", "Error");
            }
            else
            {
                if(edit == 0) // code for SAVE operation
                {
                    if(imagePathTxt.Text =="")
                    {
                        byte stat = statusDD.SelectedIndex ==0? Convert.ToByte(1) : Convert.ToByte(0);
                        obj.st_insertStaffWithoutImage(nameTxt.Text, usernameTxt.Text, passwordTxt.Text, phone1Txt.Text, phone2Txt.Text, Convert.ToInt32(roleDD.SelectedValue.ToString()),stat);
                        MainClass.ShowMSG(nameTxt.Text + " added successfully into the system.", "Success", "Success");
                        MainClass.disable_reset(panel6);
                        loadData();
                    }
                    else
                    {
                        byte stat = statusDD.SelectedIndex == 0 ? Convert.ToByte(1) : Convert.ToByte(0);
                        MemoryStream ms = new MemoryStream();
                        i.Save(ms, ImageFormat.Jpeg);
                        byte[] arr = ms.ToArray();
                        obj.st_insertStaff(nameTxt.Text, usernameTxt.Text, passwordTxt.Text, phone1Txt.Text, phone2Txt.Text, Convert.ToInt32(roleDD.SelectedValue.ToString()), stat, arr);
                        MainClass.ShowMSG(nameTxt.Text + " added successfully into the system.", "Success", "Success");
                        MainClass.disable_reset(panel6);
                        loadData();
                    }
                }
                else if(edit == 1) // code for UPDATE operation
                {
                    byte stat = statusDD.SelectedIndex == 0 ? Convert.ToByte(1) : Convert.ToByte(0);
                    if(i == null)
                    {
                        obj.st_updateStaffWithoutImage(nameTxt.Text, usernameTxt.Text, passwordTxt.Text, phone1Txt.Text, phone2Txt.Text, Convert.ToInt32(roleDD.SelectedValue.ToString()), stat, staffID);
                        MainClass.ShowMSG(nameTxt.Text + " data updated successfully into the system.", "Success", "Success");
                        MainClass.disable_reset(panel6);
                        loadData();
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream();
                        i.Save(ms, ImageFormat.Jpeg);
                        byte[] arr = ms.ToArray();
                        obj.st_updateStaff(nameTxt.Text, usernameTxt.Text, passwordTxt.Text, phone1Txt.Text, phone2Txt.Text, Convert.ToInt32(roleDD.SelectedValue.ToString()), stat, arr,staffID);
                        MainClass.ShowMSG(nameTxt.Text + " data updated successfully into the system.", "Success", "Success");
                        MainClass.disable_reset(panel6);
                        loadData();
                    }
                }
                
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if(edit == 1)
            {
                obj.st_deleteStaff(staffID);
                MainClass.ShowMSG(nameTxt.Text + " deleted successfully from the system.", "Success", "Success");
                MainClass.disable_reset(panel6);
                loadData();
            }
        }

        private void loadData()
       {
           var data = obj.st_getStaffDetails();
           userIDGV.DataPropertyName = "ID";
           nameGV.DataPropertyName = "Name";
           usernameGV.DataPropertyName = "Username";
           passwordGV.DataPropertyName = "Password";
           phone1GV.DataPropertyName = "Phone1";
           phone2GV.DataPropertyName = "Phone2";
           RoleGV.DataPropertyName = "Role";
           StatusGV.DataPropertyName = "Status";
           roleIDGV.DataPropertyName = "RoleID";
           dataGridView1.DataSource = data;
           MainClass.sno(dataGridView1, "snoGV");
       }


        public override void viewBtn_Click(object sender, EventArgs e)
        {
            loadData();
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            if (nameTxt.Text == "") { nameErrorLabel.Visible = true; } else { nameErrorLabel.Visible = false; }
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "") { usernameErrorLabel.Visible = true; } else { usernameErrorLabel.Visible = false; }
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            if (passwordTxt.Text == "") { passwordErrorLabel.Visible = true; } else { passwordErrorLabel.Visible = false; }
        }

        private void confirmPassTxt_TextChanged(object sender, EventArgs e)
        {
            if (confirmPassTxt.Text == "") { confirmPassErrorLabel.Visible = true; } else { confirmPassErrorLabel.Visible = false; }
        }

        public void confirmPassTxt_Validating(object sender, CancelEventArgs e)
        {
            if (passwordTxt.Text != confirmPassTxt.Text) { mismatchedErrorLabel.Visible = true; } else { mismatchedErrorLabel.Visible = false; }
        }

        private void phone1Txt_TextChanged(object sender, EventArgs e)
        {
            if (phone1Txt.Text == "") { phone1ErrorLabel.Visible = true; } else { phone1ErrorLabel.Visible = false; }
        }

        private void roleDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roleDD.SelectedIndex == -1) { roleErrorLabel.Visible = true; } else { roleErrorLabel.Visible = false; }
        }

        private void statusDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statusDD.SelectedIndex == -1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }
        }

        Image i;
        private void browseBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if(dr == DialogResult.OK)
            {
                 i = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = i;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                imagePathTxt.Text = openFileDialog1.FileName;
            }

        }

        private void Staff_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel6);
            
            //SqlCommand cmd = new SqlCommand("st_getRole", MainClass.);
            loadList();
        }

        int staffID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex !=-1 && e.ColumnIndex !=-1)
            {
                edit = 1;
                pictureBox1.Image = null;
                MainClass.disable(panel6);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                staffID = Convert.ToInt32(row.Cells["UserIDGV"].Value.ToString());
                nameTxt.Text = row.Cells["nameGV"].Value.ToString();
                usernameTxt.Text = row.Cells["UsernameGV"].Value.ToString();
                passwordTxt.Text = row.Cells["PasswordGV"].Value.ToString();
                confirmPassTxt.Text = row.Cells["PasswordGV"].Value.ToString();
                phone1Txt.Text = row.Cells["phone1GV"].Value.ToString();
                phone2Txt.Text = row.Cells["phone2GV"].Value.ToString();
                roleDD.SelectedValue = row.Cells["roleIDGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();

                var im = (from x in obj.staffs where x.st_id == staffID select x.st_image).First();
                if(im == null)
                {

                }
                else
                {
                    byte[] arr = im.ToArray();
                    MemoryStream ms = new MemoryStream(arr);
                    i = Image.FromStream(ms);
                    pictureBox1.Image = i;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

    }
}
