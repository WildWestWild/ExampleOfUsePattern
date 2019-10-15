using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfUsePatterns
{
    class BookSpell : IManageSpellPanel
    {
        public List<ISubscribeSpell> bookSpellList = new List<ISubscribeSpell>();
        public BookSpell()
        {
            AddSpellOnPanel(new FireBall());
            AddSpellOnPanel(new FrostArrow());
            AddSpellOnPanel(new ArcaneBolt());
            AddSpellOnPanel(new Levitation());
            AddSpellOnPanel(new BlockOfIce());
        }
        public void AddSpellOnPanel(ISubscribeSpell spell)
        {
            bookSpellList.Add(spell);
        }

        public void DeleteSpellOnPanel(ISubscribeSpell spell)
        {
            bookSpellList.Remove(spell);
        }

        public void showSpellPanel()
        {
            Console.WriteLine("Книга заклинаний! Полный список магии тут.");
            Console.WriteLine("----------------------------------------------");
            int countSpell = 0;
            foreach (var spell in bookSpellList)
            {
                countSpell++;
                spell.inPanel(countSpell);
            }
            Console.WriteLine("----------------------------------------------");
        } 
    }

    class FireBall : ISubscribeSpell
    {
        public int CountSpell { get => countSpell; set => countSpell = value; }
        private int countSpell;

        public void inPanel(int count)
        {
            CountSpell = count;
            Console.WriteLine("{0}. FireBall", CountSpell);
        }
    }

    class FrostArrow : ISubscribeSpell
    {
        public int CountSpell { get => countSpell; set => countSpell = value; }
        private int countSpell;

        public void inPanel(int count)
        {
            CountSpell = count;
            Console.WriteLine("{0}. FrostArrow", CountSpell);
        }
    }
    class ArcaneBolt : ISubscribeSpell
    {
        public int CountSpell { get => countSpell; set => countSpell = value; }
        private int countSpell;

        public void inPanel(int count)
        {
            CountSpell = count;
            Console.WriteLine("{0}. ArcaneBolt", CountSpell);
        }
    }
    class Levitation : ISubscribeSpell
    {
        public int CountSpell { get => countSpell; set => countSpell = value; }
        private int countSpell;

        public void inPanel(int count)
        {
            CountSpell = count;
            Console.WriteLine("{0}. Levitation", CountSpell);
        }
    }
    class BlockOfIce : ISubscribeSpell
    {
        public int CountSpell { get => countSpell; set => countSpell = value; }
        private int countSpell;
        public void inPanel(int count)
        {
            CountSpell = count;
            Console.WriteLine("{0}. BlockOfIce", CountSpell);
        }
    }
    
}
