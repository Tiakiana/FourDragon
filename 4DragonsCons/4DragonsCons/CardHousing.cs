using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4DragonsCons
{
    class CardHousing : ICard
    {
        public int cost
        {
            get;

            set;
        }

        public CardHousing(Town own)
        {

            owner = own;
            cost = 3;
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
            owner.SetFood(-1);
            owner.SetPopulation(1);
            owner.GetOngoing().Remove(this);
            owner.GetAssets().Add(this);
            Console.WriteLine("Housing built in " + owner.GetName());
           
        }

        public void OnDraw()
        {
            this.owner.GetOngoing().Add(this);
            this.owner.GetProjects().Remove(this);
        }



        public void OnProduction()
        {
        }

        public void OnRelation()
        {
            //throw new NotImplementedException();
        }

        public void OnResearch()
        {
          //  throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Housing";
        }
    }
}
