using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4DragonsCons
{
    class CardWorsenRelationship : ICard
    {
        public int cost
        {
            get;

            set;
        }

        public CardWorsenRelationship(Town own)
        {

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

            //Mangler implementering
            return "Worsen relationship to ";
        }

    }
}
