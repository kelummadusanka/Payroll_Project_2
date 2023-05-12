using Payroll_Project_2.UI;
using System;
using System.Runtime.InteropServices;
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
            Buttonbar.Left = button.Left ;
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
            HideDropDownMenu();
            ChangeSubsalaryBar(SalaryCulateBtn);
            ContentPannel.Controls.Clear();
            SalaryCalculateUI salaryCalculate = new SalaryCalculateUI();
            ContentPannel.Controls.Add(salaryCalculate);
            salaryCalculate.Show();

        }

        private void SalarySummeryBtn_Click(object sender, EventArgs e)
        {
            HideDropDownMenu();
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
            HideDropDownMenu();
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


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ShowDropDownMenu();
            ChangeBtnBar(SalaryBtn);
        }

        private void LogOutBtn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //drag Form

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int Wmsg, int wParam, int lParam);

        private void Grifindo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void ContentPannel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void buttonHome_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void SalaryBtn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void EmployeeBtn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void SettingBtn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LogOutBtn1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
