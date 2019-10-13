using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfUsePatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            TheGame startWarrior = TheGame.StartGame(new FacrotyWarrior());

            TheGame startMage = TheGame.StartGame(new FactoryMage());
        }
    }
}
