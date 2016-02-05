using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4DragonsCons
{
    class CardHunter : ICard
    {

        public int cost
        {
            get;

            set;
        }

        public CardHunter(Town own)
        {

            owner = own;
            cost = 5;
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
            owner.SetFood(1);
            owner.GetOngoing().Remove(this);
            owner.GetAssets().Add(this);
            Console.WriteLine("Hunter built");
            CardHousing ch = new CardHousing(owner);
            owner.GetProjects().Add(ch);
        }

        public void OnDraw()
        {



            this.owner.GetOngoing().Add(this);
            this.owner.GetProjects().Remove(this);

        }

        public void OnProduction()
        {
        }

    }
}
