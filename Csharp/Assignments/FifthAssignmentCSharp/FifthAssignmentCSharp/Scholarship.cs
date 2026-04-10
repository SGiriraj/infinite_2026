using System;
public class InvalidMarksException : Exception
{
    public InvalidMarksException(string message) : base(message)
    {
    }
}
public class Scholarship
{
    public double Merit(int marks, double fees)
    {
        if (marks < 0 || marks > 100)
            throw new InvalidMarksException("Marks should be between 0 and 100");

        if (marks >= 70 && marks <= 80)
            return fees * 0.20;

        else if (marks > 80 && marks <= 90)
            return fees * 0.30;

        else if (marks > 90)
            return fees * 0.50;

        else
            throw new InvalidMarksException("Not eligible for scholarship");
    }
}