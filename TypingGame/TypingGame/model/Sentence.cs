using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingGame
{
    public class Sentence
    {
        public string SentenceString { get; set; }
        public int SentenceLength { get; set; }
        public int Difficulty { get; set; }
        

        public Sentence()
        {
            Difficulty = 1;
        }

        public TimeSpan StartTimer()
        {
            var now = DateTime.Now.TimeOfDay;
            return now;
        }

        public TimeSpan EndTimer()
        {
            var end = DateTime.Now.TimeOfDay;
            return end;
        }

        public void StartSentenceGame(ConsoleView _view, GameController controller, SentenceDB _sentencedb)
        {
            _view.Countdown();
            TimeSpan startTime = StartTimer();
            int wordCounter = 1;

            while (wordCounter <= 5)
            {
                Sentence sentence1 = _sentencedb.GetRandomSentence(Difficulty);
                string randomSentence = sentence1.SentenceString;
                controller.TotalSentenceLength += sentence1.SentenceLength;

                _view.PrintSentence(wordCounter, randomSentence);
                string sentence = Console.ReadLine();
                string[] sentenceArray = sentence.Split(' ');

                int mistakes = GetMistakes(sentenceArray, randomSentence);

                controller.TotalMistakes += mistakes;
                Console.WriteLine("Number of mistakes: " + mistakes);
                Console.WriteLine();
                wordCounter++;
            }
            TimeSpan endTime = EndTimer();
            TimeSpan elapsedTime = endTime - startTime;

            _view.EndGamePrinter(elapsedTime, controller.TotalMistakes, controller.TotalSentenceLength);
            
            Console.Clear();
            StartSentenceGame(_view, new GameController(), _sentencedb);
        }

        /// <summary>
        /// Get number of mistakes made in a single sentence
        /// </summary>
        /// <param name="sentenceArrayInput">Input typed by the user</param>
        /// <param name="sentenceFromDb">Random sentence from the DB to compare user input to</param>
        /// <returns>Int number of mistakes</returns>
        public int GetMistakes(string[] sentenceArrayInput, string sentenceFromDb)
        {
            string[] sentenceFromDbArray = sentenceFromDb.Split(' ');
            int countMistakes = 0;

            for (int i = 0; i < sentenceArrayInput.Length; i++)
            {
                if (sentenceArrayInput[i] != sentenceFromDbArray[i])
                {
                    countMistakes++;
                }
            }

            return countMistakes + (sentenceFromDbArray.Length - sentenceArrayInput.Length);
        }

    }
}