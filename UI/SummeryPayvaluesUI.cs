using Payroll_Project_2.Backend;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            payValues = salaryDataAccess.GetOverallPayValues(FromDataPicker.Value, ToDataPicker.Value);
            GrossPayValueLabel.Text = payValues[0].ToString();
            BasePayValueLabel.Text = payValues[1].ToString();
            NoPayValueLabel.Text = payValues[2].ToString();
            UpdateBarChart(payValues);
        }

        private void UpdateBarChart(List<decimal> payValues)
        {
            
            int GrossPayValue = (int)Math.Round(payValues[0]);
            int BasePayValue = (int)Math.Round(payValues[1]);
            int NoPayValue = (int)Math.Round(payValues[2]);

            int panelWidth = BarchartPannel.Width;
            int totalPay = GrossPayValue + BasePayValue + NoPayValue;

            GroospayBar.Width = panelWidth*GrossPayValue/ totalPay;
            BasepayBar.Width = panelWidth * BasePayValue / totalPay;
            NopayBar.Width = panelWidth * NoPayValue / totalPay;
        }

        private void SummeryPayvaluesUI_Load(object sender, EventArgs e)
        {
            payValues = salaryDataAccess.GetOverallPayValues(FromDataPicker.Value, ToDataPicker.Value);
            GrossPayValueLabel.Text = payValues[0].ToString();
            BasePayValueLabel.Text = payValues[1].ToString();
            NoPayValueLabel.Text = payValues[2].ToString();
            UpdateBarChart(payValues);
        }
    }

    }

