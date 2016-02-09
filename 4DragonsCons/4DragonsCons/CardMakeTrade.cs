using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4DragonsCons
{
    class CardMakeTrade : ICard
    {
        public Town other { get; set; }

        public int cost
        {
            get;
            set;
        }
        public CardMakeTrade(Town own, Town oth)
        {
            owner = own;
            other = oth;
        }
        public int name
        {
            get; set;
        }

        public Town owner
        {
            get; set;
        }



        public void OnComplete()
        {
        }

        public void OnDraw()
        {
            Console.WriteLine(owner.GetName() + " trades with " + other.GetName() );
            switch (Randomizer.rnd.Next(1, 3))
            {
                case 1:
                    owner.SetMaterial(1);
                    other.SetDiscovery(1);
                    break;
                case 2:
                    owner.SetDiscovery(1);
                    other.SetMaterial(1);
                    break;

                default:
                    break;
            }
        }

        public void OnProduction()
        {
        }

        public void OnRelation()
        {
        }

        public void OnResearch()
        {
        }

        public override string ToString()
        {
            return "Production";
        }

    }
}
