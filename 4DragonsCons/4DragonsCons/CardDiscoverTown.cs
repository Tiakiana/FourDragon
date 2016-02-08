using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4DragonsCons
{
    class CardDiscoverTown : ICard
    {

        public int cost
        {
            get;

            set;
        }

        public CardDiscoverTown(Town own, Town oth)
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
        public Town other { get; set; }

        public void OnComplete()
        {

        }

        public void OnDraw()
        {

            if (owner.GetRelations().Count == 0)
            {
                CardWorsenRelationship cwr = new CardWorsenRelationship(owner), cwr2 = new CardWorsenRelationship(owner);
                owner.GetDecisions().Add(cwr);
                owner.GetDecisions().Add(cwr2);

                CardImproveRelation cir = new CardImproveRelation(owner), cir2 = new CardImproveRelation(owner);
                owner.GetDecisions().Add(cir);
                owner.GetDecisions().Add(cir2);
                Console.WriteLine(owner.GetName() + " has discovered " + other.GetName());

            }

            Relation rl = new Relation(owner,other);
            owner.GetRelations().Add(rl);
            owner.GetDiscoveries().Remove(this);
            

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
            return other.GetName();
        }
    }
}

