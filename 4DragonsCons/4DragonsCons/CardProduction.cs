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
            //throw new NotImplementedException();
        }

        public void OnDraw()
        {
            owner.SetMaterial(1);
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
            return "Production";
        }

        
    }
}
