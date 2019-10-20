using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfUsePatterns
{
    class CrashAxeInHands : AbilityHoldingAxeDecorator
    {
        public CrashAxeInHands(AbilityHoldingAxe parent) : base(parent)
        {
            // Вызывается родительская реализация класса
        }
        public void DoHit()
        {
            if (IsHoldingAxe) // Если в руках топор
            {
                Console.WriteLine("Удар топором");
            }
            else
            {
                Console.WriteLine("В руках должен быть топор!");
            }
        }

        public override void HoldingAxe(string axe)
        {
            ability.HoldingAxe(axe);
        }
    }
}
