using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfUsePatterns
{
   
    class FacrotyWarrior : ClassFactory
    {
        public override IBornClass FactoryMethodClass()
        {
            return new ArmsWarrior(); // Создаём AmrsWarrior
        }

        public override IBornRace FactoryMethodRace()
        {
            return new HumanRace();
        }
    }
}
