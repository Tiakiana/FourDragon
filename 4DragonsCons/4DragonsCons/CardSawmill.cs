using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4DragonsCons
{
    class CardSawmill : ICard
    {
        bool Researched = false;
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
            owner.GetOngoing().Remove(this);
            owner.GetAssets().Add(this);
            Console.WriteLine("Sawmill Built in " + owner.GetName());
        }

        public void OnDraw()
        {
            
            if ( Researched)
            {

                this.owner.GetOngoing().Add(this);
                this.owner.GetProjects().Remove(this);
            }
            else
            {
                Researched = true;
                owner.GetProjects().Add(this);
                owner.GetDiscoveries().Remove(this);
            }

        }

        public void OnProduction()
        {
            owner.SetMaterial(1);
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
            return "Sawmill";
        }
    }
}
