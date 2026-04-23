using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthAssessment
{
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

    internal class ThirdQuestion
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>
{
    new Employee { EmployeeID=1001, FirstName="Malcolm", LastName="Daruwalla", Title="Manager", DOB=DateTime.Parse("1984-11-16"), DOJ=DateTime.Parse("2011-06-08"), City="Mumbai"},
    new Employee { EmployeeID=1002, FirstName="Asdin", LastName="Dhalla", Title="AsstManager", DOB=DateTime.Parse("1984-08-20"), DOJ=DateTime.Parse("2012-07-07"), City="Mumbai"},
    new Employee { EmployeeID=1003, FirstName="Madhavi", LastName="Oza", Title="Consultant", DOB=DateTime.Parse("1987-11-14"), DOJ=DateTime.Parse("2015-04-12"), City="Pune"},
    new Employee { EmployeeID=1004, FirstName="Saba", LastName="Shaikh", Title="SE", DOB=DateTime.Parse("1990-06-03"), DOJ=DateTime.Parse("2016-02-02"), City="Pune"},
    new Employee { EmployeeID=1005, FirstName="Nazia", LastName="Shaikh", Title="SE", DOB=DateTime.Parse("1991-03-08"), DOJ=DateTime.Parse("2016-02-02"), City="Mumbai"},
    new Employee { EmployeeID=1006, FirstName="Amit", LastName="Pathak", Title="Consultant", DOB=DateTime.Parse("1989-11-07"), DOJ=DateTime.Parse("2014-08-08"), City="Chennai"},
    new Employee { EmployeeID=1007, FirstName="Vijay", LastName="Natrajan", Title="Consultant", DOB=DateTime.Parse("1989-12-02"), DOJ=DateTime.Parse("2015-06-01"), City="Mumbai"},
    new Employee { EmployeeID=1008, FirstName="Rahul", LastName="Dubey", Title="Associate", DOB=DateTime.Parse("1993-11-11"), DOJ=DateTime.Parse("2014-11-06"), City="Chennai"},
    new Employee { EmployeeID=1009, FirstName="Suresh", LastName="Mistry", Title="Associate", DOB=DateTime.Parse("1992-08-12"), DOJ=DateTime.Parse("2014-12-03"), City="Chennai"},
    new Employee { EmployeeID=1010, FirstName="Sumit", LastName="Shah", Title="Manager", DOB=DateTime.Parse("1991-04-12"), DOJ=DateTime.Parse("2016-01-02"), City="Pune"}
};

            // a.Display detail of all employees
            var allEmployees = from e in empList
                               select e;
            Console.WriteLine("Firstquestion output ");
            foreach (var emp in allEmployees)
                Console.WriteLine($"{emp.EmployeeID} {emp.FirstName} {emp.LastName} {emp.Title} {emp.DOB.ToShortDateString()} {emp.DOJ.ToShortDateString()} {emp.City}");
            //b. Employees whose location is not Mumbai
            var nonMumbaiEmployees = from e in empList
                                     where e.City != "Mumbai"
                                     select e;
            Console.WriteLine();
            Console.WriteLine("Secondquestion output ");
            foreach (var emp in nonMumbaiEmployees)
                Console.WriteLine($"{emp.EmployeeID} {emp.FirstName} {emp.LastName} {emp.City}");
            //c. Employees whose title is AsstManager
            var asstManagers = from e in empList
                               where e.Title == "AsstManager"
                               select e;
            Console.WriteLine();
            Console.WriteLine("Thirduestion output ");

            foreach (var emp in asstManagers)
                Console.WriteLine($"{emp.EmployeeID} {emp.FirstName} {emp.LastName} {emp.Title}");
            //d. Employees whose Last Name starts with 'S'
            var lastNameS = from e in empList
                            where e.LastName.StartsWith("S")
                            select e;
            Console.WriteLine();
            Console.WriteLine("FourthQuestion output ");
            foreach (var emp in lastNameS)
                Console.WriteLine($"{emp.EmployeeID} {emp.FirstName} {emp.LastName}");

        }
    }
}
