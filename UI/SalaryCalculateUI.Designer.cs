using System.Windows.Forms;

namespace Payroll_Project_2.UI
{
    partial class SalaryCalculateUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaryCalculateUI));
            this.BeginDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.LeavesLabel = new System.Windows.Forms.Label();
            this.AbsentTxtBox = new System.Windows.Forms.TextBox();
            this.HoldayTxtBox = new System.Windows.Forms.TextBox();
            this.HolidayLabel = new System.Windows.Forms.Label();
            this.OTTxtBox = new System.Windows.Forms.TextBox();
            this.OTLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmployeeIdComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SalaryCycleTxtBox = new System.Windows.Forms.TextBox();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.BeginDateLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.MonthlySalaryValueLabel = new System.Windows.Forms.Label();
            this.AllowanceValueLabel = new System.Windows.Forms.Label();
            this.TaxRateValueLabel = new System.Windows.Forms.Label();
            this.NoPayValueLabel = new System.Windows.Forms.Label();
            this.BasePayValueLabel = new System.Windows.Forms.Label();
            this.GrossPayValueLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.TaxValueLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeNameValueLabel = new System.Windows.Forms.Label();
            this.Closebtn = new System.Windows.Forms.Button();
            this.Setting = new System.Windows.Forms.Label();
            this.PaySheetPanel = new System.Windows.Forms.Panel();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SalaryFullPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.PaySheetPanel.SuspendLayout();
            this.SalaryFullPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BeginDatePicker
            // 
            this.BeginDatePicker.CustomFormat = "ddMMMMyyyy";
            this.BeginDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BeginDatePicker.Location = new System.Drawing.Point(220, 87);
            this.BeginDatePicker.Name = "BeginDatePicker";
            this.BeginDatePicker.Size = new System.Drawing.Size(120, 20);
            this.BeginDatePicker.TabIndex = 0;
            this.BeginDatePicker.ValueChanged += new System.EventHandler(this.FromDatePicker_ValueChanged);
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.CustomFormat = "ddMMMMyyyy";
            this.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDatePicker.Location = new System.Drawing.Point(220, 149);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(120, 20);
            this.EndDatePicker.TabIndex = 1;
            this.EndDatePicker.ValueChanged += new System.EventHandler(this.ToDatePicker_ValueChanged);
            // 
            // LeavesLabel
            // 
            this.LeavesLabel.AutoSize = true;
            this.LeavesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.LeavesLabel.Location = new System.Drawing.Point(26, 272);
            this.LeavesLabel.Name = "LeavesLabel";
            this.LeavesLabel.Size = new System.Drawing.Size(136, 20);
            this.LeavesLabel.TabIndex = 2;
            this.LeavesLabel.Text = "No of Absent Days";
            // 
            // AbsentTxtBox
            // 
            this.AbsentTxtBox.Location = new System.Drawing.Point(220, 273);
            this.AbsentTxtBox.Name = "AbsentTxtBox";
            this.AbsentTxtBox.Size = new System.Drawing.Size(120, 20);
            this.AbsentTxtBox.TabIndex = 3;
            this.AbsentTxtBox.Text = "0";
            this.AbsentTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // HoldayTxtBox
            // 
            this.HoldayTxtBox.Location = new System.Drawing.Point(220, 335);
            this.HoldayTxtBox.Name = "HoldayTxtBox";
            this.HoldayTxtBox.Size = new System.Drawing.Size(120, 20);
            this.HoldayTxtBox.TabIndex = 5;
            this.HoldayTxtBox.Text = "0";
            this.HoldayTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // HolidayLabel
            // 
            this.HolidayLabel.AutoSize = true;
            this.HolidayLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.HolidayLabel.Location = new System.Drawing.Point(26, 335);
            this.HolidayLabel.Name = "HolidayLabel";
            this.HolidayLabel.Size = new System.Drawing.Size(111, 20);
            this.HolidayLabel.TabIndex = 4;
            this.HolidayLabel.Text = "No of Holidays";
            // 
            // OTTxtBox
            // 
            this.OTTxtBox.Location = new System.Drawing.Point(220, 397);
            this.OTTxtBox.Name = "OTTxtBox";
            this.OTTxtBox.Size = new System.Drawing.Size(120, 20);
            this.OTTxtBox.TabIndex = 7;
            this.OTTxtBox.Text = "0";
            this.OTTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // OTLabel
            // 
            this.OTLabel.AutoSize = true;
            this.OTLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.OTLabel.Location = new System.Drawing.Point(26, 398);
            this.OTLabel.Name = "OTLabel";
            this.OTLabel.Size = new System.Drawing.Size(150, 20);
            this.OTLabel.TabIndex = 6;
            this.OTLabel.Text = "No of Over Time(hr.)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.EmployeeIdComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SalaryCycleTxtBox);
            this.panel1.Controls.Add(this.CalculateBtn);
            this.panel1.Controls.Add(this.EmployeeIDLabel);
            this.panel1.Controls.Add(this.EndDateLabel);
            this.panel1.Controls.Add(this.BeginDateLabel);
            this.panel1.Controls.Add(this.LeavesLabel);
            this.panel1.Controls.Add(this.EndDatePicker);
            this.panel1.Controls.Add(this.BeginDatePicker);
            this.panel1.Controls.Add(this.OTTxtBox);
            this.panel1.Controls.Add(this.OTLabel);
            this.panel1.Controls.Add(this.AbsentTxtBox);
            this.panel1.Controls.Add(this.HoldayTxtBox);
            this.panel1.Controls.Add(this.HolidayLabel);
            this.panel1.Location = new System.Drawing.Point(35, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 516);
            this.panel1.TabIndex = 8;
            // 
            // EmployeeIdComboBox
            // 
            this.EmployeeIdComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.EmployeeIdComboBox.FormattingEnabled = true;
            this.EmployeeIdComboBox.Location = new System.Drawing.Point(220, 17);
            this.EmployeeIdComboBox.Name = "EmployeeIdComboBox";
            this.EmployeeIdComboBox.Size = new System.Drawing.Size(120, 28);
            this.EmployeeIdComboBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(26, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Salary Cycle Date range";
            // 
            // SalaryCycleTxtBox
            // 
            this.SalaryCycleTxtBox.Location = new System.Drawing.Point(220, 211);
            this.SalaryCycleTxtBox.Name = "SalaryCycleTxtBox";
            this.SalaryCycleTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SalaryCycleTxtBox.Size = new System.Drawing.Size(120, 20);
            this.SalaryCycleTxtBox.TabIndex = 14;
            this.SalaryCycleTxtBox.Text = "0";
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.CalculateBtn.Image = ((System.Drawing.Image)(resources.GetObject("CalculateBtn.Image")));
            this.CalculateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CalculateBtn.Location = new System.Drawing.Point(26, 466);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Padding = new System.Windows.Forms.Padding(94, 0, 94, 0);
            this.CalculateBtn.Size = new System.Drawing.Size(314, 36);
            this.CalculateBtn.TabIndex = 12;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.SalaryCalculateBtn_Click);
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.EmployeeIDLabel.Location = new System.Drawing.Point(26, 20);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(95, 20);
            this.EmployeeIDLabel.TabIndex = 10;
            this.EmployeeIDLabel.Text = "Employee ID";
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.EndDateLabel.Location = new System.Drawing.Point(26, 146);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(75, 20);
            this.EndDateLabel.TabIndex = 9;
            this.EndDateLabel.Text = "End Date ";
            // 
            // BeginDateLabel
            // 
            this.BeginDateLabel.AutoSize = true;
            this.BeginDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.BeginDateLabel.Location = new System.Drawing.Point(26, 83);
            this.BeginDateLabel.Name = "BeginDateLabel";
            this.BeginDateLabel.Size = new System.Drawing.Size(88, 20);
            this.BeginDateLabel.TabIndex = 8;
            this.BeginDateLabel.Text = "Begin Date ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "Employee Name";
            // 
            // MonthlySalaryValueLabel
            // 
            this.MonthlySalaryValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MonthlySalaryValueLabel.AutoSize = true;
            this.MonthlySalaryValueLabel.Location = new System.Drawing.Point(280, 123);
            this.MonthlySalaryValueLabel.Name = "MonthlySalaryValueLabel";
            this.MonthlySalaryValueLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MonthlySalaryValueLabel.Size = new System.Drawing.Size(17, 20);
            this.MonthlySalaryValueLabel.TabIndex = 30;
            this.MonthlySalaryValueLabel.Text = "0";
            // 
            // AllowanceValueLabel
            // 
            this.AllowanceValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AllowanceValueLabel.AutoSize = true;
            this.AllowanceValueLabel.Location = new System.Drawing.Point(280, 185);
            this.AllowanceValueLabel.Name = "AllowanceValueLabel";
            this.AllowanceValueLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AllowanceValueLabel.Size = new System.Drawing.Size(17, 20);
            this.AllowanceValueLabel.TabIndex = 24;
            this.AllowanceValueLabel.Text = "0";
            // 
            // TaxRateValueLabel
            // 
            this.TaxRateValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TaxRateValueLabel.AutoSize = true;
            this.TaxRateValueLabel.Location = new System.Drawing.Point(280, 247);
            this.TaxRateValueLabel.Name = "TaxRateValueLabel";
            this.TaxRateValueLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TaxRateValueLabel.Size = new System.Drawing.Size(17, 20);
            this.TaxRateValueLabel.TabIndex = 32;
            this.TaxRateValueLabel.Text = "0";
            // 
            // NoPayValueLabel
            // 
            this.NoPayValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NoPayValueLabel.AutoSize = true;
            this.NoPayValueLabel.Location = new System.Drawing.Point(280, 309);
            this.NoPayValueLabel.Name = "NoPayValueLabel";
            this.NoPayValueLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NoPayValueLabel.Size = new System.Drawing.Size(17, 20);
            this.NoPayValueLabel.TabIndex = 40;
            this.NoPayValueLabel.Text = "0";
            // 
            // BasePayValueLabel
            // 
            this.BasePayValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BasePayValueLabel.AutoSize = true;
            this.BasePayValueLabel.Location = new System.Drawing.Point(280, 371);
            this.BasePayValueLabel.Name = "BasePayValueLabel";
            this.BasePayValueLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BasePayValueLabel.Size = new System.Drawing.Size(17, 20);
            this.BasePayValueLabel.TabIndex = 42;
            this.BasePayValueLabel.Text = "0";
            // 
            // GrossPayValueLabel
            // 
            this.GrossPayValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GrossPayValueLabel.AutoSize = true;
            this.GrossPayValueLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.GrossPayValueLabel.Location = new System.Drawing.Point(278, 433);
            this.GrossPayValueLabel.Name = "GrossPayValueLabel";
            this.GrossPayValueLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GrossPayValueLabel.Size = new System.Drawing.Size(45, 20);
            this.GrossPayValueLabel.TabIndex = 44;
            this.GrossPayValueLabel.Text = "0000";
            this.GrossPayValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 123);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(114, 20);
            this.label18.TabIndex = 25;
            this.label18.Text = "Monthly Salary";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(15, 185);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 20);
            this.label20.TabIndex = 27;
            this.label20.Text = "Allowance";
            // 
            // TaxValueLabel
            // 
            this.TaxValueLabel.AutoSize = true;
            this.TaxValueLabel.Location = new System.Drawing.Point(15, 247);
            this.TaxValueLabel.Name = "TaxValueLabel";
            this.TaxValueLabel.Size = new System.Drawing.Size(155, 20);
            this.TaxValueLabel.TabIndex = 33;
            this.TaxValueLabel.Text = "Government Tax Rate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 20);
            this.label10.TabIndex = 41;
            this.label10.Text = "No Pay Value";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(15, 371);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(111, 20);
            this.label26.TabIndex = 43;
            this.label26.Text = "Base Pay Value";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label28.Location = new System.Drawing.Point(15, 433);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(120, 20);
            this.label28.TabIndex = 45;
            this.label28.Text = "Gross Pay Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 31);
            this.label1.TabIndex = 47;
            this.label1.Text = "Salary Report";
            // 
            // EmployeeNameValueLabel
            // 
            this.EmployeeNameValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EmployeeNameValueLabel.AutoSize = true;
            this.EmployeeNameValueLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EmployeeNameValueLabel.Location = new System.Drawing.Point(280, 61);
            this.EmployeeNameValueLabel.Name = "EmployeeNameValueLabel";
            this.EmployeeNameValueLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmployeeNameValueLabel.Size = new System.Drawing.Size(17, 20);
            this.EmployeeNameValueLabel.TabIndex = 19;
            this.EmployeeNameValueLabel.Text = "0";
            this.EmployeeNameValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Closebtn
            // 
            this.Closebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Closebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Closebtn.BackgroundImage")));
            this.Closebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Closebtn.FlatAppearance.BorderSize = 0;
            this.Closebtn.Location = new System.Drawing.Point(331, 3);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(23, 23);
            this.Closebtn.TabIndex = 22;
            this.Closebtn.UseVisualStyleBackColor = true;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // Setting
            // 
            this.Setting.AutoSize = true;
            this.Setting.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.Setting.Location = new System.Drawing.Point(30, 26);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(287, 45);
            this.Setting.TabIndex = 18;
            this.Setting.Text = "Salary Calculation";
            // 
            // PaySheetPanel
            // 
            this.PaySheetPanel.BackColor = System.Drawing.Color.Transparent;
            this.PaySheetPanel.Controls.Add(this.SaveBtn);
            this.PaySheetPanel.Controls.Add(this.Closebtn);
            this.PaySheetPanel.Controls.Add(this.label1);
            this.PaySheetPanel.Controls.Add(this.GrossPayValueLabel);
            this.PaySheetPanel.Controls.Add(this.BasePayValueLabel);
            this.PaySheetPanel.Controls.Add(this.NoPayValueLabel);
            this.PaySheetPanel.Controls.Add(this.TaxRateValueLabel);
            this.PaySheetPanel.Controls.Add(this.AllowanceValueLabel);
            this.PaySheetPanel.Controls.Add(this.MonthlySalaryValueLabel);
            this.PaySheetPanel.Controls.Add(this.label13);
            this.PaySheetPanel.Controls.Add(this.label28);
            this.PaySheetPanel.Controls.Add(this.label26);
            this.PaySheetPanel.Controls.Add(this.label10);
            this.PaySheetPanel.Controls.Add(this.TaxValueLabel);
            this.PaySheetPanel.Controls.Add(this.EmployeeNameValueLabel);
            this.PaySheetPanel.Controls.Add(this.label20);
            this.PaySheetPanel.Controls.Add(this.label18);
            this.PaySheetPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.PaySheetPanel.Location = new System.Drawing.Point(534, 74);
            this.PaySheetPanel.Name = "PaySheetPanel";
            this.PaySheetPanel.Size = new System.Drawing.Size(357, 516);
            this.PaySheetPanel.TabIndex = 16;
            this.PaySheetPanel.Visible = false;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.SaveBtn.Image = ((System.Drawing.Image)(resources.GetObject("SaveBtn.Image")));
            this.SaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveBtn.Location = new System.Drawing.Point(19, 477);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Padding = new System.Windows.Forms.Padding(70, 0, 9, 0);
            this.SaveBtn.Size = new System.Drawing.Size(314, 36);
            this.SaveBtn.TabIndex = 16;
            this.SaveBtn.Text = "     Save to database";
            this.SaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // SalaryFullPanel
            // 
            this.SalaryFullPanel.Controls.Add(this.PaySheetPanel);
            this.SalaryFullPanel.Controls.Add(this.pictureBox1);
            this.SalaryFullPanel.Controls.Add(this.panel1);
            this.SalaryFullPanel.Location = new System.Drawing.Point(0, 0);
            this.SalaryFullPanel.Name = "SalaryFullPanel";
            this.SalaryFullPanel.Size = new System.Drawing.Size(930, 761);
            this.SalaryFullPanel.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(728, 592);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // SalaryCalculateUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Setting);
            this.Controls.Add(this.SalaryFullPanel);
            this.Name = "SalaryCalculateUI";
            this.Size = new System.Drawing.Size(946, 761);
            this.Load += new System.EventHandler(this.SalaryCalculate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PaySheetPanel.ResumeLayout(false);
            this.PaySheetPanel.PerformLayout();
            this.SalaryFullPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker BeginDatePicker;
        private DateTimePicker EndDatePicker;
        private Label LeavesLabel;
        private TextBox AbsentTxtBox;
        private TextBox HoldayTxtBox;
        private Label HolidayLabel;
        private TextBox OTTxtBox;
        private Label OTLabel;
        private Panel panel1;
        private Label EndDateLabel;
        private Label BeginDateLabel;
        private Label EmployeeIDLabel;
        private Button CalculateBtn;
        private Label MonthlySalaryValueLabel;
        private Label label20;
        private Label label18;
        private Label AllowanceValueLabel;
        private Label label13;
        private Label EmployeeNameValueLabel;
        private Label label28;
        private Label GrossPayValueLabel;
        private Label label26;
        private Label BasePayValueLabel;
        private Label label10;
        private Label NoPayValueLabel;
        private Label TaxValueLabel;
        private Label TaxRateValueLabel;
        private Label label1;
        private Label label2;
        private TextBox SalaryCycleTxtBox;
        private ComboBox EmployeeIdComboBox;
        private Label Setting;
        private Button Closebtn;
        private Panel PaySheetPanel;
        private Panel SalaryFullPanel;
        private PictureBox pictureBox1;
        private Button SaveBtn;
    }
}
