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
    public partial class levels : Sample2
    {
        public levels()
        {
            InitializeComponent();
        }

        int edit = 0;
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
        int levelID;
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (levelNameTxt.Text == "") { levelErrorLabel.Visible = true; } else { levelErrorLabel.Visible = false; }
            if (levelErrorLabel.Visible)
            {
                MainClass.ShowMSG("Fields with * are mandatory.", "Error...", "Error");
            }
            else
            {
                if (edit == 0) // code for SAVE operation
                {

                    levels c = new levels();

                    obj.st_insertlevel(levelNameTxt.Text);
                    obj.SubmitChanges();
                    MainClass.ShowMSG(levelNameTxt.Text + " added successfully.", "Success...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                }
                else if (edit == 1) // code for UPDATE 
                {

                    obj.st_updatelevel(levelID, levelNameTxt.Text);

                    MainClass.ShowMSG(levelNameTxt.Text + " updated successfully.", "Success...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();

                }

            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete" + levelNameTxt.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    obj.st_deletelevel(levelID);
                    MainClass.ShowMSG(levelNameTxt.Text + " deleted successfully.", "Success...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                }

            }
        }

        private void loadData()
        {

            var abc = obj.st_getlevel();
            levelIDGV.DataPropertyName = "ID";
            levelNameGV.DataPropertyName = "LevelName";
            dataGridView1.DataSource = abc;
            MainClass.sno(dataGridView1, "snoGV");
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            loadData();
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void levelNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (levelNameTxt.Text == "") { levelErrorLabel.Visible = true; } else { levelErrorLabel.Visible = false; }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                MainClass.disable(panel6);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                levelID = Convert.ToInt32(row.Cells["levelIDGV"].Value.ToString());
                levelNameTxt.Text = row.Cells["levelNameGV"].Value.ToString();
                


            }
        }
    }
}
