using System.Windows.Forms;

namespace Payroll_Project_2.UI
{
    partial class EmployeeUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.SalaryTxtBox = new System.Windows.Forms.TextBox();
            this.MonSlryLebel = new System.Windows.Forms.Label();
            this.AllowanceBox = new System.Windows.Forms.TextBox();
            this.AllowanceLabel = new System.Windows.Forms.Label();
            this.OTTxtBox = new System.Windows.Forms.TextBox();
            this.OTRatesLabel = new System.Windows.Forms.Label();
            this.Setting = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EmlCreateBtn = new System.Windows.Forms.Button();
            this.EmpDeleteBtn = new System.Windows.Forms.Button();
            this.EmpUpdateBtn = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmployeesDataGrid = new System.Windows.Forms.DataGridView();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(19, 53);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(50, 20);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name";
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTxtBox.BackColor = System.Drawing.Color.DimGray;
            this.NameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTxtBox.ForeColor = System.Drawing.Color.White;
            this.NameTxtBox.Location = new System.Drawing.Point(225, 43);
            this.NameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(262, 27);
            this.NameTxtBox.TabIndex = 5;
            // 
            // SalaryTxtBox
            // 
            this.SalaryTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SalaryTxtBox.BackColor = System.Drawing.Color.DimGray;
            this.SalaryTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalaryTxtBox.ForeColor = System.Drawing.Color.White;
            this.SalaryTxtBox.Location = new System.Drawing.Point(225, 95);
            this.SalaryTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.SalaryTxtBox.Name = "SalaryTxtBox";
            this.SalaryTxtBox.Size = new System.Drawing.Size(262, 27);
            this.SalaryTxtBox.TabIndex = 7;
            // 
            // MonSlryLebel
            // 
            this.MonSlryLebel.AutoSize = true;
            this.MonSlryLebel.Location = new System.Drawing.Point(19, 102);
            this.MonSlryLebel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MonSlryLebel.Name = "MonSlryLebel";
            this.MonSlryLebel.Size = new System.Drawing.Size(114, 20);
            this.MonSlryLebel.TabIndex = 6;
            this.MonSlryLebel.Text = "Monthly Salary";
            // 
            // AllowanceBox
            // 
            this.AllowanceBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllowanceBox.BackColor = System.Drawing.Color.DimGray;
            this.AllowanceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AllowanceBox.ForeColor = System.Drawing.Color.White;
            this.AllowanceBox.Location = new System.Drawing.Point(225, 147);
            this.AllowanceBox.Margin = new System.Windows.Forms.Padding(4);
            this.AllowanceBox.Name = "AllowanceBox";
            this.AllowanceBox.Size = new System.Drawing.Size(262, 27);
            this.AllowanceBox.TabIndex = 9;
            // 
            // AllowanceLabel
            // 
            this.AllowanceLabel.AutoSize = true;
            this.AllowanceLabel.Location = new System.Drawing.Point(19, 151);
            this.AllowanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AllowanceLabel.Name = "AllowanceLabel";
            this.AllowanceLabel.Size = new System.Drawing.Size(79, 20);
            this.AllowanceLabel.TabIndex = 8;
            this.AllowanceLabel.Text = "Allowance";
            // 
            // OTTxtBox
            // 
            this.OTTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OTTxtBox.BackColor = System.Drawing.Color.DimGray;
            this.OTTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OTTxtBox.ForeColor = System.Drawing.Color.White;
            this.OTTxtBox.Location = new System.Drawing.Point(225, 199);
            this.OTTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.OTTxtBox.Name = "OTTxtBox";
            this.OTTxtBox.Size = new System.Drawing.Size(262, 27);
            this.OTTxtBox.TabIndex = 11;
            // 
            // OTRatesLabel
            // 
            this.OTRatesLabel.AutoSize = true;
            this.OTRatesLabel.Location = new System.Drawing.Point(19, 200);
            this.OTRatesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OTRatesLabel.Name = "OTRatesLabel";
            this.OTRatesLabel.Size = new System.Drawing.Size(114, 20);
            this.OTRatesLabel.TabIndex = 10;
            this.OTRatesLabel.Text = "Over Time rate ";
            // 
            // Setting
            // 
            this.Setting.AutoSize = true;
            this.Setting.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.Setting.ForeColor = System.Drawing.Color.White;
            this.Setting.Location = new System.Drawing.Point(49, 26);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(166, 45);
            this.Setting.TabIndex = 24;
            this.Setting.Text = "Employee";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NameTxtBox);
            this.groupBox1.Controls.Add(this.EmlCreateBtn);
            this.groupBox1.Controls.Add(this.OTTxtBox);
            this.groupBox1.Controls.Add(this.NameLabel);
            this.groupBox1.Controls.Add(this.OTRatesLabel);
            this.groupBox1.Controls.Add(this.MonSlryLebel);
            this.groupBox1.Controls.Add(this.AllowanceBox);
            this.groupBox1.Controls.Add(this.EmpDeleteBtn);
            this.groupBox1.Controls.Add(this.EmpUpdateBtn);
            this.groupBox1.Controls.Add(this.SalaryTxtBox);
            this.groupBox1.Controls.Add(this.AllowanceLabel);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(617, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 318);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Detail";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // EmlCreateBtn
            // 
            this.EmlCreateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmlCreateBtn.BackColor = System.Drawing.Color.Gold;
            this.EmlCreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmlCreateBtn.ForeColor = System.Drawing.Color.Black;
            this.EmlCreateBtn.Image = ((System.Drawing.Image)(resources.GetObject("EmlCreateBtn.Image")));
            this.EmlCreateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmlCreateBtn.Location = new System.Drawing.Point(351, 258);
            this.EmlCreateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EmlCreateBtn.Name = "EmlCreateBtn";
            this.EmlCreateBtn.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.EmlCreateBtn.Size = new System.Drawing.Size(136, 32);
            this.EmlCreateBtn.TabIndex = 0;
            this.EmlCreateBtn.Text = "    Create";
            this.EmlCreateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EmlCreateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EmlCreateBtn.UseVisualStyleBackColor = false;
            this.EmlCreateBtn.Click += new System.EventHandler(this.EmlCreateBtn_Click);
            // 
            // EmpDeleteBtn
            // 
            this.EmpDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpDeleteBtn.ForeColor = System.Drawing.Color.Red;
            this.EmpDeleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmpDeleteBtn.Location = new System.Drawing.Point(23, 258);
            this.EmpDeleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EmpDeleteBtn.Name = "EmpDeleteBtn";
            this.EmpDeleteBtn.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.EmpDeleteBtn.Size = new System.Drawing.Size(133, 32);
            this.EmpDeleteBtn.TabIndex = 2;
            this.EmpDeleteBtn.Text = "Delete";
            this.EmpDeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EmpDeleteBtn.UseVisualStyleBackColor = true;
            this.EmpDeleteBtn.Click += new System.EventHandler(this.EmpDeleteBtn_Click);
            // 
            // EmpUpdateBtn
            // 
            this.EmpUpdateBtn.BackColor = System.Drawing.Color.Gold;
            this.EmpUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpUpdateBtn.ForeColor = System.Drawing.Color.Black;
            this.EmpUpdateBtn.Image = ((System.Drawing.Image)(resources.GetObject("EmpUpdateBtn.Image")));
            this.EmpUpdateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmpUpdateBtn.Location = new System.Drawing.Point(183, 258);
            this.EmpUpdateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EmpUpdateBtn.Name = "EmpUpdateBtn";
            this.EmpUpdateBtn.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.EmpUpdateBtn.Size = new System.Drawing.Size(133, 32);
            this.EmpUpdateBtn.TabIndex = 1;
            this.EmpUpdateBtn.Text = "  Update";
            this.EmpUpdateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmpUpdateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EmpUpdateBtn.UseVisualStyleBackColor = false;
            this.EmpUpdateBtn.Click += new System.EventHandler(this.EmpUpdateBtn_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.BackColor = System.Drawing.Color.DimGray;
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBox.ForeColor = System.Drawing.Color.White;
            this.SearchBox.Location = new System.Drawing.Point(199, 101);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(364, 27);
            this.SearchBox.TabIndex = 27;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 26;
            this.label3.Text = "Search by ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // EmployeesDataGrid
            // 
            this.EmployeesDataGrid.AllowUserToAddRows = false;
            this.EmployeesDataGrid.AllowUserToDeleteRows = false;
            this.EmployeesDataGrid.AllowUserToResizeRows = false;
            this.EmployeesDataGrid.BackgroundColor = System.Drawing.Color.Black;
            this.EmployeesDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeesDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.EmployeesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeesDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeesDataGrid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EmployeesDataGrid.Location = new System.Drawing.Point(59, 177);
            this.EmployeesDataGrid.MultiSelect = false;
            this.EmployeesDataGrid.Name = "EmployeesDataGrid";
            this.EmployeesDataGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeesDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.EmployeesDataGrid.RowHeadersVisible = false;
            this.EmployeesDataGrid.RowHeadersWidth = 50;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.EmployeesDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.EmployeesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeesDataGrid.Size = new System.Drawing.Size(504, 305);
            this.EmployeesDataGrid.TabIndex = 31;
            this.EmployeesDataGrid.SelectionChanged += new System.EventHandler(this.EmployeesDataGrid_SelectionChanged);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchBtn.BackgroundImage")));
            this.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Location = new System.Drawing.Point(595, 98);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Padding = new System.Windows.Forms.Padding(5);
            this.SearchBtn.Size = new System.Drawing.Size(25, 25);
            this.SearchBtn.TabIndex = 30;
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Payroll_Project_2.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(1009, 517);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // EmployeeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EmployeesDataGrid);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Setting);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeUI";
            this.Size = new System.Drawing.Size(1184, 650);
            this.Tag = "";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button EmlCreateBtn;
        private Label NameLabel;
        private TextBox NameTxtBox;
        private TextBox SalaryTxtBox;
        private Label MonSlryLebel;
        private TextBox AllowanceBox;
        private Label AllowanceLabel;
        private TextBox OTTxtBox;
        private Label OTRatesLabel;
        private Label Setting;
        private GroupBox groupBox1;
        private TextBox SearchBox;
        private Label label3;
        private Button EmpDeleteBtn;
        private Button EmpUpdateBtn;
        private Button SearchBtn;
        private DataGridView EmployeesDataGrid;
        private PictureBox pictureBox1;
    }
}
