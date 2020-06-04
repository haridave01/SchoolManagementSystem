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
    public partial class Subjects : Sample2
    {
        public Subjects()
        {
            InitializeComponent();
        }

        int edit = 0;
        myDBDataContext obj = new myDBDataContext();

        private void subjectTxt_TextChanged(object sender, EventArgs e)
        {
            if (subjectTxt.Text == "") { subjectErrorLabel.Visible = true; } else { subjectErrorLabel.Visible = false; }
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


        private void loadData()
        {

            var abc = obj.st_getSubjects();
            subjectIDGV.DataPropertyName = "ID";
            subjectGV.DataPropertyName = "Subjects";
            classidGV.DataPropertyName = "ClassID";
            ClassGV.DataPropertyName = "Class";
            dataGridView1.DataSource = abc;
            MainClass.sno(dataGridView1, "snoGV");
        }


        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (subjectTxt.Text == "") { subjectErrorLabel.Visible = true; }
            else
            {
                subjectErrorLabel.Visible = false;
                if (classDD.SelectedIndex == -1) { belongsErrorLabel.Visible = true; } else { belongsErrorLabel.Visible = false; }
                if (subjectErrorLabel.Visible || belongsErrorLabel.Visible)
                {
                    MainClass.ShowMSG("Fields with * are mandatory.", "Error...", "Error");
                }
                else
                {
                    if (edit == 0) // code for SAVE operation
                    {
                        try
                        {
                            subject s = new subject();
                            obj.st_insertSubject(subjectTxt.Text, Convert.ToInt32(classDD.SelectedValue.ToString()));
                            obj.SubmitChanges();
                            MainClass.ShowMSG(subjectTxt.Text + " added successfully.", "Success...", "Success");
                            MainClass.disable_reset(panel6);
                            loadData();
                        }
                        catch (Exception ex)
                        {
                            MainClass.ShowMSG("Possible Errors\n\n1.Are you trying to add same subject in this class?\n2.Contact technical support assistance.", "Error", "Error");
                        }

                    }
                    else
                    {
                        obj.st_updateSubject(subjectTxt.Text, Convert.ToInt32(classDD.SelectedValue.ToString()), subjectID);
                        MainClass.ShowMSG(subjectTxt.Text + " updated successfully.", "Success...", "Success");
                        MainClass.disable_reset(panel6);
                        loadData();
                    }
                }
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete" + subjectTxt.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    obj.st_deleteSubject(subjectID);
                    MainClass.ShowMSG(subjectTxt.Text + " deleted successfully.", "Success...", "Success");
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

        int subjectID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                MainClass.disable(panel6);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                subjectID = Convert.ToInt32(row.Cells["subjectIDGV"].Value.ToString());
                subjectTxt.Text = row.Cells["subjectGV"].Value.ToString();
                classDD.SelectedValue = row.Cells["classidGV"].Value;
                
            }
        }

        public void loadList()
        {
            var li = (from s in obj.classes select new { s.cls_id, s.cls_name }).ToList();
            li.Insert(0, new { cls_id = 0, cls_name = "Select" });
            classDD.DataSource = li;
            classDD.DisplayMember = "cls_name";
            classDD.ValueMember = "cls_id";
        }

        private void Subjects_Load(object sender, EventArgs e)
        {
            loadList();
        }

        private void classDD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
