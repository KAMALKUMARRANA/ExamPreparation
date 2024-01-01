// See https://aka.ms/new-console-template for more information
using GroupBy;

Console.WriteLine("Hello, World!");

/*var employeeGroups=Employee.GetAllEmployees().GroupBy(x => x.Department); // Lambda
*/
var employeeGroups = from emp in Employee.GetAllEmployees() group emp by emp.Department;

foreach (var Group in employeeGroups)
{
    Console.WriteLine("{0} - {1}",Group.Key,Group.Count(x=>x.Gender=="Male"));
    Console.WriteLine("{0} - {1}",Group.Key,Group.Max(x=>x.AnnualSalary));
}