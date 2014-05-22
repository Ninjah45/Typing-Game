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
            Timer time = new Timer();
            Console.WriteLine("Welcome to The Typing Game. Press enter to start. ");
            Console.WriteLine("Please Enter your name:");
            var username = Console.ReadLine();
            time.Start();
            string sentence1 = "The quick brown fox jumped over the lazy dog?";

            //print out output
            Console.WriteLine(sentence1);

            //input
            var sentence = Console.ReadLine();

            Console.WriteLine("--------------------------------------------------------------------");

            if (sentence.Equals(sentence1) == false)
            {
                Console.WriteLine("Sorry {0}, you have made at least one mistake.", username);
                Console.ReadLine();
            }
            else Console.WriteLine("Well done {0}! You made zero mistakes.", username);





        }
    }
}
