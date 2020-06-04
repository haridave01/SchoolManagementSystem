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
    public partial class Shifts : Sample2
    {
        public Shifts()
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

        private void loadData()
        {

            var abc = obj.st_getShifts();
            shiftIDGV.DataPropertyName = "ID";
            shiftNameGV.DataPropertyName = "Name";
            shiftNumberGV.DataPropertyName = "Number";
            startGV.DataPropertyName = "From";
            endTimeGV.DataPropertyName = "To";
            dataGridView1.DataSource = abc;
            MainClass.sno(dataGridView1, "snoGV");
        }

        int shiftID;

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (shiftNameTxt.Text == "") { shiftErrorLabel.Visible = true; } else { shiftErrorLabel.Visible = false; }

            if (shiftDD.SelectedIndex == -1) { shiftDDerrorLabel.Visible = true; } else { shiftDDerrorLabel.Visible = false; }

            if(shiftDDerrorLabel.Visible || shiftDDerrorLabel.Visible)
            {
                MainClass.ShowMSG("Fields with * are mandatory.", "Error...", "Error");
            }
            else
            {
                TimeSpan startTime = new TimeSpan(startPicker.Value.Hour, startPicker.Value.Minute, startPicker.Value.Second);
                TimeSpan endTime = new TimeSpan(endPicker.Value.Hour, endPicker.Value.Minute, endPicker.Value.Second);
                //startTime.ToString();
                //endTime.ToString();
                //TimeSpan st = Convert.ToInt16(startPicker.Value.Hour.ToString());
                //TimeSpan et = endPicker.Value.TimeOfDay;

                //TimeSpan st = this.startPicker.Value.TimeOfDay;
                //TimeSpan et = this.endPicker.Value.TimeOfDay;

                //int st = Convert.ToInt16(startPicker.Value.ToString());
                //int et = Convert.ToInt16(endPicker.Value.ToString());

                //DateTime start = DateTime.Parse(startPicker.Text).Date;
                //DateTime end = DateTime.Parse(endPicker.Text).Date;

                //DateTime dt = startPicker.Value;
                //TimeSpan st = new TimeSpan(dt.Hour, dt.Minute, dt.Second);
                //DateTime en = endPicker.Value;
                //TimeSpan et = new TimeSpan(en.Hour, en.Minute, en.Second);

                //TimeSpan st = dt.TimeOfDay;

                //int t = Convert.ToInt16(startPicker.Value.Hour.ToString());
                //int y = Convert.ToInt16(endPicker.Value.Hour.ToString());

                //TimeSpan ts1 = TimeSpan.Parse(startPicker.Text);
                //TimeSpan ts2 = TimeSpan.Parse(endPicker.Text);


                //TimeSpan ts = startPicker.Value.TimeOfDay;
                //TimeSpan es = endPicker.Value.TimeOfDay;

                


                if (edit == 0) // code for SAVE operation
                {
                    try
                    {
                        shift s = new shift();
                       

                        obj.st_insertShifts(shiftNameTxt.Text,Convert.ToByte(shiftDD.SelectedItem.ToString()),startTime,endTime);
                        obj.SubmitChanges();
                        MainClass.ShowMSG(shiftNameTxt.Text + " added successfully.", "Success...", "Success");
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
                    obj.st_updateShifts(shiftNameTxt.Text, Convert.ToByte(shiftDD.SelectedItem.ToString()),startTime,endTime,shiftID);
                    MainClass.ShowMSG(shiftNameTxt.Text + " updated successfully.", "Success...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                }
            }

        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete" + shiftNameTxt.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    obj.st_deleteShifts(shiftID);
                    MainClass.ShowMSG(shiftNameTxt.Text + " deleted successfully.", "Success...", "Success");
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

        private void shiftNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (shiftNameTxt.Text == "") { shiftErrorLabel.Visible = true; } else { shiftErrorLabel.Visible = false; }
               
        }

        private void shiftDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (shiftDD.SelectedIndex == -1) { shiftDDerrorLabel.Visible = true; } else { shiftDDerrorLabel.Visible = false; }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                MainClass.disable(panel6);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                shiftID = Convert.ToInt32(row.Cells["shiftIDGV"].Value.ToString());
                startPicker.Value = Convert.ToDateTime(row.Cells["startGV"].Value);
                endPicker.Value = Convert.ToDateTime(row.Cells["endTimeGV"].Value);
                shiftDD.SelectedItem = row.Cells["shiftNumberGV"].Value.ToString();
                shiftNameTxt.Text = row.Cells["shiftNameGV"].Value.ToString();

            }
        }
    }
}
