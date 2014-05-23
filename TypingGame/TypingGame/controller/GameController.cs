using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingGame
{
    class GameController
    {
        ConsoleView _view;
        Sentence _sentence;

        public GameController()
        {
            _view = new ConsoleView();
            _sentence = new Sentence();
        }
    }
}
