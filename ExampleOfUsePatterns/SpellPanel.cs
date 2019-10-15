using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfUsePatterns
{
    class SpellPanel : IManageSpellPanel
    {
        public List<ISubscribeSpell> spellPannelList;
        public SpellPanel()
        {
            spellPannelList = new List<ISubscribeSpell>();
        }
        public void AddSpellOnPanel(ISubscribeSpell spell)
        {
            spellPannelList.Add(spell);
        }

        public void DeleteSpellOnPanel(ISubscribeSpell spell)
        {
            spellPannelList.Remove(spell);
        }

        public void showSpellPanel()
        {
            int countSpell = 0;
            foreach (var item in spellPannelList)
            {
                countSpell++;
                item.inPanel(countSpell);
            }
        }
    }
}
