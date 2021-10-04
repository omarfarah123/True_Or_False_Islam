using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace True_Or_False_Islam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 'True or False Quiz Islam Edition?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            //Tools.SetUpInputStream(entry);

            // Type your code below
            string[] questions = { "The Prophet Muhammad is the greatest man to walk the earth", "The Quran Preserved to the letter", "Islam the fastest growing religoin on earth", "Islam support terrorism", "Islam is an Arabic Religion" };
            bool[] answers = { true, true, true, false, false };
            bool[] responses = new bool[5];

            int askingIndex = 0;

            foreach (string question in questions)
            {
                bool inputBool;
                Console.WriteLine(question);
                Console.WriteLine("True or False?");
                string input = Console.ReadLine();
                bool isBool = Boolean.TryParse(input, out inputBool);
                while (isBool == false)
                {
                    Console.WriteLine(question);
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }
                responses[askingIndex] = inputBool;
                askingIndex++;
            }
           
            int scoringIndex = 0;
            int score = 0;

            foreach (bool answer in answers)
            {
                bool response = responses[scoringIndex];
                Console.WriteLine($"Input  {response} | Answer {answer}");
                if (response == answer)
                {
                    score++;
                }
                scoringIndex++;
            }
            Console.WriteLine($"You got {score} out of {scoringIndex} correct!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();

        }
    }
}
