using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4DragonsCons
{
    class CardSawmill : ICard
    {

        public int cost
        {
            get;

            set;
        }

        public CardSawmill(Town own)
        {

            owner = own;
            cost = 15;
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
            owner.GetDiscoveries().Remove(this);
            owner.GetProjects().Add(this);
        }

        public void OnProduction()
        {
            owner.SetMaterial(1);
        }
    }
}
