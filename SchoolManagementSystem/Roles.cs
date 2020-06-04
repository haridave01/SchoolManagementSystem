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
    public partial class Roles : Sample2
    {
        public Roles()
        {
            InitializeComponent();
        }

        int edit = 0;
        myDBDataContext obj = new myDBDataContext();

        private void roleTxt_TextChanged(object sender, EventArgs e)
        {
            if (roleTxt.Text == "") { roleErrorLabel.Visible = true; } else { roleErrorLabel.Visible = false; }
        }

        private void statusDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statusDD.SelectedIndex == -1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }
            
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            edit = 0;
            MainClass.enable_reset(panel6);

        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(panel6);
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (roleTxt.Text == "") { roleErrorLabel.Visible = true; } else { roleErrorLabel.Visible = false; }
            if (statusDD.SelectedIndex == -1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }
            if(roleErrorLabel.Visible || statusErrorLabel.Visible)
            {
                MainClass.ShowMSG("Fields with * are mandatory.", "Error...", "Error");
            }
            else
            {
                if (edit == 0) // code for SAVE operation
                {
                    
                    role r = new role();
                    r.r_name = roleTxt.Text;
                    if(statusDD.SelectedIndex == 0)
                    {
                        r.r_status = 1;
                    }
                    else
                    {
                        r.r_status = 0;
                    }

                    //obj.roles.InsertOnSubmit(r);
                    obj.st_insertRoles(roleTxt.Text, r.r_status);
                    obj.SubmitChanges();
                    MainClass.ShowMSG(roleTxt.Text +" added successfully.", "Success...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                }
                else if(edit == 1) // code for UPDATE 
                {
                    byte stat;
                    if(statusDD.SelectedIndex == 0)
                    {
                        stat = 1;
                    }
                    else
                    {
                        stat = 0;
                    }
                    obj.st_updateRoles(roleTxt.Text, stat,roleID);
                    //var data = obj.roles.Single(x => x.r_id == roleID);

                    //data.r_name = roleTxt.Text;
                    //if (statusDD.SelectedIndex == 0)
                    //{
                    //    data.r_status = 1;
                    //}
                    //else
                    //{
                    //    data.r_status = 0;
                    //}
                    //obj.SubmitChanges();
                    MainClass.ShowMSG(roleTxt.Text + " updated successfully.", "Success...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                    
                }
                     
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if(edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete" + roleTxt.Text + "?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    obj.st_deleteRole(roleID);
                    MainClass.ShowMSG(roleTxt.Text + " deleted successfully.", "Success...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                }
                
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            loadData();
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {
            searchData();
        }

        private void loadData()
        {
            
            var abc = obj.st_getRoles();
            rolesIDGV.DataPropertyName = "ID";
            RoleGV.DataPropertyName = "Role";
            StatusGV.DataPropertyName = "Status";
            dataGridView1.DataSource = abc;
            MainClass.sno(dataGridView1, "snoGV");
        }

        private void searchData()
        {
            var abc = obj.st_searchRoles(searchTxt.Text);
            rolesIDGV.DataPropertyName = "ID";
            StatusGV.DataPropertyName = "Role";
            dataGridView1.DataSource = abc;
            MainClass.sno(dataGridView1, "snoGV");
                
        }

        private void Roles_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel6);
            

        }

        int roleID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.ColumnIndex !=-1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                roleID = Convert.ToInt32(row.Cells["rolesIDGV"].Value.ToString());
                roleTxt.Text = row.Cells["RoleGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                
                
            }
        }
    }
}
