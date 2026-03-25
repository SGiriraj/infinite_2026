using System;

namespace FirstAssignmentCSharp
{
    internal class First
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================First Question========================");

            Console.Write("First variable for checking Equal: ");
            int var1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Second variable for checking Equal: ");
            int var2 = Convert.ToInt32(Console.ReadLine());
            Question1 obj1 = new Question1();
            obj1.CheckingEqual(var1, var2);
            

            Console.WriteLine("===================Second Question=======================");

            Console.Write("Variable for Checking positive or negative: ");
            int var3 = Convert.ToInt32(Console.ReadLine());
            Question2 obj2 = new Question2();
            

            int sign = obj2.PositiveOrNegative(var3);
            string res = (sign == 1) ? "Positive" : (sign == -1 ? "Negative" : "Zero");

            Console.WriteLine($"{var3} is {res}");

            Console.WriteLine("===================Third Question=======================");

            Console.Write("Input First number: ");
            int firstnumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input Operation (+, -, *, /): ");
            char operation = Console.ReadLine()[0];

            Console.Write("Input Second number: ");
            int secondnumber = Convert.ToInt32(Console.ReadLine());
            Question3 obj3 = new Question3();
     


            Console.WriteLine("Result: " + obj3.Calulator(firstnumber, secondnumber, operation));

           

            Console.WriteLine("===================Fourth Question=======================");
            Question4 obj4 = new Question4();
            Console.Write("Enter the number: ");
            int multiplication = Convert.ToInt32(Console.ReadLine());


           
            obj4.Table(multiplication);


            Console.WriteLine("===================Fourth Question=======================");
            Question5 obj5 = new Question5();

            Console.WriteLine(obj5.SumOrTriple(var1, var2));
            Console.ReadKey();
        }
    }

    
}
