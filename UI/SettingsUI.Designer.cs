using Payroll_Project_2.Properties;
using System.Windows.Forms;

namespace Payroll_Project_2.UI
{
    partial class SettingsUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsUI));
            this.Setting = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DateRangeTxtBox = new System.Windows.Forms.TextBox();
            this.GovTaxRateTxtBox = new System.Windows.Forms.TextBox();
            this.LeavesTxtBox = new System.Windows.Forms.TextBox();
            this.SalaryEndDateTxtBox = new System.Windows.Forms.TextBox();
            this.SalaryBeginDateTxtBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Setting
            // 
            this.Setting.AutoSize = true;
            this.Setting.BackColor = System.Drawing.Color.Transparent;
            this.Setting.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.Setting.ForeColor = System.Drawing.Color.White;
            this.Setting.Location = new System.Drawing.Point(69, 14);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(141, 45);
            this.Setting.TabIndex = 0;
            this.Setting.Text = "Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(9, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date Range";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(9, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cycle begin date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(9, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cycle end date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(9, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "No of leaves for an Employee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(9, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Goverment Tax Rate";
            // 
            // DateRangeTxtBox
            // 
            this.DateRangeTxtBox.BackColor = System.Drawing.Color.DimGray;
            this.DateRangeTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateRangeTxtBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.DateRangeTxtBox.ForeColor = System.Drawing.Color.White;
            this.DateRangeTxtBox.Location = new System.Drawing.Point(3, 135);
            this.DateRangeTxtBox.Name = "DateRangeTxtBox";
            this.DateRangeTxtBox.Size = new System.Drawing.Size(86, 27);
            this.DateRangeTxtBox.TabIndex = 6;
            // 
            // GovTaxRateTxtBox
            // 
            this.GovTaxRateTxtBox.BackColor = System.Drawing.Color.DimGray;
            this.GovTaxRateTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GovTaxRateTxtBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.GovTaxRateTxtBox.ForeColor = System.Drawing.Color.White;
            this.GovTaxRateTxtBox.Location = new System.Drawing.Point(2, 259);
            this.GovTaxRateTxtBox.Name = "GovTaxRateTxtBox";
            this.GovTaxRateTxtBox.Size = new System.Drawing.Size(86, 27);
            this.GovTaxRateTxtBox.TabIndex = 7;
            // 
            // LeavesTxtBox
            // 
            this.LeavesTxtBox.BackColor = System.Drawing.Color.DimGray;
            this.LeavesTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeavesTxtBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.LeavesTxtBox.ForeColor = System.Drawing.Color.White;
            this.LeavesTxtBox.Location = new System.Drawing.Point(3, 197);
            this.LeavesTxtBox.Name = "LeavesTxtBox";
            this.LeavesTxtBox.Size = new System.Drawing.Size(86, 27);
            this.LeavesTxtBox.TabIndex = 8;
            // 
            // SalaryEndDateTxtBox
            // 
            this.SalaryEndDateTxtBox.BackColor = System.Drawing.Color.DimGray;
            this.SalaryEndDateTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalaryEndDateTxtBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.SalaryEndDateTxtBox.ForeColor = System.Drawing.Color.White;
            this.SalaryEndDateTxtBox.Location = new System.Drawing.Point(3, 73);
            this.SalaryEndDateTxtBox.Name = "SalaryEndDateTxtBox";
            this.SalaryEndDateTxtBox.Size = new System.Drawing.Size(86, 27);
            this.SalaryEndDateTxtBox.TabIndex = 9;
            // 
            // SalaryBeginDateTxtBox
            // 
            this.SalaryBeginDateTxtBox.BackColor = System.Drawing.Color.DimGray;
            this.SalaryBeginDateTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalaryBeginDateTxtBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.SalaryBeginDateTxtBox.ForeColor = System.Drawing.Color.White;
            this.SalaryBeginDateTxtBox.Location = new System.Drawing.Point(3, 11);
            this.SalaryBeginDateTxtBox.Name = "SalaryBeginDateTxtBox";
            this.SalaryBeginDateTxtBox.Size = new System.Drawing.Size(86, 27);
            this.SalaryBeginDateTxtBox.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(64, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 286);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.GovTaxRateTxtBox);
            this.panel4.Controls.Add(this.LeavesTxtBox);
            this.panel4.Controls.Add(this.SalaryEndDateTxtBox);
            this.panel4.Controls.Add(this.DateRangeTxtBox);
            this.panel4.Controls.Add(this.SalaryBeginDateTxtBox);
            this.panel4.Location = new System.Drawing.Point(342, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(119, 286);
            this.panel4.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(91, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "%";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Payroll_Project_2.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(1010, 510);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.Gold;
            this.ClearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.ClearBtn.Image = ((System.Drawing.Image)(resources.GetObject("ClearBtn.Image")));
            this.ClearBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClearBtn.Location = new System.Drawing.Point(75, 417);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Padding = new System.Windows.Forms.Padding(12, 0, 9, 0);
            this.ClearBtn.Size = new System.Drawing.Size(129, 37);
            this.ClearBtn.TabIndex = 12;
            this.ClearBtn.Text = "       Clear";
            this.ClearBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Gold;
            this.UpdateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.UpdateBtn.Image = global::Payroll_Project_2.Properties.Resources.refresh__1_;
            this.UpdateBtn.Location = new System.Drawing.Point(299, 417);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Padding = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.UpdateBtn.Size = new System.Drawing.Size(131, 37);
            this.UpdateBtn.TabIndex = 11;
            this.UpdateBtn.Text = "    Update";
            this.UpdateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // SettingsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CausesValidation = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.Setting);
            this.Name = "SettingsUI";
            this.Size = new System.Drawing.Size(1184, 650);
            this.Load += new System.EventHandler(this.SettingsUI_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Setting;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox DateRangeTxtBox;
        private TextBox GovTaxRateTxtBox;
        private TextBox LeavesTxtBox;
        private TextBox SalaryEndDateTxtBox;
        private TextBox SalaryBeginDateTxtBox;
        private Button UpdateBtn;
        private Panel panel3;
        private Panel panel4;
        private Label label6;
        private Button ClearBtn;
        private PictureBox pictureBox1;
    }
}
