using System;
//2. Report Generators. Let’s assume we have an analytics application allowing users to generate reports in different formats:
//Chart, Tabular, or Summary.
//Using the Factory Method pattern, instantiate the appropriate report generator based on the user’s selection

namespace FourthAssessment
{
    
    public interface IReportGenerator
    {
        void GenerateReport();
    }

    public class ChartReport : IReportGenerator
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generating Chart Report...");
        }
    }

    public class TabularReport : IReportGenerator
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generating Tabular Report...");
        }
    }

    public class SummaryReport : IReportGenerator
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generating Summary Report...");
        }
    }
    public abstract class ReportFactory
    {
        public abstract IReportGenerator CreateReport();
    }
    public class ChartReportFactory : ReportFactory
    {
        public override IReportGenerator CreateReport()
        {
            return new ChartReport();
        }
    }

    public class TabularReportFactory : ReportFactory
    {
        public override IReportGenerator CreateReport()
        {
            return new TabularReport();
        }
    }

    public class SummaryReportFactory : ReportFactory
    {
        public override IReportGenerator CreateReport()
        {
            return new SummaryReport();
        }
    }
    internal class SecondQuestion
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Select report type: Chart / Tabular / Summary");
            string choice = Console.ReadLine();

            ReportFactory factory;
            choice = choice.ToLower();

            switch (choice)
            {
                case "chart":
                    factory = new ChartReportFactory();
                    break;

                case "tabular":
                    factory = new TabularReportFactory();
                    break;

                case "summary":
                    factory = new SummaryReportFactory();
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    return;
            }

            IReportGenerator report = factory.CreateReport();
            report.GenerateReport();
        }
    }
}
