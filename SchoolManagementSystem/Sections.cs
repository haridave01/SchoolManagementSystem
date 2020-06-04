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
    public partial class Sections : Sample2
    {
        public Sections()
        {
            InitializeComponent();
        }

        int edit = 0;
        myDBDataContext obj = new myDBDataContext();

        private void sectionTxt_TextChanged(object sender, EventArgs e)
        {
            if (sectionTxt.Text == "") { sectionErrorLabel.Visible = true; } else { sectionErrorLabel.Visible = false; }
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


        private void loadData()
        {

            var abc = obj.st_getSections();
            sectionIDGV.DataPropertyName = "ID";
            sectionGV.DataPropertyName = "Name";
            StatusGV.DataPropertyName = "Status";
            dataGridView1.DataSource = abc;
            MainClass.sno(dataGridView1, "snoGV");
        }

        int sectionID;

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (sectionTxt.Text == "") { sectionErrorLabel.Visible = true; } else { sectionErrorLabel.Visible = false; }
            if (statusDD.SelectedIndex == -1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }
            if (sectionErrorLabel.Visible || statusErrorLabel.Visible)
            {
                MainClass.ShowMSG("Fields with * are mandatory.", "Error...", "Error");
            }
            else
            {
                if(edit == 0) // code for SAVe
                {
                    section s = new section();
                    
                    if (statusDD.SelectedIndex == 0)
                    {
                        s.sec_status = 1;
                    }
                    else
                    {
                        s.sec_status = 0;
                    }

                    obj.st_insertSections(sectionTxt.Text, s.sec_status);
                    obj.SubmitChanges();
                    MainClass.ShowMSG(sectionTxt.Text + " added successfully.", "Success...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                }
                else // code for update
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
                    obj.st_updateSections(sectionTxt.Text, stat, sectionID );
                    
                    MainClass.ShowMSG(sectionTxt.Text + " updated successfully.", "Success...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                }
            }

        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete" + sectionTxt.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    obj.st_deleteSection(sectionID);
                    MainClass.ShowMSG(sectionTxt.Text + " deleted successfully.", "Success...", "Success");
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                sectionID = Convert.ToInt32(row.Cells["sectionIDGV"].Value.ToString());
                sectionTxt.Text = row.Cells["sectionGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();


            }
        }

        private void Sections_Load(object sender, EventArgs e)
        {

        }
    }
}
