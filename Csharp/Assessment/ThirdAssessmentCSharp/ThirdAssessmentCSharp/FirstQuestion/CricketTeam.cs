using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdAssessmentCSharp.FirstQuestion
{
    public class CricketTeam
    {
        public void Pointscalculation(int no_of_matches)
        {
            int[] scores = new int[no_of_matches];

            for (int i = 0; i < no_of_matches; i++)
            {
                Console.Write("Enter score for match " + (i + 1) + ": ");
                scores[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = scores.Sum();             
            double avg = scores.Average();       
            Console.WriteLine("\nTotal Matches played by  a team: " + no_of_matches);
            Console.WriteLine("Total Score scored overall the match: " + sum);
            Console.WriteLine("Average SCore amoung all the matches by a particular team: " + avg);
        }
    }
}
