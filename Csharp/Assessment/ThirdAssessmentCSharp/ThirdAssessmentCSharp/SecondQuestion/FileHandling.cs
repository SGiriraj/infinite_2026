using System;
using System.IO;

namespace ThirdAssessmentCSharp.SecondQuestion
{
    public class FileHandling
    {
        public void Write()
        {
            string filePath = @"C:\DotNet\CSharp\Csharp\Assessment\ThirdAssessmentCSharp\ThirdAssessmentCSharp\SecondQuestion\data.txt";

            Console.Write("Enter text to append: ");
            string text = Console.ReadLine();

            using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(text);
            }

            Console.WriteLine("\nText appended successfully!");

            Console.WriteLine("\nFinal File Content:\n");

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (StreamReader sr = new StreamReader(fs))
            {
                string content = sr.ReadToEnd(); 
                Console.WriteLine(content);
            }
        }
    }
}