using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfUsePatterns
{
    class ClassAdapter : ArmsWarrior, IRaging
    {
        ArmsWarrior _warrior;
        //Реализация кастомного конструктора
        public ClassAdapter(ArmsWarrior warrior)
        {
            _warrior = warrior;
        }
        public void BattleCry()
        {
            _warrior.Row();
        }
    }
}
