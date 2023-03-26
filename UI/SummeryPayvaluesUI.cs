using Payroll_Project;
using Payroll_Project_2.Backend;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Payroll_Project_2.UI
{
    public partial class SummeryPayvaluesUI : UserControl
    {
        
        List<decimal> payValues = new List<decimal>();
        readonly SalaryDataAccess salaryDataAccess = new SalaryDataAccess();

        public SummeryPayvaluesUI()
        {
            InitializeComponent();
            FromDataPicker.Value = DateTime.Now.AddMonths(-6).AddDays(-1);
            ToDataPicker.Value = DateTime.Now;
        }

        private void RefreshBtn_Click(object sender, System.EventArgs e)
        {
            payValues = salaryDataAccess.GetTotalPayValues(FromDataPicker.Value, ToDataPicker.Value);
            GrossPayValueLabel.Text = payValues[0].ToString();
            BasePayValueLabel.Text = payValues[1].ToString();
            NoPayValueLabel.Text = payValues[2].ToString();
        }

        private void SummeryPayvaluesUI_Load(object sender, EventArgs e)
        {
            payValues = salaryDataAccess.GetTotalPayValues(FromDataPicker.Value, ToDataPicker.Value);
            GrossPayValueLabel.Text = payValues[0].ToString();
            BasePayValueLabel.Text = payValues[1].ToString();
            NoPayValueLabel.Text = payValues[2].ToString();
        }
    }
}
