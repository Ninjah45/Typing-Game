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

        public GameController()
        {
            _view = new ConsoleView();
            _sentence = new Sentence();
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

        public int Mistakes()
        {
            
                for (int i = 0; i < sentenceToWords.Length; i++)
                {
                    if (sentenceToWords[i] != sentenceToWords1[i])
                    {
                        countMistakes++;
                    }
                }

                return 0;
            }
            
        }
    }

