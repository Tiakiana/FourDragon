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
        public Town other { get; set; }
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
            
            owner.GetRelations()[Randomizer.rnd.Next(0, owner.GetRelations().Count)].SetRelationship(-1);

            foreach (ICard item in owner.GetAssets())
            {
                item.OnRelation();
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

            //Mangler implementering
            return "Worsen Relation";
        }

    }
}
