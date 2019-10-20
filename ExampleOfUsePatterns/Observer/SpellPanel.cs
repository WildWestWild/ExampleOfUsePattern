using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfUsePatterns
{
    class SpellPanel : Dependence, IManageSpellPanel 
    {
        Dependence _editor;
        public List<ISubscribeSpell> spellPannelList;
        public SpellPanel(Mediator mediator, Dependence editor) : base(mediator)
        {
            spellPannelList = new List<ISubscribeSpell>();
            _editor = editor;
        }
        public void AddSpellOnPanel(ISubscribeSpell spell)
        {
            spellPannelList.Add(spell);
            _editor.Send("Добавление иконки на панель");
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

        public override void Trigger(string mes)
        {
            Console.WriteLine("Панель заклинаний: " + mes);
        }
    }
}
