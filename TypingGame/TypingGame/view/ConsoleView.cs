using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingGame
{
    public class ConsoleView
    {
        public void Menu() //will need to change this to retrieve difficulty for future releases.
        {
            Console.WriteLine("|========================|");
            Console.WriteLine("|          TYPO          |");
            Console.WriteLine("|========================|");
            Console.WriteLine("|  Enter your option     |");
            Console.WriteLine("|                        |");
            Console.WriteLine("|  1. NEW GAME           |");
            Console.WriteLine("|  2. HIGHSCORE          |");
            Console.WriteLine("|  3. DIFFICULITY        |");
            Console.WriteLine("|                        |");
            Console.WriteLine("|========================|");
        }

        public void EndGamePrinter(TimeSpan elapsedTime, int totalMistakes, int totalSentenceLength)
        {
            Console.WriteLine("Time elapsed:     " + (elapsedTime).Seconds + ":" + (elapsedTime).Milliseconds + " seconds");
            Console.WriteLine("Total Mistakes:   " + totalMistakes);
            Console.WriteLine("Words per minute: " + (int)(totalSentenceLength / FormatElapsedTime(elapsedTime)));
            Console.WriteLine("Press enter to go back to menu");
            Console.ReadLine();
        }

        public float FormatElapsedTime(TimeSpan elapsedTimeInput)
        {
            return (float)(elapsedTimeInput.Seconds / 60);
        }

        public void Countdown()
        {
            
            int countdown = 3;
            Console.WriteLine("{0}...", countdown);
            System.Threading.Thread.Sleep(1000);
            countdown--;
            Console.WriteLine("{0}...", countdown);
            System.Threading.Thread.Sleep(1000);
            countdown--;
            Console.WriteLine("{0}...", countdown);
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
        }

        public void PrintSentence(int question, string sentence)
        {
            Console.WriteLine(question + ". " + sentence);
        }

        public void timesUp()
        {
            Console.WriteLine("TIMES UP!");
            System.Threading.Thread.Sleep(1000);
        }

        public void PrintScore(int score, int mistakes)
        {
            Console.WriteLine("You made {0} mistakes", mistakes);
            Console.WriteLine("You scored" + score);
            //sleep for 500ms??
        }

        public string EnterName()
        {
            Console.WriteLine("New highscore!");
            Console.WriteLine("Enter your name...");
            string name = Console.ReadLine();
            return name;
        }

        public void HighscoresTable(Dictionary<string, int> highscoretable) //will need to change this to retrieve difficulty for future releases.
        {/*
            Console.WriteLine("|======================================|");
            Console.WriteLine("|  High Scores                         |");
            Console.WriteLine("|======================================|");
            Console.WriteLine("|  1. " + highscoretable[0] + "        |");
            Console.WriteLine("|  2. " + highscoretable[1] + "        |");
            Console.WriteLine("|  3. " + highscoretable[2] + "        |");
            Console.WriteLine("|  4. " + highscoretable[3] + "        |");
            Console.WriteLine("|  5. " + highscoretable[4] + "        |");
            Console.WriteLine("|  6. " + highscoretable[5] + "        |");
            Console.WriteLine("|  7. " + highscoretable[6] + "        |");
            Console.WriteLine("|  8. " + highscoretable[7] + "        |");
            Console.WriteLine("|  9. " + highscoretable[8] + "        |");
            Console.WriteLine("| 10. " + highscoretable[9] + "        |");
            Console.WriteLine("|======================================|"); */
            //GET THE USERS SENTENCE INPUT?
        }
            }
}    