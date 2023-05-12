using Payroll_Project_2.Backend;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Payroll_Project_2.UI
{
    public partial class SalarySummeryUI : UserControl
    {
        public SalarySummeryUI()
        {
            InitializeComponent();
        }

        private void SalarySummeryUI_Load(object sender, System.EventArgs e)
        {
            EmployeeIdComboBox.DataSource = new EmployeeDataAccess().GetEmployeeIds();
        }

        private void SearchBtn_Click(object sender, System.EventArgs e)
        {
          
            ClearBtn.Visible = true;
            try
            {

                DetailPannel.Visible = true;
                int id = int.Parse(EmployeeIdComboBox.Text);

                List<Salary> salaryList = new SalaryDataAccess().GetEmployeeSalaryList(id);
                Employee employee = new EmployeeDataAccess().GetEmployee(id);

                EmployeeNameValueLabel.Text = employee.Name.Trim();
                MonthlySalaryValueLabel.Text = employee.Monthly_Salary.ToString();
                AllowanceValueLabel.Text = employee.Allowance.ToString();

                SalaryDetailTable.Visible = true;

                if (salaryList.Count == 0)
                {
                    SalaryDetailTable.Visible = false;
                }


                if (salaryList.Count >= 1 && salaryList[0] != null)
                {
                    Month1.Text = salaryList[0].Salary_Paid_Date.ToString("MMM");
                    Year1.Text = salaryList[0].Salary_Paid_Date.ToString("yyyy");
                    NoPayValue1.Text = salaryList[0].No_Pay_Value.ToString();
                    BasePayValue1.Text = salaryList[0].Base_Pay_Value.ToString();
                    GrossPayValue1.Text = salaryList[0].Gross_Pay_Value.ToString();

                }
                else
                {
                    Month1.Text = "";
                    Year1.Text = "";
                    NoPayValue1.Text = "";
                    BasePayValue1.Text = "";
                    GrossPayValue1.Text = "";
                }

                if (salaryList.Count >= 2 && salaryList[1] != null)
                {
                    Month2.Text = salaryList[1].Salary_Paid_Date.ToString("MMM");
                    Year2.Text = salaryList[1].Salary_Paid_Date.ToString("yyyy");
                    NoPayValue2.Text = salaryList[1].No_Pay_Value.ToString();
                    BasePayValue2.Text = salaryList[1].Base_Pay_Value.ToString();
                    GrossPayValue2.Text = salaryList[1].Gross_Pay_Value.ToString();
                }
                else
                {
                    Month2.Text = "";
                    Year2.Text = "";
                    NoPayValue2.Text = "";
                    BasePayValue2.Text = "";
                    GrossPayValue2.Text = "";
                }

                if (salaryList.Count >= 4 && salaryList[3] != null)
                {
                    Month3.Text = salaryList[2].Salary_Paid_Date.ToString("MMM");
                    Year3.Text = salaryList[2].Salary_Paid_Date.ToString("yyyy");
                    NoPayValue3.Text = salaryList[2].No_Pay_Value.ToString();
                    BasePayValue3.Text = salaryList[2].Base_Pay_Value.ToString();
                    GrossPayValue3.Text = salaryList[2].Gross_Pay_Value.ToString();
                }
                else
                {
                    Month3.Text = "";
                    Year3.Text = "";
                    NoPayValue3.Text = "";
                    BasePayValue3.Text = "";
                    GrossPayValue3.Text = "";
                }
                if (salaryList.Count >= 4 && salaryList[3] != null)
                {
                    Month4.Text = salaryList[3].Salary_Paid_Date.ToString("MMM");
                    Year4.Text = salaryList[3].Salary_Paid_Date.ToString("yyyy");
                    NoPayValue4.Text = salaryList[3].No_Pay_Value.ToString();
                    BasePayValue4.Text = salaryList[3].Base_Pay_Value.ToString();
                    GrossPayValue4.Text = salaryList[3].Gross_Pay_Value.ToString();
                }
                else
                {
                    Month4.Text = "";
                    Year4.Text = "";
                    NoPayValue4.Text = "";
                    BasePayValue4.Text = "";
                    GrossPayValue4.Text = "";
                }

                if (salaryList.Count >= 5 && salaryList[4] != null)
                {
                    Month5.Text = salaryList[4].Salary_Paid_Date.ToString("MMM");
                    Year5.Text = salaryList[4].Salary_Paid_Date.ToString("yyyy");
                    NoPayValue5.Text = salaryList[4].No_Pay_Value.ToString();
                    BasePayValue5.Text = salaryList[4].Base_Pay_Value.ToString();
                    GrossPayValue5.Text = salaryList[4].Gross_Pay_Value.ToString();
                }
                else
                {
                    Month5.Text = "";
                    Year5.Text = "";
                    NoPayValue5.Text = "";
                    BasePayValue5.Text = "";
                    GrossPayValue5.Text = "";
                }
            }
            catch (Exception ex)
            {
                DetailPannel.Visible = false;
                InvaliedSearchImage.Visible = true;
                MessageBox.Show(ex.Message);
            }

        }

        private void ClearBtn_Click(object sender, System.EventArgs e)
        {
            DetailPannel.Visible = false;
            InvaliedSearchImage.Visible = false;
            ClearBtn.Visible = false;
        }
    }
}
