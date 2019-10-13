using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfUsePatterns
{
    class ProtectionWarrior : IBornClass
    {
        public void Row()
        {
            Console.WriteLine("I am ProtectionWarrior!");
        }
    }
}
