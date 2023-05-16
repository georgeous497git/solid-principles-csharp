using OpenClose;

ShowSalaryMonthly(new List<Employee>() {
    new EmployeeFullTime("Pepito Pérez", 160),
    new EmployeePartTime("Manuel Lopera", 180)
});


void ShowSalaryMonthly(List<Employee> employees) 
{
    foreach (var employee in employees)
    {
        decimal salary = employee.CalculateSalaryMonthly();
        Console.WriteLine($"Empleado: {employee.FullName}, Pago: {salary:C1} ");
    }

}