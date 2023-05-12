using Payroll_Project_2.Backend;
using System;
using System.Windows.Forms;

namespace Payroll_Project_2.UI
{
    public partial class SalaryCalculateUI : UserControl
    {
        Salary salary = null;

        public SalaryCalculateUI()
        {
            InitializeComponent();
        }

        private void SalaryCalculate_Load(object sender, System.EventArgs e)
        {
            EmployeeIdComboBox.DataSource = new EmployeeDataAccess().GetEmployeeIds();

        }

        private void SalaryCalculateBtn_Click(object sender, EventArgs e)
        {
            int validsalaryCycleDateRange = new SettingDataAccess().GetSettingValue().Date_Range;
            int Id = int.Parse(EmployeeIdComboBox.Text);
            int salary_Cycle_Date_Range = int.Parse(SalaryCycleTxtBox.Text);
            decimal no_of_Over_time_Hours = Decimal.Parse(OTTxtBox.Text);
            decimal no_of_Absent_Days = Decimal.Parse(AbsentTxtBox.Text);
            decimal no_of_Holidays = Decimal.Parse(HoldayTxtBox.Text);
            DateTime Salary_Paid_Date = BeginDatePicker.Value;

            if (salary_Cycle_Date_Range != validsalaryCycleDateRange)
            {
                MessageBox.Show("Enter correct Salary Cycle Date Range " + validsalaryCycleDateRange);
                SalaryCycleTxtBox.Clear();
                SalaryCycleTxtBox.Focus();
                return;
            }

            salary = new Salary(Id, Salary_Paid_Date, no_of_Over_time_Hours, no_of_Absent_Days, no_of_Holidays);

            EmployeeNameValueLabel.Text = salary.Name.ToString().TrimEnd().ToUpperInvariant();
            NoPayValueLabel.Text = salary.No_Pay_Value.ToString();
            BasePayValueLabel.Text = salary.Base_Pay_Value.ToString();
            GrossPayValueLabel.Text = salary.Gross_Pay_Value.ToString();
            PaySheetPanel.Visible = true;

        }

        private void FromDatePicker_ValueChanged(object sender, EventArgs e)
        {
            int validBeginDate = new SettingDataAccess().GetSettingValue().Begin_Date;

            if (int.Parse(BeginDatePicker.Value.ToString("dd")) != validBeginDate)
            {
                MessageBox.Show("Wrong Begin Date " + BeginDatePicker.Value.Date.ToString("dd") + " Please set it to " + validBeginDate);

            }

            EndDatePicker.Value = BeginDatePicker.Value.AddMonths(1).AddDays(-1);
        }

        private void ToDatePicker_ValueChanged(object sender, EventArgs e)
        {
            int validEndDate = new SettingDataAccess().GetSettingValue().End_Date;

            if (int.Parse(EndDatePicker.Value.ToString("dd")) != validEndDate)
            {
                MessageBox.Show("Wrong End Date " + EndDatePicker.Value.Date.ToString("dd") + " Please set it to " + validEndDate);

            }

            BeginDatePicker.Value = EndDatePicker.Value.AddMonths(-1).AddDays(1);

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            new SalaryDataAccess().CreateSalary(salary);
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            PaySheetPanel.Visible = false;
        }

        private void PaySheetPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
