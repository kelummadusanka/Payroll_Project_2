using Payroll_Project_2.Backend;
using System.Windows.Forms;

namespace Payroll_Project_2.UI
{
    public partial class SettingsUI : UserControl
    {
        public SettingsUI()
        {
            InitializeComponent();
        }

        private void UpdateBtn_Click(object sender, System.EventArgs e)
        {
            try
            {

                int Date_Range = int.Parse(DateRangeTxtBox.Text);
                int Begin_Date = int.Parse(SalaryBeginDateTxtBox.Text);
                int End_Date = int.Parse(SalaryEndDateTxtBox.Text);
                int No_of_Leaves = int.Parse(LeavesTxtBox.Text);
                decimal Tax_Rate = decimal.Parse(GovTaxRateTxtBox.Text);

                new SettingDataAccess().SetSettingValues(Date_Range, Begin_Date, End_Date, No_of_Leaves, Tax_Rate);
            }
            catch
            {
                MessageBox.Show("Check All Fields Again!");
            }
        }

        private void SettingsUI_Load(object sender, System.EventArgs e)
        {
            Setting setting = new SettingDataAccess().GetSettingValue();
            DateRangeTxtBox.Text = setting.Date_Range.ToString();
            SalaryBeginDateTxtBox.Text = setting.Begin_Date.ToString();
            SalaryEndDateTxtBox.Text = setting.End_Date.ToString();
            GovTaxRateTxtBox.Text = setting.Tax_Rate.ToString();
            LeavesTxtBox.Text = setting.No_of_Leaves.ToString();
        }

        private void ClearBtn_Click(object sender, System.EventArgs e)
        {
            DateRangeTxtBox.Text = "";
            SalaryBeginDateTxtBox.Text = "";
            SalaryEndDateTxtBox.Text = "";
            GovTaxRateTxtBox.Text = "";
            LeavesTxtBox.Text = "";
        }

    }
}
