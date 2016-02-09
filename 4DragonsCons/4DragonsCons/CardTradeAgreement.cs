using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4DragonsCons
{
    class CardTradeAgreement : ICard
    {
        public CardMakeTrade maketrade;

        public int cost
        {
            get;

            set;
        }

        public CardTradeAgreement(Town own, Town oth)
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
            owner.GetAssets().Add(this);
            owner.GetOngoing().Remove(this);
            CardMakeTrade maketr = new CardMakeTrade(owner, other);
            owner.GetDecisions().Add(maketr);
            //Console.WriteLine(owner.GetName() + " trades with " + other.GetName() + " for 1 " ");

            
          //  owner.GetRelations().Find(item => item.GetOther() == other).SetRelationship(-1);

            

        }

        public void OnDraw()
        {

            owner.GetOngoing().Add(this);
            owner.GetProjects().Remove(this);
         //   owner.GetProjects().Insert(Randomizer.rnd.Next(0, owner.GetProjects().Count), this);

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
            return "a trade agreement with " + other.GetName();
        }
    }
}
