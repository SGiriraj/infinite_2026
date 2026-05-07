using System;
using System.Collections.Generic;
using System.Linq;

public class Class1
{
    public static void Main(string[] args)
    {
        List<Employee> empList = new List<Employee>()
        {
            new Employee { EmployeeID=1001, FirstName="Malcolm", LastName="Daruwalla", Title="Manager", DOB=DateTime.Parse("16/11/1984"), DOJ=DateTime.Parse("8/6/2011"), City="Mumbai"},
            new Employee { EmployeeID=1002, FirstName="Asdin", LastName="Dhalla", Title="AsstManager", DOB=DateTime.Parse("20/08/1984"), DOJ=DateTime.Parse("7/7/2012"), City="Mumbai"},
            new Employee { EmployeeID=1003, FirstName="Madhavi", LastName="Oza", Title="Consultant", DOB=DateTime.Parse("14/11/1987"), DOJ=DateTime.Parse("12/4/2015"), City="Pune"},
            new Employee { EmployeeID=1004, FirstName="Saba", LastName="Shaikh", Title="SE", DOB=DateTime.Parse("3/6/1990"), DOJ=DateTime.Parse("2/2/2016"), City="Pune"},
            new Employee { EmployeeID=1005, FirstName="Nazia", LastName="Shaikh", Title="SE", DOB=DateTime.Parse("8/3/1991"), DOJ=DateTime.Parse("2/2/2016"), City="Mumbai"},
            new Employee { EmployeeID=1006, FirstName="Amit", LastName="Pathak", Title="Consultant", DOB=DateTime.Parse("7/11/1989"), DOJ=DateTime.Parse("8/8/2014"), City="Chennai"},
            new Employee { EmployeeID=1007, FirstName="Vijay", LastName="Natrajan", Title="Consultant", DOB=DateTime.Parse("2/12/1989"), DOJ=DateTime.Parse("1/6/2015"), City="Mumbai"},
            new Employee { EmployeeID=1008, FirstName="Rahul", LastName="Dubey", Title="Associate", DOB=DateTime.Parse("11/11/1993"), DOJ=DateTime.Parse("6/11/2014"), City="Chennai"},
            new Employee { EmployeeID=1009, FirstName="Suresh", LastName="Mistry", Title="Associate", DOB=DateTime.Parse("12/8/1992"), DOJ=DateTime.Parse("3/12/2014"), City="Chennai"},
            new Employee { EmployeeID=1010, FirstName="Sumit", LastName="Shah", Title="Manager", DOB=DateTime.Parse("12/4/1991"), DOJ=DateTime.Parse("2/1/2016"), City="Pune"}
        };

        DateTime date2015 = new DateTime(2015, 1, 1);
        DateTime date1990 = new DateTime(1990, 1, 1);

        // 1
        Console.WriteLine("\n1. Employees who joined before 01-01-2015:");
        foreach (var e in empList.Where(e => e.DOJ < date2015))
            Console.WriteLine(e.FirstName);

        // 2
        Console.WriteLine("\n2. Employees whose DOB is after 01-01-1990:");
        foreach (var e in empList.Where(e => e.DOB > date1990))
            Console.WriteLine(e.FirstName);

        // 3
        Console.WriteLine("\n3. Employees who are Consultant or Associate:");
        foreach (var e in empList.Where(e => e.Title == "Consultant" || e.Title == "Associate"))
            Console.WriteLine(e.FirstName);

        // 4
        Console.WriteLine("\n4. Total number of employees:");
        Console.WriteLine(empList.Count());

        // 5
        Console.WriteLine("\n5. Total number of employees in Chennai:");
        Console.WriteLine(empList.Count(e => e.City == "Chennai"));

        // 6
        Console.WriteLine("\n6. Highest Employee ID:");
        Console.WriteLine(empList.Max(e => e.EmployeeID));

        // 7
        Console.WriteLine("\n7. Employees who joined after 01-01-2015:");
        Console.WriteLine(empList.Count(e => e.DOJ > date2015));

        // 8
        Console.WriteLine("\n8. Employees whose designation is NOT Associate:");
        Console.WriteLine(empList.Count(e => e.Title != "Associate"));

        // 9
        Console.WriteLine("\n9. Total employees based on City:");
        foreach (var g in empList.GroupBy(e => e.City))
            Console.WriteLine(g.Key + " - " + g.Count());

        // 10
        Console.WriteLine("\n10. Total employees based on City and Title:");
        foreach (var g in empList.GroupBy(e => new { e.City, e.Title }))
            Console.WriteLine(g.Key.City + " - " + g.Key.Title + " - " + g.Count());

        // 11
        Console.WriteLine("\n11. Youngest employee(s):");
        DateTime maxDOB = empList.Max(e => e.DOB);
        foreach (var e in empList.Where(e => e.DOB == maxDOB))
            Console.WriteLine(e.FirstName);

        Console.ReadLine();
    }
}

// Employee Class
public class Employee
{
    public int EmployeeID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }
    public DateTime DOB { get; set; }
    public DateTime DOJ { get; set; }
    public string City { get; set; }
}