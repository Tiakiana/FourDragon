using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4DragonsCons
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game();
            g.StartGame(5);
            g.towns[0].SetName("Wishmerhill");
            g.towns[1].SetName("Vynnengael");
            g.towns[2].SetName("Arunama");
            g.towns[3].SetName("Oana");
            g.RunGame();

            
        }
    }
}
