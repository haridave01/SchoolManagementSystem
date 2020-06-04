namespace SchoolManagementSystem
{
    partial class Shifts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.startPicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.shiftNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.shiftDD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.endPicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shiftErrorLabel = new System.Windows.Forms.Label();
            this.shiftDDerrorLabel = new System.Windows.Forms.Label();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftNumberGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(253, 633);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.shiftDDerrorLabel);
            this.panel6.Controls.Add(this.endPicker);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.shiftDD);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.shiftNameTxt);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.startPicker);
            this.panel6.Controls.Add(this.shiftErrorLabel);
            this.panel6.Size = new System.Drawing.Size(253, 572);
            this.panel6.Controls.SetChildIndex(this.shiftErrorLabel, 0);
            this.panel6.Controls.SetChildIndex(this.startPicker, 0);
            this.panel6.Controls.SetChildIndex(this.label1, 0);
            this.panel6.Controls.SetChildIndex(this.shiftNameTxt, 0);
            this.panel6.Controls.SetChildIndex(this.label2, 0);
            this.panel6.Controls.SetChildIndex(this.shiftDD, 0);
            this.panel6.Controls.SetChildIndex(this.label3, 0);
            this.panel6.Controls.SetChildIndex(this.label5, 0);
            this.panel6.Controls.SetChildIndex(this.endPicker, 0);
            this.panel6.Controls.SetChildIndex(this.shiftDDerrorLabel, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(1215, 633);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Size = new System.Drawing.Size(1203, 572);
            this.panel5.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(1215, 61);
            // 
            // startPicker
            // 
            this.startPicker.CustomFormat = "hh:mm tt";
            this.startPicker.Enabled = false;
            this.startPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startPicker.Location = new System.Drawing.Point(15, 173);
            this.startPicker.Name = "startPicker";
            this.startPicker.ShowUpDown = true;
            this.startPicker.Size = new System.Drawing.Size(211, 23);
            this.startPicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Shift Name";
            // 
            // shiftNameTxt
            // 
            this.shiftNameTxt.Enabled = false;
            this.shiftNameTxt.Location = new System.Drawing.Point(15, 75);
            this.shiftNameTxt.Name = "shiftNameTxt";
            this.shiftNameTxt.Size = new System.Drawing.Size(211, 23);
            this.shiftNameTxt.TabIndex = 3;
            this.shiftNameTxt.TextChanged += new System.EventHandler(this.shiftNameTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Shift Number";
            // 
            // shiftDD
            // 
            this.shiftDD.Enabled = false;
            this.shiftDD.FormattingEnabled = true;
            this.shiftDD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.shiftDD.Location = new System.Drawing.Point(15, 129);
            this.shiftDD.Name = "shiftDD";
            this.shiftDD.Size = new System.Drawing.Size(211, 23);
            this.shiftDD.TabIndex = 5;
            this.shiftDD.SelectedIndexChanged += new System.EventHandler(this.shiftDD_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "End Time";
            // 
            // endPicker
            // 
            this.endPicker.CustomFormat = "hh:mm tt";
            this.endPicker.Enabled = false;
            this.endPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endPicker.Location = new System.Drawing.Point(15, 228);
            this.endPicker.Name = "endPicker";
            this.endPicker.ShowUpDown = true;
            this.endPicker.Size = new System.Drawing.Size(211, 23);
            this.endPicker.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1203, 519);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.shiftIDGV,
            this.shiftNameGV,
            this.shiftNumberGV,
            this.startGV,
            this.endTimeGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1197, 497);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // shiftErrorLabel
            // 
            this.shiftErrorLabel.AutoSize = true;
            this.shiftErrorLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftErrorLabel.Location = new System.Drawing.Point(211, 56);
            this.shiftErrorLabel.Name = "shiftErrorLabel";
            this.shiftErrorLabel.Size = new System.Drawing.Size(15, 19);
            this.shiftErrorLabel.TabIndex = 23;
            this.shiftErrorLabel.Text = "*";
            this.shiftErrorLabel.Visible = false;
            // 
            // shiftDDerrorLabel
            // 
            this.shiftDDerrorLabel.AutoSize = true;
            this.shiftDDerrorLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftDDerrorLabel.Location = new System.Drawing.Point(211, 110);
            this.shiftDDerrorLabel.Name = "shiftDDerrorLabel";
            this.shiftDDerrorLabel.Size = new System.Drawing.Size(15, 19);
            this.shiftDDerrorLabel.TabIndex = 24;
            this.shiftDDerrorLabel.Text = "*";
            this.shiftDDerrorLabel.Visible = false;
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.HeaderText = "SNO";
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 56;
            // 
            // shiftIDGV
            // 
            this.shiftIDGV.HeaderText = "shiftID";
            this.shiftIDGV.Name = "shiftIDGV";
            this.shiftIDGV.ReadOnly = true;
            this.shiftIDGV.Visible = false;
            // 
            // shiftNameGV
            // 
            this.shiftNameGV.HeaderText = "Shift Name";
            this.shiftNameGV.Name = "shiftNameGV";
            this.shiftNameGV.ReadOnly = true;
            // 
            // shiftNumberGV
            // 
            this.shiftNumberGV.HeaderText = "Shift Numer";
            this.shiftNumberGV.Name = "shiftNumberGV";
            this.shiftNumberGV.ReadOnly = true;
            // 
            // startGV
            // 
            this.startGV.HeaderText = "Start Time";
            this.startGV.Name = "startGV";
            this.startGV.ReadOnly = true;
            // 
            // endTimeGV
            // 
            this.endTimeGV.HeaderText = "End time";
            this.endTimeGV.Name = "endTimeGV";
            this.endTimeGV.ReadOnly = true;
            // 
            // Shifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 633);
            this.Name = "Shifts";
            this.Text = "Shifts";
            this.leftPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startPicker;
        private System.Windows.Forms.DateTimePicker endPicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox shiftDD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox shiftNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label shiftDDerrorLabel;
        private System.Windows.Forms.Label shiftErrorLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftNumberGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn startGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeGV;
    }
}