using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4DragonsCons
{
    class CardResearch : ICard
    {
        public int cost
        {
            get;

            set;
        }

        public CardResearch(Town own) {

            owner = own;
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
            owner.SetDiscovery(1);
            foreach (ICard item in owner.GetAssets())
            {
               item.OnResearch();
            }
        }

        public void OnProduction()
        {
        }

        public void OnRelation()
        {
            throw new NotImplementedException();
        }

        public void OnResearch()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Research";
        }
    }
}
