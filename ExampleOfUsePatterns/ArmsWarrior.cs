using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfUsePatterns
{
    class ArmsWarrior : IBornClass
    {
        AxeInHands myAxe = new AxeInHands();
        public void Attack(string weapon)
        {
            myAxe.HoldingAxe(weapon);
            //myAxe = new CrashAxeInHands(myAxe);
        }
        public void Row()
        {
            Console.WriteLine("I am ArmsWarrior!");
        }
        
        
    }
}
