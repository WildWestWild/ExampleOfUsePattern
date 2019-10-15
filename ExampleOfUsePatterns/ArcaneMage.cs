using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfUsePatterns
{
    class ArcaneMage : IBornClass
    {
        BookSpell _bookSpell;
        SpellPanel spellPanelList;
        private string enterLine;
        private int numberOfSpell;
        private int NumberOfSpell
        {
            get => numberOfSpell;
            set
            {
                if (value > 0 && value < 6)
                {
                    numberOfSpell = value;
                }
                else
                {
                    throw new Exception("No magic");
                }
            }
        }
        public void Attack(string weapon)
        {
            if (weapon == "Посох")
            {
                Console.WriteLine("Взмах посохом");
            }
        }
        public ArcaneMage(BookSpell bookSpell)
        {
            spellPanelList = new SpellPanel(); // Собственная панель способоностей
            bookSpell.showSpellPanel(); // Книга способностей
            _bookSpell = bookSpell;
        }
        public void Row()
        {
            Console.WriteLine("I am Arcane Mage!");
            Console.WriteLine("My spell panel");
            PickAnyChoise(); // Открытие панели
        }
        private int SelectSpell()
        {
            Console.WriteLine("Select number spell of bookSpell");
            
            string numberEnterLine = Console.ReadLine();
            try
            {
                NumberOfSpell = Convert.ToInt32(numberEnterLine);
                return NumberOfSpell;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private ISubscribeSpell returnNeedSpell(int countSpell , List<ISubscribeSpell> collection)
        {
            int length = collection.Count;
            for (int i = 0; i < length; i++)
            {
                int numberOfSpellInSpellPannel = collection[i].CountSpell;
                if (numberOfSpellInSpellPannel == countSpell)
                {
                    return collection[i];
                }
            }
            throw new Exception("No magic!");
        }
        private void PickAnyChoise()
        {
            do
            {
                Console.WriteLine("Pick any choise");
                Console.WriteLine("-----------------------");
                Console.WriteLine("1. Add Spell");
                Console.WriteLine("2. Remove Spell");
                Console.WriteLine("3. Show My Panel");
                Console.WriteLine("-----------------------");
                enterLine = Console.ReadLine();
                switch (enterLine)
                {
                    case "1": {
                            spellPanelList.AddSpellOnPanel(returnNeedSpell(SelectSpell(), _bookSpell.bookSpellList));
                        } break;
                    case "2": {
                            int index = SelectSpell();
                            spellPanelList.spellPannelList.RemoveAt(--index);
                        } break;
                    case "3": {
                            spellPanelList.showSpellPanel();
                        } break;
                }
            } while (enterLine == "1" || enterLine == "2" || enterLine == "3");
        }
    }
}
