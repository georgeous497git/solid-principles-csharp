namespace OpenClose
{
    public class EmployeeFullTime : Employee
    {

        private decimal HourValue = 30000M;

        public EmployeeFullTime(string fullname, int hoursworked) : base (fullname, hoursworked)
        { }

        public override decimal CalculateSalaryMonthly()
        {
            return HourValue * HoursWorked;
        }
    }
}