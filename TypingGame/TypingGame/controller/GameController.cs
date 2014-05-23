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
        public int TotalMistakes { get; set; }
        public int TotalSentenceLength { get; set; }
        

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
                    _sentence.StartSentenceGame(_view, new GameController(),_sentencedb);
                    break;   
            }
        }

        public void ResetCounters()
        {
            TotalMistakes = 0;
            TotalSentenceLength = 0;
        }             
    }
}

