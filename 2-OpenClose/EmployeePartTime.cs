namespace OpenClose
{
    public class EmployeePartTime : Employee
    {
        private decimal HourValue = 20000M;

        public EmployeePartTime(string fullname, int hoursworked) : base(fullname, hoursworked)
        { }

        public override decimal CalculateSalaryMonthly()
        {
            decimal salary = HourValue * HoursWorked;
            if (HoursWorked > 160)
            {
                decimal effortCompensation = 5000M;
                int extraDays = HoursWorked - 160;
                salary += effortCompensation * extraDays;
            }
            return salary;
        }
    }
}