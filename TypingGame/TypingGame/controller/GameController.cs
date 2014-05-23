using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TypingGame
{
    public class GameController
    {
        ConsoleView _view;
        Sentence _sentence;
        SentenceDB _sentencedb;
        public string[] SentenceToWords { get; set; }
        public string[] SentenceToWordsCompare { get; set; }
        public string StringDB { get; set; }
        public string Input { get; set; }

        public GameController()
        {
            _view = new ConsoleView();
            _sentence = new Sentence();
            _sentencedb = new SentenceDB();
        }

        public void StartGame()
        {
            _view.Menu();
            string menuSelect = Console.ReadLine();
            switch (menuSelect)
            {
                case "1":
                    _view.Countdown();
                    TimeSpan startTime = StartTimer();
                    int wordCounter = 1;
                    int totalMistakes = 0;
                    int totalSentenceLength = 0;

                    while (wordCounter <= 5)
                    {
                        List<Sentence> sentList = _sentencedb.GetSentence(1);
                        Random random = new Random();
                        Sentence sentence1 = sentList[random.Next(0, sentList.Count)];
                        string sent = sentence1.SentenceString;
                        totalSentenceLength += sentence1.SentenceLength;
                        _view.PrintSentence(wordCounter, sent);
                        string sentence = Console.ReadLine();
                        string[] sentenceArray = sentence.Split(' ');
                        int mistakes = Mistakes(sentenceArray, sent);
                        totalMistakes += mistakes;
                        Console.WriteLine("Number of mistakes: " + mistakes);
                        Console.WriteLine();
                        wordCounter++;
                    }
                    TimeSpan endTime = EndTimer();
                    TimeSpan elapsedTime = endTime - startTime;
                    
                    Console.WriteLine("Time elapsed:     " + (endTime - startTime).Seconds + ":" + (endTime - startTime).Milliseconds + " seconds");
                    Console.WriteLine("Total Mistakes:   " + totalMistakes);
                    Console.WriteLine("Words per minute: " + (int)(totalMistakes / (decimal)((decimal)(endTime - startTime).Seconds / 60)));
                    Console.WriteLine("Press enter to go back to menu");
                    Console.ReadLine();
                    Console.Clear();
                    StartGame();
                    /*
                    _view.timesUp();
                    _view.PrintScore();
                    _view.EnterName();
                    _view.HighscoresTable();
                     * */
                    break;
                    
            }
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

        public string CheckScore()
        {
            var nowSec = StartTimer().TotalSeconds;
            var endSec = EndTimer().TotalSeconds;
            var finalSec = endSec - nowSec;
            var nowMilli = StartTimer().TotalSeconds;
            var endMilli = EndTimer().TotalSeconds;
            var finalMilli = endMilli - nowMilli;
            return finalSec + ":" + finalMilli;
        }

        public int Mistakes(string[] sentenceArrayInput, string stringInput)
        {
            string[] inputArray = stringInput.Split(' ');
            int countMistakes = 0;


            for (int i = 0; i < sentenceArrayInput.Length; i++)
                {
                    if (sentenceArrayInput[i] != inputArray[i])
                    {
                        countMistakes++;
                    }
                }

            return countMistakes + (inputArray.Length - sentenceArrayInput.Length);
        }

                
    }
}

