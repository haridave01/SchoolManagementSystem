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
    public partial class Classes : Sample2
    {
        public Classes()
        {
            InitializeComponent();
        }

        int edit = 0;
        int classID;
        myDBDataContext obj = new myDBDataContext();

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

        private void loadData()
        {

            var abc = obj.st_getClasses();
            classIDGV.DataPropertyName = "ID";
            ClassNameGV.DataPropertyName = "Name";
            StatusGV.DataPropertyName = "Status";
            levelidGV.DataPropertyName = "LevelID";
            LEvelGV.DataPropertyName = "Level";
            dataGridView1.DataSource = abc;
            MainClass.sno(dataGridView1, "snoGV");
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {

            if (classnameTxt.Text == "") { classNameErrorLabel.Visible = true; } else { classNameErrorLabel.Visible = false; }
            if (statusDD.SelectedIndex == -1) { levlErrorLabel.Visible = true; } else { levlErrorLabel.Visible = false; }
            if (levelDD.SelectedIndex == -1) { levlErrorLabel.Visible = true; } else { levlErrorLabel.Visible = false; }
            if (classNameErrorLabel.Visible || levlErrorLabel.Visible || levlErrorLabel.Visible)
            {
                MainClass.ShowMSG("Fields with * are mandatory.", "Error...", "Error");
            }
            else
            {
                if (edit == 0) // code for SAVE operation
                {

                    clase c = new clase();
                   // c.cls_name = classnameTxt.Text;
                    
                    
                    if (statusDD.SelectedIndex == 0)
                    {
                        c.cls_status = 1;
                    }
                    else
                    {
                        c.cls_status = 0;
                    }

                    //obj.roles.InsertOnSubmit(r);
                    obj.st_insertClass(classnameTxt.Text, c.cls_status);
                    //obj.SubmitChanges();
                    MainClass.ShowMSG(classnameTxt.Text + " added successfully.", "Success...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                }
                else if (edit == 1) // code for UPDATE 
                {
                    byte stat;
                    if (statusDD.SelectedIndex == 0)
                    {
                        stat = 1;
                    }
                    else
                    {
                        stat = 0;
                    }
                    obj.st_updateClass(classnameTxt.Text, stat, classID);
                    
                    MainClass.ShowMSG(classnameTxt.Text + " updated successfully.", "Success...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();

                }

            }


        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete" + classnameTxt.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    obj.st_deleteClass(classID);
                    MainClass.ShowMSG(classnameTxt.Text + " deleted successfully.", "Success...", "Success");
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

        }

        private void classTxt_TextChanged(object sender, EventArgs e)
        {
            if (classnameTxt.Text == "") { classNameErrorLabel.Visible = true; } else { classNameErrorLabel.Visible = false; }
        }

        private void statusDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statusDD.SelectedIndex == -1) { levlErrorLabel.Visible = true; } else { levlErrorLabel.Visible = false; }
        }

        public void loadList()
        {
            var li = (from s in obj.levels select new { s.l_id, s.l_name }).ToList();
            li.Insert(0, new { l_id = 0, l_name = "Select" });
            levelDD.DataSource = li;
            levelDD.DisplayMember = "l_name";
            levelDD.ValueMember = "l_id";
        }

        private void Classes_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel6);
            loadList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                MainClass.disable(panel6);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                classID = Convert.ToInt32(row.Cells["classIDGV"].Value.ToString());
                classnameTxt.Text = row.Cells["ClassNameGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                levelDD.SelectedValue = row.Cells["levelidGV"].Value;


            }
        }

        private void levelDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (levelDD.SelectedIndex == -1) { levlErrorLabel.Visible = true; } else { levlErrorLabel.Visible = false; }
        }
    }
}
