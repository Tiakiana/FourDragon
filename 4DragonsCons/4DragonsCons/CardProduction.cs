using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4DragonsCons
{
    class CardProduction : ICard
    {
        public int cost
        {
            get;

            set;
        }
        public CardProduction(Town own) {
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
            owner.SetMaterial(1);
            foreach (ICard item in owner.GetAssets())
            {
                item.OnProduction();
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
