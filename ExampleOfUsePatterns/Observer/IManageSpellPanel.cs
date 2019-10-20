using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfUsePatterns
{
    interface IManageSpellPanel
    {
        void AddSpellOnPanel(ISubscribeSpell spell);

        void DeleteSpellOnPanel(ISubscribeSpell spell);

        void showSpellPanel();
    }
}
