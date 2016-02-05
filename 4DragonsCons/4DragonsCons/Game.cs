using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4DragonsCons
{
   internal class Game
    {
        public List<Town> towns = new List<Town>();
        public void StartGame(int numberOfTowns) {
            for (int i = 0; i < numberOfTowns; i++)
            {
                Town t = new Town();
                towns.Add(t);

                foreach (Town item in towns)
                {
                    item.ReshuffleDeckDecision();
                }
             

            }

        }

        public string ShowTowns() {
            string s = "";
            foreach (Town item in towns)
            {
                s += "\n " + item.ToString();
            }
            return s;

        }

        public void TakeTurns() {
            foreach (Town item in towns)
            {
                Console.WriteLine( item.TakeTurn());
            }
        }


        public void RunGame() {
            int x = 10;
            Console.WriteLine("Game is currently running. Welcome DragonLord");

            while (x!= 0)
            {
                Console.WriteLine("What Is thy selection: ");
                Console.WriteLine("1: view status of towns.");
                Console.WriteLine("2: Next Turn");

                Console.WriteLine("0: end game");

                x = Int32.Parse(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        Console.WriteLine( ShowTowns());
                        break;
                    case 2:
                        TakeTurns();

                        break;
                    default:
                        break;
                }


            }



        }

    }
}
