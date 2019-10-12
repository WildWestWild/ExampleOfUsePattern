using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfUsePatterns
{
    class TheGame
    {
        private static TheGame singleton = null;

        protected TheGame()
        {
            // Уровень доступа к конструктору позволит вызывать его лишь из метода StartGame, который в свою очередь будет проверять на наличие уже существующего объекта
        }

        public static TheGame StartGame()
        {
            if (singleton == null)
            {
                singleton = new TheGame();
            }
            return singleton;
        }
    }
}
