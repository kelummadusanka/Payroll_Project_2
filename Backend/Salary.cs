using System;

namespace Payroll_Project_2.Backend
{
    internal class Salary
    {
        private int id;
        private string name;
        private DateTime salary_Paid_Date;
        private int begin_Date;
        private int end_Date;
        private int salary_Cycle_Date_Range;
        private decimal monthly_Salary;
        private decimal allowance;
        private decimal over_Time_Rate;
        private decimal no_of_overtime_Hours;
        private decimal no_of_Absent_Days;
        private decimal no_of_Holidays;
        private decimal government_Tax_Rate;
        private decimal no_Pay_Value;
        private decimal base_Pay_Value;
        private decimal gross_Pay_Value;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Salary_Paid_Date { get => salary_Paid_Date; set => salary_Paid_Date = value; }
        public int Begin_Date { get => begin_Date; set => begin_Date = value; }
        public int End_Date { get => end_Date; set => end_Date = value; }
        public int Salary_Cycle_Date_Range { get => salary_Cycle_Date_Range; set => salary_Cycle_Date_Range = value; }
        public decimal Monthly_Salary { get => monthly_Salary; set => monthly_Salary = value; }
        public decimal Allowance { get => allowance; set => allowance = value; }
        public decimal Over_Time_Rate { get => over_Time_Rate; set => over_Time_Rate = value; }
        public decimal No_of_overtime_Hours { get => no_of_overtime_Hours; set => no_of_overtime_Hours = value; }
        public decimal No_of_Absent_Days { get => no_of_Absent_Days; set => no_of_Absent_Days = value; }
        public decimal No_of_Holidays { get => no_of_Holidays; set => no_of_Holidays = value; }
        public decimal Government_Tax_Rate { get => government_Tax_Rate; set => government_Tax_Rate = value; }
        public decimal No_Pay_Value { get => no_Pay_Value; set => no_Pay_Value = value; }
        public decimal Base_Pay_Value { get => base_Pay_Value; set => base_Pay_Value = value; }
        public decimal Gross_Pay_Value { get => gross_Pay_Value; set => gross_Pay_Value = value; }

        public Salary()
        {
        }

        public Salary(int id, DateTime Salary_Paid_Day, decimal no_of_overtime_Hours, decimal no_of_Absent_Days, decimal no_of_Holidays)
        {
            Employee employee = new EmployeeDataAccess().GetEmployee(id);
            Setting setting = new SettingDataAccess().GetSettingValue();

            Id = id;
            Name = employee.Name;
            Salary_Paid_Date = Salary_Paid_Day.Date;
            Begin_Date = setting.Begin_Date;
            End_Date = setting.End_Date;
            Salary_Cycle_Date_Range = setting.Date_Range;
            Monthly_Salary = employee.Monthly_Salary;
            Allowance = employee.Allowance;
            Over_Time_Rate = employee.Over_Time_Rate;
            Government_Tax_Rate = setting.Tax_Rate;
            this.No_of_overtime_Hours = no_of_overtime_Hours;
            this.No_of_Absent_Days = no_of_Absent_Days;
            this.No_of_Holidays = no_of_Holidays;
            No_Pay_Value = CalculateNoPayValue(Monthly_Salary, Salary_Cycle_Date_Range, no_of_Absent_Days);
            Base_Pay_Value = CalculateBasePayValue(no_of_overtime_Hours);
            Gross_Pay_Value = CalculateGrossPayValue();
        }

        // Calculates the no-pay value
        private decimal CalculateNoPayValue(decimal totalSalary, int salaryCycleDateRange, decimal noOfAbsentDays)
        {
            decimal noPayValue = totalSalary / salaryCycleDateRange * noOfAbsentDays;
            return Math.Round(noPayValue, 2);
        }

        // Calculates the base pay value
        private decimal CalculateBasePayValue(decimal noOfOvertimeHours)
        {
            decimal basePayValue = Monthly_Salary + Allowance + Over_Time_Rate * noOfOvertimeHours;
            return Math.Round(basePayValue, 2);
        }

        // Calculates the gross pay value
        private decimal CalculateGrossPayValue()
        {
            decimal grossPayValue = Base_Pay_Value - (No_Pay_Value + Base_Pay_Value * Government_Tax_Rate / 100);
            return Math.Round(grossPayValue, 2);
        }

    }
}