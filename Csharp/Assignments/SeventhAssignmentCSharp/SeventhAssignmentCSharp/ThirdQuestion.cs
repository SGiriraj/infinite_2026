using System;
using System.Collections.Generic;
using System.Linq;

namespace SeventhAssignmentCSharp
{
   public  class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpCity { get; set; }
        public double EmpSalary { get; set; }
    }

    public class ThirdQuestion
    {
        public static void Second()
        {
            List<Employee> empList = new List<Employee>();

            Console.Write("Enter number of employees: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Employee emp = new Employee();

                Console.WriteLine($"\nEnter details for Employee {i + 1}:");

                Console.Write("EmpId: ");
                emp.EmpId = Convert.ToInt32(Console.ReadLine());

                Console.Write("EmpName: ");
                emp.EmpName = Console.ReadLine();

                Console.Write("EmpCity: ");
                emp.EmpCity = Console.ReadLine();

                Console.Write("EmpSalary: ");
                emp.EmpSalary = Convert.ToDouble(Console.ReadLine());

                empList.Add(emp);
            }

            Console.WriteLine("\nAll Employees:");
            foreach (var emp in empList)
                Print(emp);

            Console.WriteLine("\nEmployees with Salary > 45000:");
            var highSalary = empList.Where(e => e.EmpSalary > 45000);

            if (!highSalary.Any())
                Console.WriteLine("No employees found");
            else
                foreach (var emp in highSalary)
                    Print(emp);

            Console.WriteLine("\nEmployees from Bangalore:");
            var bangaloreEmp = empList.Where(e =>
                e.EmpCity.Equals("Bangalore", StringComparison.OrdinalIgnoreCase));

            if (!bangaloreEmp.Any())
                Console.WriteLine("No employees found");
            else
                foreach (var emp in bangaloreEmp)
                    Print(emp);

            Console.WriteLine("\nEmployees Sorted by Name:");
            var sortedEmp = empList.OrderBy(e => e.EmpName);

            foreach (var emp in sortedEmp)
                Print(emp);
        }

        public static void Print(Employee e)
        {
            Console.WriteLine($"{e.EmpId} {e.EmpName} {e.EmpCity} {e.EmpSalary}");
        }
    }

    
}