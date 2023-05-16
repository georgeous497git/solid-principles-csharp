using System;
namespace OpenClose
{
	public abstract class Employee
	{

        public string FullName { get; set; }
        public int HoursWorked { get; set; }

        public Employee(string Fullname, int Hoursworked)
		{
			FullName = Fullname;
			HoursWorked = Hoursworked;
		}

        public abstract decimal CalculateSalaryMonthly();
    }
}

