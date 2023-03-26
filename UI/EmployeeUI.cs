using Payroll_Project_2.Backend;
using System;
using System.Windows.Forms;

namespace Payroll_Project_2.UI
{
    public partial class EmployeeUI : UserControl
    {
        public EmployeeUI()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, System.EventArgs e)
        {
            EmployeesDataGrid.DataSource = new EmployeeDataAccess().GetAllEmployees();

        }

        private void EmlCreateBtn_Click(object sender, System.EventArgs e)
        {
            string Name = NameTxtBox.Text.Trim();
            decimal Monthly_Salary = Decimal.Parse(SalaryTxtBox.Text);
            decimal Allowance = Decimal.Parse(AllowanceBox.Text);
            decimal Over_Time_Rate = Decimal.Parse(OTTxtBox.Text);

            if (Name == null || Monthly_Salary == 0 || Over_Time_Rate == 0 || Allowance == 0)
            {
                MessageBox.Show("Please enter Valid filed!");
            }
            else
            {
                try
                {
                    Employee employee = new Employee()
                    {
                        Name = Name,
                        Monthly_Salary = Monthly_Salary,
                        Allowance = Allowance,
                        Over_Time_Rate = Over_Time_Rate
                    };
                    new EmployeeDataAccess().AddEmployee(employee);
                    EmployeesDataGrid.DataSource = new EmployeeDataAccess().GetAllEmployees();
                    MessageBox.Show("Successfully Created!");

                }
                catch (Exception)
                {
                    MessageBox.Show("Error While Creating an Employee!");
                }

            }
        }

        private void EmployeesDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (EmployeesDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = EmployeesDataGrid.SelectedRows[0];
                NameTxtBox.Text = (string)selectedRow.Cells["Name"].Value;
                SalaryTxtBox.Text = ((decimal)selectedRow.Cells["Monthly_Salary"].Value).ToString();
                OTTxtBox.Text = ((decimal)selectedRow.Cells["Over_Time_Rate"].Value).ToString();
                AllowanceBox.Text = ((decimal)selectedRow.Cells["Allowance"].Value).ToString();
            }
        }

        private void EmpUpdateBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = EmployeesDataGrid.SelectedRows[0];
            int Id = (int)selectedRow.Cells["Id"].Value;
            string Name = NameTxtBox.Text;
            decimal Monthly_Salary = Decimal.Parse(SalaryTxtBox.Text);
            decimal Allowance = Decimal.Parse(AllowanceBox.Text);
            decimal Over_Time_Rate = Decimal.Parse(OTTxtBox.Text);
            Employee employee = new Employee()
            {
                Id = Id,
                Name = Name,
                Monthly_Salary = Monthly_Salary,
                Allowance = Allowance,
                Over_Time_Rate = Over_Time_Rate
            };

            new EmployeeDataAccess().UpdateEmployee(employee);
            EmployeesDataGrid.DataSource = new EmployeeDataAccess().GetAllEmployees();
            MessageBox.Show("Successfully Updated!");


        }

        private void EmpDeleteBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = EmployeesDataGrid.SelectedRows[0];
            int Id = (int)selectedRow.Cells["Id"].Value;
            new EmployeeDataAccess().DeleteEmployee(Id);
            EmployeesDataGrid.DataSource = new EmployeeDataAccess().GetAllEmployees();
            MessageBox.Show("Successfully Deleted!");

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string searchString = SearchBox.Text;

            foreach (DataGridViewRow row in EmployeesDataGrid.Rows)
            {
                if (row.Cells["ID"].Value != null && row.Cells["ID"].Value.ToString() == searchString || row.Cells["Name"].Value != null && row.Cells["Name"].Value.ToString().Trim().ToLower() == searchString.ToLower())
                {
                    row.Selected = true;
                    EmployeesDataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void EmployeesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
