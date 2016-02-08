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

             

            }
            AddTownsToDiscovery();

            foreach (Town item in towns)
            {
                item.ScrambleStartDeck();
            }
        }

        public void AddTownsToDiscovery() {
            if (towns.Count>1)
            {
                foreach (Town town in towns)
                {

                    List<Town> nl = new List<Town>();
                    nl.AddRange(towns);
                    nl.Remove(town);
                    foreach (Town othertown in nl)
                    {
                        CardDiscoverTown dt = new CardDiscoverTown(town, othertown);
                        town.GetDiscoveries().Add(dt);
                    }

                }
            }
        }

        public string ShowTowns() {
            string s = "";
            foreach (Town item in towns)
            {
                s += "\n" + item.ToString();
            }
            return s;

        }

        public void TakeTurns() {
            foreach (Town item in towns)
            {
                item.TakeTurn();
            }
        }


        public void RunGame() {
            Console.SetWindowSize(175,60);
          
            int x = 10;
            Console.WriteLine("Game is currently running. Welcome DragonLord");
            Console.WriteLine("What Is thy selection: ");
            while (x!= 0)
            {
               
                Console.WriteLine("1: view status of towns.");
                Console.WriteLine("2: Next Turn");

                Console.WriteLine("0: end game");
            Failed:
                try
                {
                    x = Int32.Parse(Console.ReadLine());

                }
                catch (Exception)
                {
                    Console.WriteLine("Oops wrong line");
                    goto Failed;
                                    }

                switch (x)
                {
                    case 1:
                        Console.WriteLine( ShowTowns());
                        break;
                    case 2:
                        TakeTurns();
                        break;
                    case 3:
                        if (towns[0].GetAssets().Count>0)
                        {
                            foreach (ICard item in towns[0].GetAssets())
                            {
                                Console.WriteLine(item.ToString());
                            }
                            Console.WriteLine();
                        }
                        if (towns[0].GetProjects().Count > 0) {
                            foreach (ICard item in towns[0].GetProjects())
                            {
                                Console.WriteLine(item.ToString());
                            }
                        }
                        if (towns[0].GetDiscoveries().Count > 0)
                        {
                            foreach (ICard item in towns[0].GetDiscoveries())
                            {
                                Console.WriteLine(item.ToString());
                            }
                        }
                        if (towns[0].GetDecisions().Count > 0)
                        {
                            foreach (ICard item in towns[0].GetDecisions())
                            {
                                Console.WriteLine(item.ToString());
                            }
                        }

                        break;
                    default:
                        break;
                }


            }



        }

    }
}
