using System;
using System.Collections.Generic;
using System.Text;

namespace FirstAssessmentCSharp
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

        public static List<Employee> employees = new List<Employee>();



        public static void AddEmployee()
        {
            Employee emp = new Employee();

            Console.WriteLine("Enter the Id:");
            emp.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Name:");
            emp.Name = Console.ReadLine();

            Console.WriteLine("Enter the Department:");
            emp.Department = Console.ReadLine();

            Console.WriteLine("Enter the Salary:");
            emp.Salary = Convert.ToDouble(Console.ReadLine());

            employees.Add(emp);

            Console.WriteLine("Employee Added Successfully!");
            Employee.ViewEmployees();
        }

        public static void ViewEmployees()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No employee Founded");
                return;
            }
            foreach (var emp in employees)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Dept: {emp.Department}, Salary: {emp.Salary}");
            }
        }
        public static void SearchEmployee()
        {
            Console.Write("Enter ID to search: ");

            int id = Convert.ToInt32(Console.ReadLine());

            Employee found = null;

            foreach (Employee emp in employees)
            {
                if (emp.Id == id)
                {
                    found = emp;
                    break;
                }
            }

            if (found != null)
                Console.WriteLine($"Found: {found.Name}, {found.Department}, {found.Salary}");
            else
                Console.WriteLine("Employee not found.");
        }
        public static void UpdateEmployee()
        {
            Console.Write("Enter ID to update: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Employee found = null;

            foreach (Employee emp in employees)
            {
                if (emp.Id == id)
                {
                    found = emp;
                    break;
                }
            }

            if (found != null)
            {
                Console.WriteLine("\nWhat do you want to update?");
                Console.WriteLine("1. Name");
                Console.WriteLine("2. Department");
                Console.WriteLine("3. Salary");
                Console.WriteLine("4. All");
                Console.Write("Enter choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter new Name: ");
                        found.Name = Console.ReadLine();

                        break;

                    case 2:
                        Console.Write("Enter new Department: ");
                        found.Department = Console.ReadLine();
                        break;

                    case 3:
                        Console.Write("Enter new Salary: ");
                        found.Salary = double.Parse(Console.ReadLine());
                        break;

                    case 4:
                        Console.Write("Enter new Name: ");
                        found.Name = Console.ReadLine();

                        Console.Write("Enter new Department: ");
                        found.Department = Console.ReadLine();

                        Console.Write("Enter new Salary: ");
                        found.Salary = double.Parse(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        return;
                }
                Employee.ViewEmployees();

                Console.WriteLine("Employee Updated Successfully!");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }
        public static void DeleteEmployee()
        {
            Console.Write("Enter ID to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Employee found = null;

            foreach (Employee emp in employees)
            {
                if (emp.Id == id)
                {
                    found = emp;
                    break;
                }
            }

            if (found != null)
            {
                employees.Remove(found);
                Console.WriteLine("Employee Deleted Successfully!");
                Employee.ViewEmployees();
            }
            else
            {
                Console.WriteLine("Employee not found.");
                Employee.ViewEmployees();
            }
        }

    }
}
