using System.Windows.Forms;

namespace Payroll_Project_2.UI
{
    partial class SummeryPayvaluesUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummeryPayvaluesUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BasePayValueLabel = new System.Windows.Forms.Label();
            this.NoPayValueLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GrossPayValueLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FromDataPicker = new System.Windows.Forms.DateTimePicker();
            this.ToDataPicker = new System.Windows.Forms.DateTimePicker();
            this.BeginDateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.OverallSalaryReportLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BarchartPannel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.NopayBar = new System.Windows.Forms.Button();
            this.BasepayBar = new System.Windows.Forms.Button();
            this.GroospayBar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BarchartPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.BasePayValueLabel);
            this.panel1.Controls.Add(this.NoPayValueLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.GrossPayValueLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(36, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 218);
            this.panel1.TabIndex = 26;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Payroll_Project_2.Properties.Resources.no_credit_card;
            this.pictureBox4.Location = new System.Drawing.Point(15, 166);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 37;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Payroll_Project_2.Properties.Resources.ebit;
            this.pictureBox3.Location = new System.Drawing.Point(15, 91);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Payroll_Project_2.Properties.Resources.earning;
            this.pictureBox2.Location = new System.Drawing.Point(15, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(94, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "No Pay";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BasePayValueLabel
            // 
            this.BasePayValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BasePayValueLabel.AutoSize = true;
            this.BasePayValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.BasePayValueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.BasePayValueLabel.ForeColor = System.Drawing.Color.White;
            this.BasePayValueLabel.Location = new System.Drawing.Point(314, 94);
            this.BasePayValueLabel.Name = "BasePayValueLabel";
            this.BasePayValueLabel.Size = new System.Drawing.Size(23, 28);
            this.BasePayValueLabel.TabIndex = 0;
            this.BasePayValueLabel.Text = "5";
            this.BasePayValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NoPayValueLabel
            // 
            this.NoPayValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoPayValueLabel.AutoSize = true;
            this.NoPayValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.NoPayValueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.NoPayValueLabel.ForeColor = System.Drawing.Color.White;
            this.NoPayValueLabel.Location = new System.Drawing.Point(314, 172);
            this.NoPayValueLabel.Name = "NoPayValueLabel";
            this.NoPayValueLabel.Size = new System.Drawing.Size(23, 28);
            this.NoPayValueLabel.TabIndex = 0;
            this.NoPayValueLabel.Text = "5";
            this.NoPayValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(94, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Base Pay";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GrossPayValueLabel
            // 
            this.GrossPayValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrossPayValueLabel.AutoSize = true;
            this.GrossPayValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.GrossPayValueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.GrossPayValueLabel.ForeColor = System.Drawing.Color.White;
            this.GrossPayValueLabel.Location = new System.Drawing.Point(314, 16);
            this.GrossPayValueLabel.Name = "GrossPayValueLabel";
            this.GrossPayValueLabel.Size = new System.Drawing.Size(91, 28);
            this.GrossPayValueLabel.TabIndex = 0;
            this.GrossPayValueLabel.Text = "12532.23";
            this.GrossPayValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(94, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gross Pay";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FromDataPicker
            // 
            this.FromDataPicker.CustomFormat = "MMM yyyy";
            this.FromDataPicker.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.FromDataPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDataPicker.Location = new System.Drawing.Point(16, 37);
            this.FromDataPicker.Name = "FromDataPicker";
            this.FromDataPicker.Size = new System.Drawing.Size(117, 29);
            this.FromDataPicker.TabIndex = 27;
            // 
            // ToDataPicker
            // 
            this.ToDataPicker.CustomFormat = "MMM yyyy";
            this.ToDataPicker.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.ToDataPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDataPicker.Location = new System.Drawing.Point(210, 37);
            this.ToDataPicker.Name = "ToDataPicker";
            this.ToDataPicker.Size = new System.Drawing.Size(117, 29);
            this.ToDataPicker.TabIndex = 28;
            // 
            // BeginDateLabel
            // 
            this.BeginDateLabel.AutoSize = true;
            this.BeginDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.BeginDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.BeginDateLabel.ForeColor = System.Drawing.Color.Black;
            this.BeginDateLabel.Location = new System.Drawing.Point(16, 6);
            this.BeginDateLabel.Name = "BeginDateLabel";
            this.BeginDateLabel.Size = new System.Drawing.Size(45, 20);
            this.BeginDateLabel.TabIndex = 29;
            this.BeginDateLabel.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(210, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "To";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.RefreshBtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BeginDateLabel);
            this.panel2.Controls.Add(this.ToDataPicker);
            this.panel2.Controls.Add(this.FromDataPicker);
            this.panel2.Location = new System.Drawing.Point(36, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 76);
            this.panel2.TabIndex = 32;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshBtn.BackgroundImage")));
            this.RefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshBtn.FlatAppearance.BorderSize = 0;
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBtn.Location = new System.Drawing.Point(353, 36);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(30, 30);
            this.RefreshBtn.TabIndex = 31;
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // OverallSalaryReportLabel
            // 
            this.OverallSalaryReportLabel.AutoSize = true;
            this.OverallSalaryReportLabel.BackColor = System.Drawing.Color.Transparent;
            this.OverallSalaryReportLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.OverallSalaryReportLabel.ForeColor = System.Drawing.Color.White;
            this.OverallSalaryReportLabel.Location = new System.Drawing.Point(31, 26);
            this.OverallSalaryReportLabel.Name = "OverallSalaryReportLabel";
            this.OverallSalaryReportLabel.Size = new System.Drawing.Size(260, 45);
            this.OverallSalaryReportLabel.TabIndex = 33;
            this.OverallSalaryReportLabel.Text = "Total Pay Values";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Payroll_Project_2.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(1004, 504);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // BarchartPannel
            // 
            this.BarchartPannel.BackColor = System.Drawing.Color.Transparent;
            this.BarchartPannel.Controls.Add(this.button1);
            this.BarchartPannel.Controls.Add(this.NopayBar);
            this.BarchartPannel.Controls.Add(this.BasepayBar);
            this.BarchartPannel.Controls.Add(this.GroospayBar);
            this.BarchartPannel.Location = new System.Drawing.Point(616, 214);
            this.BarchartPannel.Name = "BarchartPannel";
            this.BarchartPannel.Size = new System.Drawing.Size(462, 227);
            this.BarchartPannel.TabIndex = 62;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(5, 227);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // NopayBar
            // 
            this.NopayBar.FlatAppearance.BorderColor = System.Drawing.Color.DeepPink;
            this.NopayBar.FlatAppearance.BorderSize = 2;
            this.NopayBar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NopayBar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.NopayBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NopayBar.Location = new System.Drawing.Point(3, 167);
            this.NopayBar.Name = "NopayBar";
            this.NopayBar.Size = new System.Drawing.Size(371, 47);
            this.NopayBar.TabIndex = 2;
            this.NopayBar.UseVisualStyleBackColor = true;
            // 
            // BasepayBar
            // 
            this.BasepayBar.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.BasepayBar.FlatAppearance.BorderSize = 2;
            this.BasepayBar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BasepayBar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BasepayBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BasepayBar.Location = new System.Drawing.Point(3, 87);
            this.BasepayBar.Name = "BasepayBar";
            this.BasepayBar.Size = new System.Drawing.Size(371, 47);
            this.BasepayBar.TabIndex = 1;
            this.BasepayBar.UseVisualStyleBackColor = true;
            // 
            // GroospayBar
            // 
            this.GroospayBar.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.GroospayBar.FlatAppearance.BorderSize = 2;
            this.GroospayBar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GroospayBar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.GroospayBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroospayBar.Location = new System.Drawing.Point(3, 9);
            this.GroospayBar.Name = "GroospayBar";
            this.GroospayBar.Size = new System.Drawing.Size(371, 47);
            this.GroospayBar.TabIndex = 0;
            this.GroospayBar.UseVisualStyleBackColor = true;
            // 
            // SummeryPayvaluesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.BarchartPannel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OverallSalaryReportLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.Name = "SummeryPayvaluesUI";
            this.Size = new System.Drawing.Size(1184, 650);
            this.Load += new System.EventHandler(this.SummeryPayvaluesUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BarchartPannel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label NoPayValueLabel;
        private Label BasePayValueLabel;
        private Label label3;
        private DateTimePicker FromDataPicker;
        private DateTimePicker ToDataPicker;
        private Label BeginDateLabel;
        private Label label1;
        private Button RefreshBtn;
        private Panel panel2;
        private Label OverallSalaryReportLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label GrossPayValueLabel;
        private Label label2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Panel BarchartPannel;
        private Button GroospayBar;
        private Button NopayBar;
        private Button BasepayBar;
        private Button button1;
    }
}
