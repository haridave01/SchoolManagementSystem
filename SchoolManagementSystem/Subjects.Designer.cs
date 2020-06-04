namespace SchoolManagementSystem
{
    partial class Subjects
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
            this.label1 = new System.Windows.Forms.Label();
            this.subjectTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classidGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectErrorLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.classDD = new System.Windows.Forms.ComboBox();
            this.belongsErrorLabel = new System.Windows.Forms.Label();
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
            this.panel6.Controls.Add(this.belongsErrorLabel);
            this.panel6.Controls.Add(this.classDD);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.subjectErrorLabel);
            this.panel6.Controls.Add(this.subjectTxt);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Size = new System.Drawing.Size(253, 476);
            this.panel6.Controls.SetChildIndex(this.label1, 0);
            this.panel6.Controls.SetChildIndex(this.subjectTxt, 0);
            this.panel6.Controls.SetChildIndex(this.subjectErrorLabel, 0);
            this.panel6.Controls.SetChildIndex(this.label2, 0);
            this.panel6.Controls.SetChildIndex(this.classDD, 0);
            this.panel6.Controls.SetChildIndex(this.belongsErrorLabel, 0);
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
            this.label1.Location = new System.Drawing.Point(9, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subject";
            // 
            // subjectTxt
            // 
            this.subjectTxt.Enabled = false;
            this.subjectTxt.Location = new System.Drawing.Point(13, 93);
            this.subjectTxt.Name = "subjectTxt";
            this.subjectTxt.Size = new System.Drawing.Size(212, 23);
            this.subjectTxt.TabIndex = 2;
            this.subjectTxt.TextChanged += new System.EventHandler(this.subjectTxt_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 423);
            this.groupBox2.TabIndex = 4;
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
            this.classidGV,
            this.subjectIDGV,
            this.subjectGV,
            this.ClassGV});
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
            this.dataGridView1.Size = new System.Drawing.Size(544, 401);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.HeaderText = "SNO";
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 56;
            // 
            // classidGV
            // 
            this.classidGV.HeaderText = "ClassID";
            this.classidGV.Name = "classidGV";
            this.classidGV.ReadOnly = true;
            this.classidGV.Visible = false;
            // 
            // subjectIDGV
            // 
            this.subjectIDGV.HeaderText = "Subject ID";
            this.subjectIDGV.Name = "subjectIDGV";
            this.subjectIDGV.ReadOnly = true;
            this.subjectIDGV.Visible = false;
            // 
            // subjectGV
            // 
            this.subjectGV.HeaderText = "Subject";
            this.subjectGV.Name = "subjectGV";
            this.subjectGV.ReadOnly = true;
            // 
            // ClassGV
            // 
            this.ClassGV.HeaderText = "Class";
            this.ClassGV.Name = "ClassGV";
            this.ClassGV.ReadOnly = true;
            // 
            // subjectErrorLabel
            // 
            this.subjectErrorLabel.AutoSize = true;
            this.subjectErrorLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectErrorLabel.Location = new System.Drawing.Point(210, 70);
            this.subjectErrorLabel.Name = "subjectErrorLabel";
            this.subjectErrorLabel.Size = new System.Drawing.Size(15, 19);
            this.subjectErrorLabel.TabIndex = 22;
            this.subjectErrorLabel.Text = "*";
            this.subjectErrorLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Class it belongs";
            // 
            // classDD
            // 
            this.classDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classDD.Enabled = false;
            this.classDD.FormattingEnabled = true;
            this.classDD.Location = new System.Drawing.Point(15, 137);
            this.classDD.Name = "classDD";
            this.classDD.Size = new System.Drawing.Size(210, 23);
            this.classDD.TabIndex = 24;
            this.classDD.SelectedIndexChanged += new System.EventHandler(this.classDD_SelectedIndexChanged);
            // 
            // belongsErrorLabel
            // 
            this.belongsErrorLabel.AutoSize = true;
            this.belongsErrorLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.belongsErrorLabel.Location = new System.Drawing.Point(210, 119);
            this.belongsErrorLabel.Name = "belongsErrorLabel";
            this.belongsErrorLabel.Size = new System.Drawing.Size(15, 19);
            this.belongsErrorLabel.TabIndex = 25;
            this.belongsErrorLabel.Text = "*";
            this.belongsErrorLabel.Visible = false;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 537);
            this.Name = "Subjects";
            this.Text = "Subjects";
            this.Load += new System.EventHandler(this.Subjects_Load);
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

        private System.Windows.Forms.TextBox subjectTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label subjectErrorLabel;
        private System.Windows.Forms.ComboBox classDD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn classidGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassGV;
        private System.Windows.Forms.Label belongsErrorLabel;

    }
}