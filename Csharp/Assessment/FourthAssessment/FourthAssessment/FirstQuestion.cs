using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
//1. Write a class Distance that has int Kilometer as its member.
//Write a function that adds 2 Distance objects and sums up in the 3rd.
//Display the 3rd object details. Create a Test class to execute the above.

namespace FourthAssessment
{
    public interface IDistanceAdder
    {
        Distance Add(Distance d1, Distance d2);
    }
    public class SimpleDistanceAdder : IDistanceAdder
    {
        public Distance Add(Distance d1, Distance d2)
        {
            return new Distance(d1.Kilometer + d2.Kilometer);
        }
    }
    public class Distance
    {
        public int Kilometer { get; }

        public Distance(int km)
        {
            Kilometer = km;
        }

        public void Display()
        {
            Console.WriteLine($"Distance: {Kilometer} km");
        }
    }

    internal class FirstQuestion
    {
        private readonly IDistanceAdder _adder;
        public FirstQuestion(IDistanceAdder adder)
        {
            _adder = adder;
        }

        public void Run()
        {
            Console.WriteLine("Read the distance:");
            int dis1 = Convert.ToInt32(Console.ReadLine());
            int dis2 = Convert.ToInt32(Console.ReadLine());
            Distance d1 = new Distance(dis1);
            Distance d2 = new Distance(dis2);

            Distance d3 = _adder.Add(d1, d2);
            d3.Display();

        }

        public static void Main(string[] args)
        {
            // Inject dependency via constructor
            FirstQuestion test = new FirstQuestion(new SimpleDistanceAdder());
            test.Run();
        }
    }
}
