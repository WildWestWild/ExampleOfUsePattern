using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfUsePatterns
{
    class FactoryMage : ClassFactory
    {
        BookSpell bookSpell = new BookSpell();
        public override IBornClass FactoryMethodClass()
        {
            return new ArcaneMage(bookSpell);
        }
        public override IBornRace FactoryMethodRace()
        {
            return new HumanRace();
        }
    }
}
