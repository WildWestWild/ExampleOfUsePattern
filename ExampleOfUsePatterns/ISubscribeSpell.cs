using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfUsePatterns
{
    interface ISubscribeSpell
    { 
        int CountSpell { get; set; }

        void inPanel(int count);
    }
}
