using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfUsePatterns
{
    class FactoryMage : ClassFactory
    {
        public override IBornClass FactoryMethodClass()
        {
            return new ArcaneMage();
        }

        public override IBornRace FactoryMethodRace()
        {
            return new HumanRace();
        }
    }
}
