using System;
using System.IO;

namespace SixthAssignmentCSharp
{
    internal class FileHandler
    {
        string filePath = "sample.txt";

        string[] lines = {
            "Line 1: Hello",
            "Line 2: Welcome",
            "Line 3: File Handling",
            "Line 4: C# Programming"
        };

        public void ProcessFile()
        {
            
            FileStream fs = new FileStream(filePath, FileMode.Create);
            fs.Close();
            Console.WriteLine("File created!");

            FileStream fsWrite = new FileStream(filePath, FileMode.Append);
            StreamWriter sw = new StreamWriter(fsWrite);

            foreach (string line in lines)
            {
                sw.WriteLine(line);
            }

            sw.Close();
            fsWrite.Close();
            Console.WriteLine("Data written!");

            FileStream fsRead = new FileStream(filePath, FileMode.Open);
            StreamReader sr = new StreamReader(fsRead);

            Console.WriteLine("\nReading File:\n");

            string content;
            while ((content = sr.ReadLine()) != null)
            {
                Console.WriteLine(content);
            }

            sr.Close();
            fsRead.Close();

          
            Console.WriteLine("\nCounting lines...");

            FileStream fsCount = new FileStream(filePath, FileMode.Open);
            StreamReader srCount = new StreamReader(fsCount);

            int lineCount = 0;
            string line;

            while ((line = srCount.ReadLine()) != null)
            {
                lineCount++;
            }

            srCount.Close();
            fsCount.Close();

            Console.WriteLine("Total number of lines: " + lineCount);
        }
    }

    // 🔥 Main method (IMPORTANT)
    class Program
    {
        static void Main()
        {
            FileHandler fh = new FileHandler();
            fh.ProcessFile();

            Console.ReadLine();
        }
    }
}