using System;

namespace FifthAssignmentCSharp
{
    internal class ExceptionHandling
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter Initial Balance: ");
                double initialBalance = Convert.ToDouble(Console.ReadLine());

                BankAccount acc = new BankAccount(initialBalance);

                Console.Write("Enter Deposit Amount: ");
                double deposit = Convert.ToDouble(Console.ReadLine());
                acc.Deposit(deposit);

                Console.Write("Enter Withdraw Amount: ");
                double withdraw = Convert.ToDouble(Console.ReadLine());
                acc.Withdraw(withdraw);

                acc.ShowBalance();
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine("Custom Exception: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Argument Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter numbers only.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Error: " + ex.Message);
            }

            Console.WriteLine("========== Second Question ===============");

            try
            {
                Console.Write("Enter Marks: ");
                int marks = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Fees: ");
                double fees = Convert.ToDouble(Console.ReadLine());

                Scholarship s = new Scholarship();
                double amount = s.Merit(marks, fees);

                Console.WriteLine("Scholarship Amount: " + amount);
            }
            catch (InvalidMarksException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter correct values.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Error: " + ex.Message);
            }
        }
    }
}