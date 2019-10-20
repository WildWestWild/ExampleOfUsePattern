using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfUsePatterns
{
    class ArmsWarrior : IBornClass
    {
        // Внедрение зависимости
        AbilityHoldingAxe _myAxe;
        public ArmsWarrior(AbilityHoldingAxe myAxe)
        {
            _myAxe = myAxe;
        }
        public void Attack(string weapon)
        {
            _myAxe.HoldingAxe(weapon);
            ArmsWarrior warrior = new ArmsWarrior(_myAxe);
            ClassAdapter newSpec = new ClassAdapter(warrior);
            newSpec.BattleCry();
            //myAxe = new CrashAxeInHands(myAxe);
        }
        public void Row()
        {
            Console.WriteLine("I am ArmsWarrior!");
           
        }
    }
}
