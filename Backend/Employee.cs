namespace Payroll_Project_2.Backend
{
    internal class Employee
    {
        private int id;
        private string name;
        private decimal monthly_Salary;
        private decimal over_Time_Rate;
        private decimal allowance;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public decimal Monthly_Salary { get => monthly_Salary; set => monthly_Salary = value; }
        public decimal Over_Time_Rate { get => over_Time_Rate; set => over_Time_Rate = value; }
        public decimal Allowance { get => allowance; set => allowance = value; }
    }
}


