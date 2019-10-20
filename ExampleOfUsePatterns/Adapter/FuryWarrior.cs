using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfUsePatterns
{
    class FuryWarrior : IBornClass, IRaging
    {
        public void Attack(string weapon)
        {
            throw new NotImplementedException();
        }

        public void BattleCry()
        {
            Console.WriteLine("За Орду!");
        }

        public void Row()
        {
            Console.WriteLine("I am FuryWarrior!");
        }
    }
}
