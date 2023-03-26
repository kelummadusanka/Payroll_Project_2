using Payroll_Project_2.Backend;
using System;
using System.IO;

namespace Payroll_Project
{
    internal class Salary
    {
        public int Id;
        public string Name;
        public DateTime Salary_Paid_Date;
        public int Begin_Date;
        public int End_Date;
        public int salary_Cycle_Date_Range;
        public decimal Monthly_Salary;
        public decimal Allowance;
        public decimal Over_Time_Rate;
        public decimal no_of_overtime_Hours;
        public decimal no_of_Absent_Days;
        public decimal no_of_Holidays;
        public decimal government_Tax_Rate;
        public decimal No_Pay_Value;
        public decimal Base_Pay_Value;
        public decimal Gross_Pay_Value;

        public Salary()
        {
        }

        public Salary(int id, DateTime Salary_Paid_Day, decimal no_of_overtime_Hours, decimal no_of_Absent_Days, decimal no_of_Holidays)
        {
            Employee employee = new EmployeeDataAccess().GetEmployee(id);
            Setting setting = new SettingDataAccess().GetValue();

            this.Id = id;
            this.Name = employee.Name;
            this.Salary_Paid_Date = Salary_Paid_Day.Date;
            this.Begin_Date = setting.Begin_Date;
            this.End_Date = setting.End_Date;
            this.salary_Cycle_Date_Range = setting.Date_Range;
            this.Monthly_Salary = employee.Monthly_Salary;
            this.Allowance = employee.Allowance;
            this.Over_Time_Rate = employee.Over_Time_Rate;
            this.government_Tax_Rate = setting.Tax_Rate;
            this.no_of_overtime_Hours = no_of_overtime_Hours;
            this.no_of_Absent_Days = no_of_Absent_Days;
            this.no_of_Holidays = no_of_Holidays;
            this.No_Pay_Value = CalculateNoPayValue(Monthly_Salary, salary_Cycle_Date_Range, no_of_Absent_Days);
            this.Base_Pay_Value = CalculateBasePayValue(no_of_overtime_Hours);
            this.Gross_Pay_Value = CalculateGrossPayValue();
        }

        private decimal CalculateNoPayValue(decimal totalSalary, int salaryCycleDateRange, decimal noOfAbsentDays)
        {
            return Math.Round((totalSalary / salaryCycleDateRange) * noOfAbsentDays, 2);
        }

        private decimal CalculateBasePayValue(decimal noOfOvertimeHours)
        {
            return Math.Round(Monthly_Salary + Allowance + (Over_Time_Rate * noOfOvertimeHours));
        }

        private decimal CalculateGrossPayValue()
        {
            return Math.Round(Base_Pay_Value - (No_Pay_Value + Base_Pay_Value * government_Tax_Rate / 100));
        }
    }
}
