using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TypingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleView welcome = new ConsoleView();
            welcome.PrintWelcome();

                     
            string sentence1 = "The quick brown fox jumped over the lazy dog?";

            //print out output
            Console.WriteLine(sentence1);
            var now = DateTime.Now.TimeOfDay;
            //input
            var sentence = Console.ReadLine();
            var end = DateTime.Now.TimeOfDay;
            Console.WriteLine("--------------------------------------------------------------------");
     
            var elasped = end - now;
            var currentTime = elasped.Seconds + ":" + elasped.Milliseconds;

            var countMistakes = 0;

            var sentenceToWords = sentence1.Split();
            var sentenceToWords1 = sentence.Split();


            if (sentenceToWords.Length == sentenceToWords1.Length)
            {
                for (int i = 0; i < sentenceToWords.Length; i++)
                {
                    if (sentenceToWords[i] != sentenceToWords1[i])
                    {
                        countMistakes++;
                    }
                }
            }

            


            if(sentence.Length == sentence1.Length)
            {
                if (sentence.Equals(sentence1) == false)
                {
                    Console.WriteLine("Sorry {0}, you have made {1} mistake.", welcome.UserName, countMistakes);
                    Console.WriteLine("Your current time: " + currentTime);
                    Console.ReadLine();
                }
                else Console.WriteLine("Well done {0}! You made zero mistakes.", welcome.UserName);
                Console.WriteLine("Your current time: " + currentTime);
                Console.ReadLine();
            }

            Console.WriteLine("Sorry {0}, Please try again. Input was invalid", welcome.UserName);
            Console.WriteLine("Your current time: " + currentTime);
            Console.ReadLine();

        }
    }
}
