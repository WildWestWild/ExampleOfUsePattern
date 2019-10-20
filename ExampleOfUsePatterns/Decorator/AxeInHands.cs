using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfUsePatterns
{
    class AxeInHands : AbilityHoldingAxe
    {
        public override void HoldingAxe(string axe)
        {
            if (axe == "Большой топор")
            {
                IsHoldingAxe = true;
                Console.WriteLine("Взять {0}", axe);
            }
            IsHoldingAxe = false;
        }
    }
}
