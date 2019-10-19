using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfUsePatterns
{
    class EditorIconPannel : Dependence
    {
        public EditorIconPannel(Mediator mediator) : base(mediator)
        {
        }

        public override void Trigger(string mes)
        {
            Console.WriteLine("Иконка: " + mes);
        }
    }
}
