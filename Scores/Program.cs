using System;
using System.Collections.Generic;
using System.Linq;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter in your first name: ");
            string name = Console.ReadLine();

            string date = DateTime.Today.ToShortDateString();
            string msg = $"\nWelcome back {name}!  Today is {date}.";

            Console.WriteLine(msg);

            string path = @"C:\Users\Ryan Wilson\Documents\TechAcademyRepos\TTA Basic C-Sharp Projects\Scores\Scores\studentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);
            double totalScore = 0;

            Console.WriteLine("\nStudent Scores:");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
                totalScore += Convert.ToDouble(line);
            }

            double avg = totalScore / lines.Length;
            Console.WriteLine($"Total of {lines.Length} scores.\tAverage: {avg}");

            Console.Write("\n\nPress any key to exit!");
            Console.ReadKey();
        }
    }
}
