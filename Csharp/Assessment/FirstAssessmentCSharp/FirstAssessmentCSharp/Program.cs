using System;

namespace FirstAssessmentCSharp
{
      
    internal class FirstAssessment
    {
        public delegate void Operation();

        static void Main(string[] args)
        {
            Console.WriteLine("Choose Program:");
            Console.WriteLine("1. Nested Struct Program");
            Console.WriteLine("2. Employee Management");
            int mainChoice = Convert.ToInt32(Console.ReadLine());

            if (mainChoice == 1)
            {
                SecondQuestionEmployee.Run();
            }
            else
            {
                while (true)
                {
                    Console.WriteLine("\n===== Employee Management   =====");
                    Console.WriteLine("1. Add New Employee");
                    Console.WriteLine("2. View All Employees");
                    Console.WriteLine("3. Search Employee by ID");
                    Console.WriteLine("4. Update Employee Details");
                    Console.WriteLine("5. Delete Employee");
                    Console.WriteLine("6. Exit");
                    Console.WriteLine("====================================");
                    Console.Write("Enter your choice: ");

                    int choice = Convert.ToInt16((Console.ReadLine()));

                    Operation op = null;

                    switch (choice)
                    {
                        case 1:
                            op = Employee.AddEmployee;
                            break;
                        case 2:
                            op = Employee.ViewEmployees;
                            break;
                        case 3:
                            op = Employee.SearchEmployee;
                            break;
                        case 4:
                            op = Employee.UpdateEmployee;
                            break;
                        case 5:
                            op = Employee.DeleteEmployee;
                            break;
                        case 6:
                            return;
                        default:
                            Console.WriteLine("Invalid choice!");
                            break;
                    }

                    op?.Invoke();
                }
            }
        }
    }
}