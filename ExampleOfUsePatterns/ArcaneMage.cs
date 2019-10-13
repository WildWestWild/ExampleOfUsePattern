using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfUsePatterns
{
    class ArcaneMage : IBornClass
    {
        public void Attack(string weapon)
        {
            throw new NotImplementedException();
        }

        public void Row()
        {
            Console.WriteLine("I am Arcane Mage!");
        }
    }
}
