namespace SchoolManagementSystem
{
    partial class Settings
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dbTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datasourceTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.isCB = new System.Windows.Forms.CheckBox();
            this.dserrorLabel = new System.Windows.Forms.Label();
            this.dberrorlabel = new System.Windows.Forms.Label();
            this.usernameerroelabel = new System.Windows.Forms.Label();
            this.passworderrorlabel = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(253, 515);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.passworderrorlabel);
            this.panel6.Controls.Add(this.usernameerroelabel);
            this.panel6.Controls.Add(this.dberrorlabel);
            this.panel6.Controls.Add(this.dserrorLabel);
            this.panel6.Controls.Add(this.isCB);
            this.panel6.Controls.Add(this.dbTxt);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.datasourceTxt);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.saveBtn);
            this.panel6.Controls.Add(this.passwordTxt);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.usernameTxt);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Size = new System.Drawing.Size(253, 454);
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(543, 515);
            // 
            // panel5
            // 
            this.panel5.Size = new System.Drawing.Size(543, 454);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(543, 61);
            // 
            // saveBtn
            // 
            this.saveBtn.FlatAppearance.BorderSize = 2;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(24, 353);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(208, 40);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Text = "&SAVE";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(24, 271);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(208, 23);
            this.passwordTxt.TabIndex = 8;
            this.passwordTxt.UseSystemPasswordChar = true;
            this.passwordTxt.TextChanged += new System.EventHandler(this.passwordTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(24, 217);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(208, 23);
            this.usernameTxt.TabIndex = 6;
            this.usernameTxt.TextChanged += new System.EventHandler(this.usernameTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // dbTxt
            // 
            this.dbTxt.Location = new System.Drawing.Point(24, 159);
            this.dbTxt.Name = "dbTxt";
            this.dbTxt.Size = new System.Drawing.Size(208, 23);
            this.dbTxt.TabIndex = 13;
            this.dbTxt.TextChanged += new System.EventHandler(this.dbTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Database";
            // 
            // datasourceTxt
            // 
            this.datasourceTxt.Location = new System.Drawing.Point(24, 105);
            this.datasourceTxt.Name = "datasourceTxt";
            this.datasourceTxt.Size = new System.Drawing.Size(208, 23);
            this.datasourceTxt.TabIndex = 11;
            this.datasourceTxt.TextChanged += new System.EventHandler(this.datasourceTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data Source";
            // 
            // isCB
            // 
            this.isCB.AutoSize = true;
            this.isCB.Location = new System.Drawing.Point(24, 319);
            this.isCB.Name = "isCB";
            this.isCB.Size = new System.Drawing.Size(125, 19);
            this.isCB.TabIndex = 14;
            this.isCB.Text = "Integrated Security";
            this.isCB.UseVisualStyleBackColor = true;
            this.isCB.CheckedChanged += new System.EventHandler(this.isCB_CheckedChanged);
            // 
            // dserrorLabel
            // 
            this.dserrorLabel.AutoSize = true;
            this.dserrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dserrorLabel.Location = new System.Drawing.Point(212, 76);
            this.dserrorLabel.Name = "dserrorLabel";
            this.dserrorLabel.Size = new System.Drawing.Size(20, 28);
            this.dserrorLabel.TabIndex = 15;
            this.dserrorLabel.Text = "*";
            this.dserrorLabel.Visible = false;
            // 
            // dberrorlabel
            // 
            this.dberrorlabel.AutoSize = true;
            this.dberrorlabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dberrorlabel.Location = new System.Drawing.Point(212, 132);
            this.dberrorlabel.Name = "dberrorlabel";
            this.dberrorlabel.Size = new System.Drawing.Size(20, 28);
            this.dberrorlabel.TabIndex = 16;
            this.dberrorlabel.Text = "*";
            this.dberrorlabel.Visible = false;
            // 
            // usernameerroelabel
            // 
            this.usernameerroelabel.AutoSize = true;
            this.usernameerroelabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameerroelabel.Location = new System.Drawing.Point(212, 185);
            this.usernameerroelabel.Name = "usernameerroelabel";
            this.usernameerroelabel.Size = new System.Drawing.Size(20, 28);
            this.usernameerroelabel.TabIndex = 17;
            this.usernameerroelabel.Text = "*";
            this.usernameerroelabel.Visible = false;
            // 
            // passworderrorlabel
            // 
            this.passworderrorlabel.AutoSize = true;
            this.passworderrorlabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passworderrorlabel.Location = new System.Drawing.Point(212, 243);
            this.passworderrorlabel.Name = "passworderrorlabel";
            this.passworderrorlabel.Size = new System.Drawing.Size(20, 28);
            this.passworderrorlabel.TabIndex = 18;
            this.passworderrorlabel.Text = "*";
            this.passworderrorlabel.Visible = false;
            // 
            // Settings
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 515);
            this.ControlBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.leftPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox dbTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox datasourceTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox isCB;
        private System.Windows.Forms.Label passworderrorlabel;
        private System.Windows.Forms.Label usernameerroelabel;
        private System.Windows.Forms.Label dberrorlabel;
        private System.Windows.Forms.Label dserrorLabel;
    }
}