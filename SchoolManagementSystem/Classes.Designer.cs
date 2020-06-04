namespace SchoolManagementSystem
{
    partial class Classes
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
            this.label1 = new System.Windows.Forms.Label();
            this.classnameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusDD = new System.Windows.Forms.ComboBox();
            this.classNameErrorLabel = new System.Windows.Forms.Label();
            this.levlErrorLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.levelDD = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelidGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LEvelGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(253, 537);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.levelDD);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.statusDD);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.classnameTxt);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.classNameErrorLabel);
            this.panel6.Controls.Add(this.levlErrorLabel);
            this.panel6.Size = new System.Drawing.Size(253, 476);
            this.panel6.Controls.SetChildIndex(this.levlErrorLabel, 0);
            this.panel6.Controls.SetChildIndex(this.classNameErrorLabel, 0);
            this.panel6.Controls.SetChildIndex(this.label1, 0);
            this.panel6.Controls.SetChildIndex(this.classnameTxt, 0);
            this.panel6.Controls.SetChildIndex(this.label2, 0);
            this.panel6.Controls.SetChildIndex(this.statusDD, 0);
            this.panel6.Controls.SetChildIndex(this.label3, 0);
            this.panel6.Controls.SetChildIndex(this.levelDD, 0);
            this.panel6.Controls.SetChildIndex(this.label5, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(550, 537);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Size = new System.Drawing.Size(550, 476);
            this.panel5.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // stfname
            // 
            this.stfname.Size = new System.Drawing.Size(0, 15);
            this.stfname.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Class Name";
            // 
            // classnameTxt
            // 
            this.classnameTxt.Location = new System.Drawing.Point(15, 74);
            this.classnameTxt.Name = "classnameTxt";
            this.classnameTxt.Size = new System.Drawing.Size(213, 23);
            this.classnameTxt.TabIndex = 2;
            this.classnameTxt.TextChanged += new System.EventHandler(this.classTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Level";
            // 
            // statusDD
            // 
            this.statusDD.FormattingEnabled = true;
            this.statusDD.Items.AddRange(new object[] {
            "Active",
            "In-active"});
            this.statusDD.Location = new System.Drawing.Point(15, 168);
            this.statusDD.Name = "statusDD";
            this.statusDD.Size = new System.Drawing.Size(213, 23);
            this.statusDD.TabIndex = 6;
            this.statusDD.SelectedIndexChanged += new System.EventHandler(this.statusDD_SelectedIndexChanged);
            // 
            // classNameErrorLabel
            // 
            this.classNameErrorLabel.AutoSize = true;
            this.classNameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classNameErrorLabel.Location = new System.Drawing.Point(213, 55);
            this.classNameErrorLabel.Name = "classNameErrorLabel";
            this.classNameErrorLabel.Size = new System.Drawing.Size(15, 19);
            this.classNameErrorLabel.TabIndex = 21;
            this.classNameErrorLabel.Text = "*";
            this.classNameErrorLabel.Visible = false;
            // 
            // levlErrorLabel
            // 
            this.levlErrorLabel.AutoSize = true;
            this.levlErrorLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levlErrorLabel.Location = new System.Drawing.Point(213, 100);
            this.levlErrorLabel.Name = "levlErrorLabel";
            this.levlErrorLabel.Size = new System.Drawing.Size(15, 19);
            this.levlErrorLabel.TabIndex = 22;
            this.levlErrorLabel.Text = "*";
            this.levlErrorLabel.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 423);
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
            this.classIDGV,
            this.ClassNameGV,
            this.levelidGV,
            this.LEvelGV,
            this.StatusGV});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(544, 401);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Status";
            // 
            // levelDD
            // 
            this.levelDD.FormattingEnabled = true;
            this.levelDD.Items.AddRange(new object[] {
            "Active",
            "In-active"});
            this.levelDD.Location = new System.Drawing.Point(15, 122);
            this.levelDD.Name = "levelDD";
            this.levelDD.Size = new System.Drawing.Size(213, 23);
            this.levelDD.TabIndex = 24;
            this.levelDD.SelectedIndexChanged += new System.EventHandler(this.levelDD_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(213, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "*";
            this.label5.Visible = false;
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.HeaderText = "SNO";
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 56;
            // 
            // classIDGV
            // 
            this.classIDGV.HeaderText = "Class ID";
            this.classIDGV.Name = "classIDGV";
            this.classIDGV.ReadOnly = true;
            this.classIDGV.Visible = false;
            // 
            // ClassNameGV
            // 
            this.ClassNameGV.HeaderText = "Class";
            this.ClassNameGV.Name = "ClassNameGV";
            this.ClassNameGV.ReadOnly = true;
            // 
            // levelidGV
            // 
            this.levelidGV.HeaderText = "LEvelID";
            this.levelidGV.Name = "levelidGV";
            this.levelidGV.ReadOnly = true;
            this.levelidGV.Visible = false;
            // 
            // LEvelGV
            // 
            this.LEvelGV.HeaderText = "Level";
            this.LEvelGV.Name = "LEvelGV";
            this.LEvelGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // Classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 537);
            this.Name = "Classes";
            this.Text = "Classes";
            this.Load += new System.EventHandler(this.Classes_Load);
            this.leftPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox statusDD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox classnameTxt;
        private System.Windows.Forms.Label classNameErrorLabel;
        private System.Windows.Forms.Label levlErrorLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox levelDD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn classIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelidGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn LEvelGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
        // private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
    }
}