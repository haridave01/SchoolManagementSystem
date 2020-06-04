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
    public partial class ClassTimings : Sample2
    {
        public ClassTimings()
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

        int timingID;

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (timingNameTxt.Text == "") { timingNameErrorLabel.Visible = true; } else { timingNameErrorLabel.Visible = false; }
            if (timingShiftDD.SelectedIndex == -1) { timingshifterrorLabel.Visible = true; } else { timingshifterrorLabel.Visible = false; }
            if (timingDaysDD.SelectedIndex == -1) { timingDayErrorLabel.Visible = true; } else { timingDayErrorLabel.Visible = false; }
            if (levelDD1.SelectedIndex == -1) { levelerrorlabel.Visible = true; } else { levelerrorlabel.Visible = false; }
            if (timingNameErrorLabel.Visible || timingshifterrorLabel.Visible || timingDayErrorLabel.Visible || levelerrorlabel.Visible)
            {
                MainClass.ShowMSG("Fields with * are mandatory.", "Error...", "Error");
            }
            else
            {
                TimeSpan startTime = new TimeSpan(fromTiming.Value.Hour, fromTiming.Value.Minute, fromTiming.Value.Second);
                TimeSpan endTime = new TimeSpan(toTiming.Value.Hour, toTiming.Value.Minute, toTiming.Value.Second);
                if (edit == 0) // code for SAVE operation
                {
                    

                    try
                    {
                        ClassTimings s = new ClassTimings();
                        obj.st_insertTimings(timingNameTxt.Text, Convert.ToInt32(timingShiftDD.SelectedValue.ToString()), startTime, endTime, timingDaysDD.SelectedItem.ToString(), Convert.ToInt32(levelDD1.SelectedValue.ToString()));
                        obj.SubmitChanges();
                        MainClass.ShowMSG(timingNameTxt.Text + " added successfully.", "Success...", "Success");
                        MainClass.disable_reset(panel6);
                        loadData();
                    }
                    catch (Exception ex)
                    {
                        MainClass.ShowMSG(ex.Message, "Error", "Error");
                    }

                }
                else
                {
                    obj.st_updateTimings(timingNameTxt.Text, Convert.ToInt32(timingShiftDD.SelectedValue.ToString()), startTime, endTime, timingDaysDD.SelectedItem.ToString(), timingID, Convert.ToInt32(levelDD1.SelectedValue.ToString()));
                    MainClass.ShowMSG(timingNameTxt.Text + " updated successfully.", "Success...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                }
            }
        }

        private void loadData()
        {

            var abc = obj.st_getTimings();
            tIdGV.DataPropertyName = "ID";
            
            timingNameGV.DataPropertyName = "TimingName";  
            fromGV.DataPropertyName = "From";
            toGV.DataPropertyName = "To";
            shiftIdGV.DataPropertyName = "ShiftID";
            shiftGV.DataPropertyName = "ShiftName";
            DayGV.DataPropertyName = "Day";
            levelIDGV.DataPropertyName = "LevelID";
            levelNameGV.DataPropertyName = "Level";
            
            dataGridView1.DataSource = abc;
            MainClass.sno(dataGridView1, "snoGV");
            
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete" + timingNameTxt.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    obj.st_deleteTimings(timingID);
                    MainClass.ShowMSG(timingNameTxt.Text + " deleted successfully.", "Success...", "Success");
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

        

        private void timingNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (timingNameTxt.Text == "") { timingNameErrorLabel.Visible = true; } else { timingNameErrorLabel.Visible = false; }
        }

        private void timingShiftDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timingShiftDD.SelectedIndex == -1) { timingshifterrorLabel.Visible = true; } else { timingshifterrorLabel.Visible = false; }
        }

        private void timingDaysDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timingDaysDD.SelectedIndex == -1) { timingDayErrorLabel.Visible = true; } else { timingDayErrorLabel.Visible = false; }
        }

        private void ClassTimings_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            loadList();

        }
        public void loadList()
        {
            var li = (from s in obj.shifts select new { s.sh_id, s.sh_name }).ToList();
            li.Insert(0, new { sh_id = 0, sh_name = "Select" });
            timingShiftDD.DataSource = li;
            timingShiftDD.DisplayMember = "sh_name";
            timingShiftDD.ValueMember = "sh_id";

            var li2 = (from s in obj.levels select new { s.l_id, s.l_name }).ToList();
            li2.Insert(0, new { l_id = 0, l_name = "Select" });
            levelDD1.DataSource = li2;
            levelDD1.DisplayMember = "l_name";
            levelDD1.ValueMember = "l_id";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                MainClass.disable(panel6);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
               
                timingID = Convert.ToInt32(row.Cells["tIdGV"].Value.ToString());
                timingNameTxt.Text = row.Cells["timingNameGV"].Value.ToString();
                fromTiming.Value = Convert.ToDateTime(row.Cells["fromGV"].Value);
                toTiming.Value = Convert.ToDateTime(row.Cells["toGV"].Value);
                timingDaysDD.SelectedItem = row.Cells["DayGV"].Value.ToString();
                timingShiftDD.SelectedValue = row.Cells["shiftIdGV"].Value.ToString();
                levelDD1.SelectedValue = row.Cells["levelIDGV"].Value.ToString();
                
                


            }
        }

        private void levelDD1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (levelDD1.SelectedIndex == -1) { levelerrorlabel.Visible = true; } else { levelerrorlabel.Visible = false; }
        }

        private void classdd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
    }
}
