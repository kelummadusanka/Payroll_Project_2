namespace Payroll_Project_2.Backend
{
    internal class Setting
    {
        private int date_Range;
        private int begin_Date;
        private int end_Date;
        private int no_of_Leaves;
        private decimal tax_Rate;

        public int Date_Range { get => date_Range; set => date_Range = value; }
        public int Begin_Date { get => begin_Date; set => begin_Date = value; }
        public int End_Date { get => end_Date; set => end_Date = value; }
        public int No_of_Leaves { get => no_of_Leaves; set => no_of_Leaves = value; }
        public decimal Tax_Rate { get => tax_Rate; set => tax_Rate = value; }
    }
}
