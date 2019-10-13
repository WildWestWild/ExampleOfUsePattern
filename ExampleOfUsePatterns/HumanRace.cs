using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfUsePatterns
{
    class HumanRace : IBornRace
    {
        public void MyRaceIs()
        {
            Console.WriteLine("Human is my race!");
        }
    }
}
