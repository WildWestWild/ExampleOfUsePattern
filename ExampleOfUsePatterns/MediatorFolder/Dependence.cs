using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfUsePatterns
{
    abstract class Dependence
    {
        protected Mediator dependence;

        public Dependence(Mediator mediator)
        {
            dependence = mediator;
        }
        public virtual void Send(string mes)
        {
            dependence.Send(mes, this);
        }
        public abstract void Trigger(string mes);

    }
}
