using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfUsePatterns
{
    class Controller : Mediator
    {
        public Dependence SpellPannel { get; set; }
        public Dependence EditorIconPannel { get; set; }
        public override void Send(string mes, Dependence dependence)
        {
            if (SpellPannel == dependence)
                EditorIconPannel.Trigger(mes);
            else{
                SpellPannel.Trigger(mes);
            }
        }
    }
}
