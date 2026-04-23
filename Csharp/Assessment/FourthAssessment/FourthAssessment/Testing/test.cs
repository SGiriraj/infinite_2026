using NUnit.Framework;
using FourthAssessment;
using NUnit.Framework.Legacy;
using System;

namespace FourthAssessment.Testing
{
    [TestFixture]
    public class TestDistance
    {
        private IDistanceAdder adder;

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setting up Distance Adder...");
            adder = new SimpleDistanceAdder();
        }

        [Test]
        public void Distance_Object_ShouldStoreCorrectValue()
        {
            Console.WriteLine("Running Test: Distance_Object_ShouldStoreCorrectValue");

            var d = new Distance(10);
            Console.WriteLine($"Created Distance with value: {d.Kilometer}");

            ClassicAssert.AreEqual(10, d.Kilometer);

            Console.WriteLine("Test Passed");
        }

        [Test]
        public void Add_TwoDistances_ReturnsCorrectSum()
        {
            Console.WriteLine("Running Test: Add_TwoDistances_ReturnsCorrectSum");

            var d1 = new Distance(20);
            var d2 = new Distance(30);

            Console.WriteLine($"Distance 1: {d1.Kilometer}");
            Console.WriteLine($"Distance 2: {d2.Kilometer}");

            var result = adder.Add(d1, d2);

            Console.WriteLine($"Result Distance: {result.Kilometer}");

            ClassicAssert.AreEqual(50, result.Kilometer);

            Console.WriteLine("Test Passed");
        }

        [TestCase(10, 20, 30)]
        [TestCase(5, 5, 10)]
        [TestCase(0, 50, 50)]
        public void Add_WithParameters_ReturnsExpectedResult(int km1, int km2, int expected)
        {
            Console.WriteLine("Running Parameterized Test");
            Console.WriteLine($"Input1: {km1}, Input2: {km2}, Expected: {expected}");

            var result = adder.Add(new Distance(km1), new Distance(km2));

            Console.WriteLine($"Actual Result: {result.Kilometer}");

            ClassicAssert.AreEqual(expected, result.Kilometer);

            Console.WriteLine("Test Passed");
        }
    }
}