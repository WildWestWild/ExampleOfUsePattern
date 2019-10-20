using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfUsePatterns
{
    class ClassAdapter : ArmsWarrior, IRaging
    {
        private ArmsWarrior armsWarrior;

        //Реализация кастомного конструктора
        public ClassAdapter(ArmsWarrior armsWarrior) : base (myAxe)
        {
            this.armsWarrior = armsWarrior;
        }

        public static AbilityHoldingAxe myAxe { get; private set; }

        public void BattleCry()
        {
            armsWarrior.Row();
        }
    }
}
