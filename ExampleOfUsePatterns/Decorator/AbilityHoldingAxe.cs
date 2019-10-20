using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfUsePatterns
{
    abstract class AbilityHoldingAxe
    {
        protected bool IsHoldingAxe;
        public abstract void HoldingAxe(string axe);     
    }
}
