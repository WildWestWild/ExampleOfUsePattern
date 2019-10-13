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

        protected TheGame(ClassFactory hero)
        {
            IBornClass heroClass = hero.FactoryMethodClass();
            IBornRace heroRace = hero.FactoryMethodRace();
            heroClass.Row();
            heroRace.MyRaceIs();
            // Уровень доступа к конструктору позволит вызывать его лишь из метода StartGame, который в свою очередь будет проверять на наличие уже существующего объекта
        }

        public static TheGame StartGame(ClassFactory hero)
        {
            if (singleton == null)
            {
                singleton = new TheGame(hero);
            }
            return singleton;
        }
    }
}
