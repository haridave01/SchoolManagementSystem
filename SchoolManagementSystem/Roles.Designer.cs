﻿namespace SchoolManagementSystem
{
    partial class Roles
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
            this.roleTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusDD = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolesIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.roleErrorLabel = new System.Windows.Forms.Label();
            this.statusErrorLabel = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(253, 631);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.statusErrorLabel);
            this.panel6.Controls.Add(this.roleErrorLabel);
            this.panel6.Controls.Add(this.statusDD);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.roleTxt);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Size = new System.Drawing.Size(253, 570);
            this.panel6.Controls.SetChildIndex(this.label1, 0);
            this.panel6.Controls.SetChildIndex(this.roleTxt, 0);
            this.panel6.Controls.SetChildIndex(this.label2, 0);
            this.panel6.Controls.SetChildIndex(this.statusDD, 0);
            this.panel6.Controls.SetChildIndex(this.roleErrorLabel, 0);
            this.panel6.Controls.SetChildIndex(this.statusErrorLabel, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(1221, 631);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Size = new System.Drawing.Size(550, 570);
            this.panel5.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(1221, 61);
            // 
            // roleTxt
            // 
            this.roleTxt.Location = new System.Drawing.Point(12, 87);
            this.roleTxt.Name = "roleTxt";
            this.roleTxt.Size = new System.Drawing.Size(210, 23);
            this.roleTxt.TabIndex = 2;
            this.roleTxt.TextChanged += new System.EventHandler(this.roleTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Roles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Status";
            // 
            // statusDD
            // 
            this.statusDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusDD.FormattingEnabled = true;
            this.statusDD.Items.AddRange(new object[] {
            "Active",
            "In-active"});
            this.statusDD.Location = new System.Drawing.Point(15, 142);
            this.statusDD.Name = "statusDD";
            this.statusDD.Size = new System.Drawing.Size(207, 23);
            this.statusDD.TabIndex = 4;
            this.statusDD.SelectedIndexChanged += new System.EventHandler(this.statusDD_SelectedIndexChanged);
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
            this.rolesIDGV,
            this.RoleGV,
            this.StatusGV});
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
            this.dataGridView1.Size = new System.Drawing.Size(544, 495);
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
            // rolesIDGV
            // 
            this.rolesIDGV.HeaderText = "Roles ID";
            this.rolesIDGV.Name = "rolesIDGV";
            this.rolesIDGV.ReadOnly = true;
            this.rolesIDGV.Visible = false;
            // 
            // RoleGV
            // 
            this.RoleGV.HeaderText = "Role";
            this.RoleGV.Name = "RoleGV";
            this.RoleGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 517);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // roleErrorLabel
            // 
            this.roleErrorLabel.AutoSize = true;
            this.roleErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleErrorLabel.Location = new System.Drawing.Point(202, 58);
            this.roleErrorLabel.Name = "roleErrorLabel";
            this.roleErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.roleErrorLabel.TabIndex = 5;
            this.roleErrorLabel.Text = "*";
            this.roleErrorLabel.Visible = false;
            // 
            // statusErrorLabel
            // 
            this.statusErrorLabel.AutoSize = true;
            this.statusErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusErrorLabel.Location = new System.Drawing.Point(202, 113);
            this.statusErrorLabel.Name = "statusErrorLabel";
            this.statusErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.statusErrorLabel.TabIndex = 6;
            this.statusErrorLabel.Text = "*";
            this.statusErrorLabel.Visible = false;
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 631);
            this.Name = "Roles";
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.Roles_Load);
            this.leftPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox statusDD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox roleTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolesIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
        private System.Windows.Forms.Label statusErrorLabel;
        private System.Windows.Forms.Label roleErrorLabel;

    }
}