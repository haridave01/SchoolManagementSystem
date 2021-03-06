﻿using System;
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
    public partial class Houses : Sample2
    {
        public Houses()
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

            var abc = obj.st_gethousse();
            houseIDGV.DataPropertyName = "ID";
            houseGV.DataPropertyName = "House";
            StatusGV.DataPropertyName = "Status";
            dataGridView1.DataSource = abc;
            MainClass.sno(dataGridView1, "snoGV");
        }

        int houseID;

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (houseTxt.Text == "") { houseErrorLabel.Visible = true; } else { houseErrorLabel.Visible = false; }
            if (houseDD.SelectedIndex == -1) { houseDDErrorLabel.Visible = true; } else { houseDDErrorLabel.Visible = false; }

            if (houseDDErrorLabel.Visible || houseDDErrorLabel.Visible)
            {
                MainClass.ShowMSG("Fields with * are mandatory.", "Error...", "Error");
            }
            else
            {
                if (edit == 0) // code for SAVe
                {
                    section s = new section();

                    if (houseDD.SelectedIndex == 0)
                    {
                        s.sec_status = 1;
                    }
                    else
                    {
                        s.sec_status = 0;
                    }

                    obj.st_inserthousse(houseTxt.Text, s.sec_status);
                    obj.SubmitChanges();
                    MainClass.ShowMSG(houseTxt.Text + " added successfully.", "Success...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                }
                else // code for update
                {
                    byte stat;
                    if (houseDD.SelectedIndex == 0)
                    {
                        stat = 1;
                    }
                    else
                    {
                        stat = 0;
                    }
                    obj.st_updatehouses(houseTxt.Text, stat, houseID);

                    MainClass.ShowMSG(houseTxt.Text + " updated successfully.", "Success...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                }
            }

        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete" + houseTxt.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    obj.st_deletehouses(houseID);
                    MainClass.ShowMSG(houseTxt.Text + " deleted successfully.", "Success...", "Success");
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

        private void houseTxt_TextChanged(object sender, EventArgs e)
        {
            if (houseTxt.Text == "") { houseErrorLabel.Visible = true; } else { houseErrorLabel.Visible = false; }
        }

        private void houseDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (houseDD.SelectedIndex == -1) { houseDDErrorLabel.Visible = true; } else { houseDDErrorLabel.Visible = false; }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                houseID = Convert.ToInt32(row.Cells["houseIDGV"].Value.ToString());
                houseTxt.Text = row.Cells["houseGV"].Value.ToString();
                houseDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();


            }
        }
    }
}
