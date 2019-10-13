using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfUsePatterns
{
    abstract class AbilityHoldingAxeDecorator : AbilityHoldingAxe
    {
        protected AbilityHoldingAxe ability;


        public AbilityHoldingAxeDecorator(AbilityHoldingAxe ability)
        {
            this.ability = ability; // Присваем декоратору ссылку на объект производного класса
        }

        /* public override void HoldingAxe(string axe)
        {
            if (ability != null)
            {
                ability.HoldingAxe(axe);
            }
        }
        */
    }
}
