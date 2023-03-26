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
            this.EmlCreateBtn = new System.Windows.Forms.Button();
            this.EmployeesDataGrid = new System.Windows.Forms.DataGridView();
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
            this.EmpDeleteBtn = new System.Windows.Forms.Button();
            this.EmpUpdateBtn = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmlCreateBtn
            // 
            this.EmlCreateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmlCreateBtn.Image = ((System.Drawing.Image)(resources.GetObject("EmlCreateBtn.Image")));
            this.EmlCreateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmlCreateBtn.Location = new System.Drawing.Point(373, 249);
            this.EmlCreateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EmlCreateBtn.Name = "EmlCreateBtn";
            this.EmlCreateBtn.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.EmlCreateBtn.Size = new System.Drawing.Size(158, 41);
            this.EmlCreateBtn.TabIndex = 0;
            this.EmlCreateBtn.Text = "    Create";
            this.EmlCreateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EmlCreateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EmlCreateBtn.UseVisualStyleBackColor = true;
            this.EmlCreateBtn.Click += new System.EventHandler(this.EmlCreateBtn_Click);
            // 
            // EmployeesDataGrid
            // 
            this.EmployeesDataGrid.AllowUserToAddRows = false;
            this.EmployeesDataGrid.AllowUserToDeleteRows = false;
            this.EmployeesDataGrid.AllowUserToOrderColumns = true;
            this.EmployeesDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.EmployeesDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EmployeesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesDataGrid.Location = new System.Drawing.Point(59, 154);
            this.EmployeesDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.EmployeesDataGrid.MultiSelect = false;
            this.EmployeesDataGrid.Name = "EmployeesDataGrid";
            this.EmployeesDataGrid.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeesDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            this.EmployeesDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeesDataGrid.RowTemplate.Height = 25;
            this.EmployeesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeesDataGrid.Size = new System.Drawing.Size(564, 245);
            this.EmployeesDataGrid.TabIndex = 3;
            this.EmployeesDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeesDataGrid_CellContentClick);
            this.EmployeesDataGrid.SelectionChanged += new System.EventHandler(this.EmployeesDataGrid_SelectionChanged);
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
            this.NameTxtBox.Location = new System.Drawing.Point(225, 43);
            this.NameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(306, 27);
            this.NameTxtBox.TabIndex = 5;
            // 
            // SalaryTxtBox
            // 
            this.SalaryTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SalaryTxtBox.Location = new System.Drawing.Point(225, 95);
            this.SalaryTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.SalaryTxtBox.Name = "SalaryTxtBox";
            this.SalaryTxtBox.Size = new System.Drawing.Size(306, 27);
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
            this.AllowanceBox.Location = new System.Drawing.Point(225, 147);
            this.AllowanceBox.Margin = new System.Windows.Forms.Padding(4);
            this.AllowanceBox.Name = "AllowanceBox";
            this.AllowanceBox.Size = new System.Drawing.Size(306, 27);
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
            this.OTTxtBox.Location = new System.Drawing.Point(225, 199);
            this.OTTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.OTTxtBox.Name = "OTTxtBox";
            this.OTTxtBox.Size = new System.Drawing.Size(306, 27);
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
            this.Setting.Location = new System.Drawing.Point(30, 26);
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
            this.groupBox1.Location = new System.Drawing.Point(59, 431);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 306);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Detail";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // EmpDeleteBtn
            // 
            this.EmpDeleteBtn.ForeColor = System.Drawing.Color.Red;
            this.EmpDeleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("EmpDeleteBtn.Image")));
            this.EmpDeleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmpDeleteBtn.Location = new System.Drawing.Point(25, 249);
            this.EmpDeleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EmpDeleteBtn.Name = "EmpDeleteBtn";
            this.EmpDeleteBtn.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.EmpDeleteBtn.Size = new System.Drawing.Size(133, 41);
            this.EmpDeleteBtn.TabIndex = 2;
            this.EmpDeleteBtn.Text = "Delete";
            this.EmpDeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EmpDeleteBtn.UseVisualStyleBackColor = true;
            this.EmpDeleteBtn.Click += new System.EventHandler(this.EmpDeleteBtn_Click);
            // 
            // EmpUpdateBtn
            // 
            this.EmpUpdateBtn.Image = ((System.Drawing.Image)(resources.GetObject("EmpUpdateBtn.Image")));
            this.EmpUpdateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmpUpdateBtn.Location = new System.Drawing.Point(199, 249);
            this.EmpUpdateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EmpUpdateBtn.Name = "EmpUpdateBtn";
            this.EmpUpdateBtn.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.EmpUpdateBtn.Size = new System.Drawing.Size(133, 41);
            this.EmpUpdateBtn.TabIndex = 1;
            this.EmpUpdateBtn.Text = "  Update";
            this.EmpUpdateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmpUpdateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EmpUpdateBtn.UseVisualStyleBackColor = true;
            this.EmpUpdateBtn.Click += new System.EventHandler(this.EmpUpdateBtn_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.Location = new System.Drawing.Point(199, 101);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(370, 27);
            this.SearchBox.TabIndex = 27;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Search by ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(728, 592);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchBtn.BackgroundImage")));
            this.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Location = new System.Drawing.Point(595, 102);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Padding = new System.Windows.Forms.Padding(5);
            this.SearchBtn.Size = new System.Drawing.Size(25, 25);
            this.SearchBtn.TabIndex = 30;
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // EmployeeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Setting);
            this.Controls.Add(this.EmployeesDataGrid);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeUI";
            this.Size = new System.Drawing.Size(946, 761);
            this.Tag = "";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button EmlCreateBtn;
        private DataGridView EmployeesDataGrid;
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
        private PictureBox pictureBox1;
        private Button EmpDeleteBtn;
        private Button EmpUpdateBtn;
        private Button SearchBtn;
    }
}
