using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfUsePatterns
{
    interface IBornClass
    {
        void Row(); // Какой класс
    }
    interface IBornRace
    {
        void MyRaceIs(); // Какая расса
    }
    abstract class ClassFactory
    {
        public abstract IBornClass FactoryMethodClass();
        public abstract IBornRace FactoryMethodRace();
    }
}
