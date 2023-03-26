using Payroll_Project_2.UI;
using System;
using System.Windows.Forms;

namespace Payroll_Project_2
{
    public partial class Grifindo : Form
    {
        public Grifindo()
        {
            InitializeComponent();
        }



        private void ChangeBtnBar(Button button)
        {
            Buttonbar.Top = button.Top + button.Height * 20 / 100;
            Buttonbar.Height = button.Height * 60 / 100;

        }
        private void ChangeSubsalaryBar(Button button)
        {
            SubsalaryBar.Top = button.Top + button.Height * 25 / 100;
            SubsalaryBar.Height = button.Height * 50 / 100;

        }

        private void ShowDropDownMenu()
        {
            salaryDropDownPannel.Visible = !salaryDropDownPannel.Visible;
        }

        private void HideDropDownMenu()
        {
            salaryDropDownPannel.Visible = false;
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            HideDropDownMenu();
            ChangeBtnBar(buttonHome);
            ContentPannel.Controls.Clear();
            HomeUI homeUI = new HomeUI();
            ContentPannel.Controls.Add(homeUI);


        }

        private void EmployeeBtn_Click(object sender, EventArgs e)
        {
            HideDropDownMenu();
            ChangeBtnBar(EmployeeBtn);
            ContentPannel.Controls.Clear();
            EmployeeUI employeeUI = new EmployeeUI();
            ContentPannel.Controls.Add(employeeUI);
            employeeUI.Show();
        }

        private void SalaryBtn_Click(object sender, EventArgs e)
        {
            ShowDropDownMenu();
            ChangeBtnBar(SalaryBtn);
            ContentPannel.Controls.Clear();
            SalaryCalculateUI salaryCalculate = new SalaryCalculateUI();
            ContentPannel.Controls.Add(salaryCalculate);
            salaryCalculate.Show();
        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {
            HideDropDownMenu();
            ChangeBtnBar(SettingBtn);
            ContentPannel.Controls.Clear();
            SettingsUI settings = new SettingsUI();
            ContentPannel.Controls.Add(settings);
            settings.Show();
        }

        private void SalaryCulateBtn_Click(object sender, EventArgs e)
        {
            ChangeSubsalaryBar(SalaryCulateBtn);
            ContentPannel.Controls.Clear();
            SalaryCalculateUI salaryCalculate = new SalaryCalculateUI();
            ContentPannel.Controls.Add(salaryCalculate);
            salaryCalculate.Show();

        }

        private void SalarySummeryBtn_Click(object sender, EventArgs e)
        {
            ChangeSubsalaryBar(SalarySummeryBtn);
            SalarySummeryUI salarySummery = new SalarySummeryUI();
            ContentPannel.Controls.Clear();
            ContentPannel.Controls.Add(salarySummery);
            salarySummery.Show();
        }

        private void SalaryOverallBtn_Click(object sender, EventArgs e)
        {
            ChangeSubsalaryBar(SalaryOverallBtn);
            ContentPannel.Controls.Clear();
            SummeryPayvaluesUI summeryPayvalues = new SummeryPayvaluesUI();
            ContentPannel.Controls.Add(summeryPayvalues);
            summeryPayvalues.Show();
        }

        private void Grifindo_Load(object sender, EventArgs e)
        {
            ContentPannel.Controls.Clear();
            HomeUI homeUI = new HomeUI();
            ContentPannel.Controls.Add(homeUI);
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogOutBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
