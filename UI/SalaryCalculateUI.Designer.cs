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
            this.SalaryFullPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Setting = new System.Windows.Forms.Label();
            this.PaySheetPanel = new System.Windows.Forms.Panel();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.GrossPayValueLabel = new System.Windows.Forms.Label();
            this.BasePayValueLabel = new System.Windows.Forms.Label();
            this.NoPayValueLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.EmployeeNameValueLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmployeeIdComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SalaryCycleTxtBox = new System.Windows.Forms.TextBox();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.BeginDateLabel = new System.Windows.Forms.Label();
            this.LeavesLabel = new System.Windows.Forms.Label();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.BeginDatePicker = new System.Windows.Forms.DateTimePicker();
            this.OTTxtBox = new System.Windows.Forms.TextBox();
            this.OTLabel = new System.Windows.Forms.Label();
            this.AbsentTxtBox = new System.Windows.Forms.TextBox();
            this.HoldayTxtBox = new System.Windows.Forms.TextBox();
            this.HolidayLabel = new System.Windows.Forms.Label();
            this.SalaryFullPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PaySheetPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalaryFullPanel
            // 
            this.SalaryFullPanel.BackColor = System.Drawing.Color.Black;
            this.SalaryFullPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalaryFullPanel.Controls.Add(this.pictureBox1);
            this.SalaryFullPanel.Controls.Add(this.Setting);
            this.SalaryFullPanel.Controls.Add(this.PaySheetPanel);
            this.SalaryFullPanel.Controls.Add(this.panel1);
            this.SalaryFullPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalaryFullPanel.Location = new System.Drawing.Point(0, 0);
            this.SalaryFullPanel.Name = "SalaryFullPanel";
            this.SalaryFullPanel.Size = new System.Drawing.Size(1184, 650);
            this.SalaryFullPanel.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Payroll_Project_2.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(1007, 512);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // Setting
            // 
            this.Setting.AutoSize = true;
            this.Setting.BackColor = System.Drawing.Color.Transparent;
            this.Setting.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.Setting.ForeColor = System.Drawing.Color.White;
            this.Setting.Location = new System.Drawing.Point(58, 13);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(287, 45);
            this.Setting.TabIndex = 18;
            this.Setting.Text = "Salary Calculation";
            // 
            // PaySheetPanel
            // 
            this.PaySheetPanel.BackColor = System.Drawing.Color.Transparent;
            this.PaySheetPanel.Controls.Add(this.SaveBtn);
            this.PaySheetPanel.Controls.Add(this.GrossPayValueLabel);
            this.PaySheetPanel.Controls.Add(this.BasePayValueLabel);
            this.PaySheetPanel.Controls.Add(this.NoPayValueLabel);
            this.PaySheetPanel.Controls.Add(this.label13);
            this.PaySheetPanel.Controls.Add(this.label28);
            this.PaySheetPanel.Controls.Add(this.label26);
            this.PaySheetPanel.Controls.Add(this.label10);
            this.PaySheetPanel.Controls.Add(this.EmployeeNameValueLabel);
            this.PaySheetPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.PaySheetPanel.ForeColor = System.Drawing.Color.White;
            this.PaySheetPanel.Location = new System.Drawing.Point(646, 26);
            this.PaySheetPanel.Name = "PaySheetPanel";
            this.PaySheetPanel.Size = new System.Drawing.Size(357, 526);
            this.PaySheetPanel.TabIndex = 16;
            this.PaySheetPanel.Visible = false;
            this.PaySheetPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PaySheetPanel_Paint);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Gold;
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.SaveBtn.ForeColor = System.Drawing.Color.Black;
            this.SaveBtn.Image = ((System.Drawing.Image)(resources.GetObject("SaveBtn.Image")));
            this.SaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveBtn.Location = new System.Drawing.Point(19, 280);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Padding = new System.Windows.Forms.Padding(70, 0, 9, 0);
            this.SaveBtn.Size = new System.Drawing.Size(314, 36);
            this.SaveBtn.TabIndex = 16;
            this.SaveBtn.Text = "     Save to database";
            this.SaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // GrossPayValueLabel
            // 
            this.GrossPayValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GrossPayValueLabel.AutoSize = true;
            this.GrossPayValueLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.GrossPayValueLabel.ForeColor = System.Drawing.Color.White;
            this.GrossPayValueLabel.Location = new System.Drawing.Point(278, 241);
            this.GrossPayValueLabel.Name = "GrossPayValueLabel";
            this.GrossPayValueLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GrossPayValueLabel.Size = new System.Drawing.Size(45, 20);
            this.GrossPayValueLabel.TabIndex = 44;
            this.GrossPayValueLabel.Text = "0000";
            this.GrossPayValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BasePayValueLabel
            // 
            this.BasePayValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BasePayValueLabel.AutoSize = true;
            this.BasePayValueLabel.ForeColor = System.Drawing.Color.White;
            this.BasePayValueLabel.Location = new System.Drawing.Point(280, 179);
            this.BasePayValueLabel.Name = "BasePayValueLabel";
            this.BasePayValueLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BasePayValueLabel.Size = new System.Drawing.Size(17, 20);
            this.BasePayValueLabel.TabIndex = 42;
            this.BasePayValueLabel.Text = "0";
            // 
            // NoPayValueLabel
            // 
            this.NoPayValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NoPayValueLabel.AutoSize = true;
            this.NoPayValueLabel.ForeColor = System.Drawing.Color.White;
            this.NoPayValueLabel.Location = new System.Drawing.Point(280, 117);
            this.NoPayValueLabel.Name = "NoPayValueLabel";
            this.NoPayValueLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NoPayValueLabel.Size = new System.Drawing.Size(17, 20);
            this.NoPayValueLabel.TabIndex = 40;
            this.NoPayValueLabel.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(15, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "Employee Name";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(15, 236);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(120, 20);
            this.label28.TabIndex = 45;
            this.label28.Text = "Gross Pay Value";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(15, 174);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(111, 20);
            this.label26.TabIndex = 43;
            this.label26.Text = "Base Pay Value";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(15, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 20);
            this.label10.TabIndex = 41;
            this.label10.Text = "No Pay Value";
            // 
            // EmployeeNameValueLabel
            // 
            this.EmployeeNameValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EmployeeNameValueLabel.AutoSize = true;
            this.EmployeeNameValueLabel.ForeColor = System.Drawing.Color.White;
            this.EmployeeNameValueLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EmployeeNameValueLabel.Location = new System.Drawing.Point(280, 66);
            this.EmployeeNameValueLabel.Name = "EmployeeNameValueLabel";
            this.EmployeeNameValueLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmployeeNameValueLabel.Size = new System.Drawing.Size(17, 20);
            this.EmployeeNameValueLabel.TabIndex = 19;
            this.EmployeeNameValueLabel.Text = "0";
            this.EmployeeNameValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.EmployeeIdComboBox.BackColor = System.Drawing.Color.DarkGray;
            this.EmployeeIdComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EmployeeIdComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.EmployeeIdComboBox.ForeColor = System.Drawing.Color.White;
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
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Salary Cycle Date range";
            // 
            // SalaryCycleTxtBox
            // 
            this.SalaryCycleTxtBox.BackColor = System.Drawing.Color.DimGray;
            this.SalaryCycleTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalaryCycleTxtBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.SalaryCycleTxtBox.ForeColor = System.Drawing.Color.White;
            this.SalaryCycleTxtBox.Location = new System.Drawing.Point(220, 206);
            this.SalaryCycleTxtBox.Name = "SalaryCycleTxtBox";
            this.SalaryCycleTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SalaryCycleTxtBox.Size = new System.Drawing.Size(120, 27);
            this.SalaryCycleTxtBox.TabIndex = 14;
            this.SalaryCycleTxtBox.Text = "0";
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.BackColor = System.Drawing.Color.Gold;
            this.CalculateBtn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.CalculateBtn.FlatAppearance.BorderSize = 0;
            this.CalculateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            this.CalculateBtn.UseVisualStyleBackColor = false;
            this.CalculateBtn.Click += new System.EventHandler(this.SalaryCalculateBtn_Click);
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.EmployeeIDLabel.ForeColor = System.Drawing.Color.White;
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
            this.EndDateLabel.ForeColor = System.Drawing.Color.White;
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
            this.BeginDateLabel.ForeColor = System.Drawing.Color.White;
            this.BeginDateLabel.Location = new System.Drawing.Point(26, 83);
            this.BeginDateLabel.Name = "BeginDateLabel";
            this.BeginDateLabel.Size = new System.Drawing.Size(88, 20);
            this.BeginDateLabel.TabIndex = 8;
            this.BeginDateLabel.Text = "Begin Date ";
            // 
            // LeavesLabel
            // 
            this.LeavesLabel.AutoSize = true;
            this.LeavesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.LeavesLabel.ForeColor = System.Drawing.Color.White;
            this.LeavesLabel.Location = new System.Drawing.Point(26, 272);
            this.LeavesLabel.Name = "LeavesLabel";
            this.LeavesLabel.Size = new System.Drawing.Size(136, 20);
            this.LeavesLabel.TabIndex = 2;
            this.LeavesLabel.Text = "No of Absent Days";
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText;
            this.EndDatePicker.CustomFormat = "ddMMMM";
            this.EndDatePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDatePicker.Location = new System.Drawing.Point(220, 144);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(120, 27);
            this.EndDatePicker.TabIndex = 1;
            this.EndDatePicker.ValueChanged += new System.EventHandler(this.ToDatePicker_ValueChanged);
            // 
            // BeginDatePicker
            // 
            this.BeginDatePicker.CalendarForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BeginDatePicker.CalendarMonthBackground = System.Drawing.Color.White;
            this.BeginDatePicker.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.BeginDatePicker.CalendarTitleForeColor = System.Drawing.Color.Chartreuse;
            this.BeginDatePicker.CalendarTrailingForeColor = System.Drawing.SystemColors.HighlightText;
            this.BeginDatePicker.CustomFormat = "ddMMMM";
            this.BeginDatePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.BeginDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BeginDatePicker.Location = new System.Drawing.Point(220, 82);
            this.BeginDatePicker.Name = "BeginDatePicker";
            this.BeginDatePicker.Size = new System.Drawing.Size(120, 27);
            this.BeginDatePicker.TabIndex = 0;
            this.BeginDatePicker.ValueChanged += new System.EventHandler(this.FromDatePicker_ValueChanged);
            // 
            // OTTxtBox
            // 
            this.OTTxtBox.BackColor = System.Drawing.Color.DimGray;
            this.OTTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OTTxtBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.OTTxtBox.ForeColor = System.Drawing.Color.White;
            this.OTTxtBox.Location = new System.Drawing.Point(220, 392);
            this.OTTxtBox.Name = "OTTxtBox";
            this.OTTxtBox.Size = new System.Drawing.Size(120, 27);
            this.OTTxtBox.TabIndex = 7;
            this.OTTxtBox.Text = "0";
            this.OTTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // OTLabel
            // 
            this.OTLabel.AutoSize = true;
            this.OTLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.OTLabel.ForeColor = System.Drawing.Color.White;
            this.OTLabel.Location = new System.Drawing.Point(26, 398);
            this.OTLabel.Name = "OTLabel";
            this.OTLabel.Size = new System.Drawing.Size(150, 20);
            this.OTLabel.TabIndex = 6;
            this.OTLabel.Text = "No of Over Time(hr.)";
            // 
            // AbsentTxtBox
            // 
            this.AbsentTxtBox.BackColor = System.Drawing.Color.DimGray;
            this.AbsentTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AbsentTxtBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.AbsentTxtBox.ForeColor = System.Drawing.Color.White;
            this.AbsentTxtBox.Location = new System.Drawing.Point(220, 268);
            this.AbsentTxtBox.Name = "AbsentTxtBox";
            this.AbsentTxtBox.Size = new System.Drawing.Size(120, 27);
            this.AbsentTxtBox.TabIndex = 3;
            this.AbsentTxtBox.Text = "0";
            this.AbsentTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // HoldayTxtBox
            // 
            this.HoldayTxtBox.BackColor = System.Drawing.Color.DimGray;
            this.HoldayTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HoldayTxtBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.HoldayTxtBox.ForeColor = System.Drawing.Color.White;
            this.HoldayTxtBox.Location = new System.Drawing.Point(220, 330);
            this.HoldayTxtBox.Name = "HoldayTxtBox";
            this.HoldayTxtBox.Size = new System.Drawing.Size(120, 27);
            this.HoldayTxtBox.TabIndex = 5;
            this.HoldayTxtBox.Text = "0";
            this.HoldayTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // HolidayLabel
            // 
            this.HolidayLabel.AutoSize = true;
            this.HolidayLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.HolidayLabel.ForeColor = System.Drawing.Color.White;
            this.HolidayLabel.Location = new System.Drawing.Point(26, 335);
            this.HolidayLabel.Name = "HolidayLabel";
            this.HolidayLabel.Size = new System.Drawing.Size(111, 20);
            this.HolidayLabel.TabIndex = 4;
            this.HolidayLabel.Text = "No of Holidays";
            // 
            // SalaryCalculateUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.SalaryFullPanel);
            this.Name = "SalaryCalculateUI";
            this.Size = new System.Drawing.Size(1184, 650);
            this.Load += new System.EventHandler(this.SalaryCalculate_Load);
            this.SalaryFullPanel.ResumeLayout(false);
            this.SalaryFullPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PaySheetPanel.ResumeLayout(false);
            this.PaySheetPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel SalaryFullPanel;
        private PictureBox pictureBox1;
        private Label Setting;
        private Panel PaySheetPanel;
        private Button SaveBtn;
        private Label GrossPayValueLabel;
        private Label BasePayValueLabel;
        private Label NoPayValueLabel;
        private Label label13;
        private Label label28;
        private Label label26;
        private Label label10;
        private Label EmployeeNameValueLabel;
        private Panel panel1;
        private ComboBox EmployeeIdComboBox;
        private Label label2;
        private TextBox SalaryCycleTxtBox;
        private Button CalculateBtn;
        private Label EmployeeIDLabel;
        private Label EndDateLabel;
        private Label BeginDateLabel;
        private Label LeavesLabel;
        private DateTimePicker EndDatePicker;
        private DateTimePicker BeginDatePicker;
        private TextBox OTTxtBox;
        private Label OTLabel;
        private TextBox AbsentTxtBox;
        private TextBox HoldayTxtBox;
        private Label HolidayLabel;
    }
}
