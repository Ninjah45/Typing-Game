using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingGame
{
    public class ConsoleView
    {
        public string UserName { get; set; }
        public string[] SentenceToWords { get; set; }
        public string[] SentenceToWordsCompare { get; set; }

        public void PrintWelcome()
        {
            Console.WriteLine("Welcome to The Typing Game. Press enter to start. ");
            Console.Write("Please Enter your name: ");
            UserName = Console.ReadLine();

        }
        public void MistakesMade()
        {
            int counter = 0;

            if (SentenceToWords.Length == SentenceToWordsCompare.Length)
            {
                for (int i = 0; i < SentenceToWords.Length; i++)
                {
                    if (SentenceToWords[i] != SentenceToWordsCompare[i])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine("Sorry {0}, you have made {1} mistake.", UserName, counter);
            Console.WriteLine("Your current time: " + currentTime);
            Console.ReadLine();

        }
        
    }
}
