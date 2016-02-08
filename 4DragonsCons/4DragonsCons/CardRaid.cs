using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4DragonsCons
{
    class CardRaid : ICard
    {
        public int cost
        {
            get;

            set;
        }

        public CardRaid(Town own, Town oth)
        {

            owner = own;
            other = oth;
            cost = 4;
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
            owner.GetOngoing().Remove(this);
            int raid = Randomizer.rnd.Next(1,7) + 3;
            other.SetMaterial(-raid);
            owner.SetMaterial(raid);
            owner.SetDiscovery(Randomizer.rnd.Next(1,4));
            Console.WriteLine(owner.GetName() + " raids " + other.GetName() + " for " + raid + " materials!");
            if (other.GetMaterial()<0)
            {
                //Console.WriteLine(other.GetName() + "'s material is now at " + other.GetMaterial());
                int amount = 0 + other.GetMaterial();
                other.SetMaterial(-amount);
               // Console.WriteLine(other.GetName() + "'s material is now at " + other.GetMaterial());

            }
            owner.GetRelations().Find(item => item.GetOther() == other).SetRelationship(1);
          

        }

        public void OnDraw()
        {

            owner.GetOngoing().Add(this);
            owner.GetProjects().Remove(this);
            owner.GetProjects().Insert(Randomizer.rnd.Next(0, owner.GetProjects().Count),this);

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
            return "a raid against" + other.GetName();
        }
    }
}
