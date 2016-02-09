using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4DragonsCons
{
    class Relation
    {
        Town owner { get; }
        Town other { get; }
        bool tradeAgreement { get; set; }

        int relationship { get; set; }

        public Relation(Town own, Town oth) {
            owner = own;
            other = oth;
            relationship = 0;
            tradeAgreement = false;
        }
        public Town GetOther() { return other; }

        public int GetRelationship() {
            return relationship;
        }
        public void SetRelationship(int chng) {
            relationship += chng;
            CheckRelation();

        }
        /*

            switch (true) {
  case (val < 1000): /* do something */ //break;
 // case (val< 2000): /* do something */ break;
 // ...
 // case (val< 30000): /* do something */ break;
//}

        public void CheckRelation() {
            if (relationship<-9)
            {
                //Make War!
            }
            else if (relationship<-1)
            {
                CardRaid cr = new CardRaid(owner, other);
                int range = Randomizer.rnd.Next(0, owner.GetProjects().Count);
                owner.GetProjects().Insert(range, cr);
                Console.WriteLine(owner.GetName() + " has started planning a raid against " + other.GetName());
                //owner.GetProjects().AddRange(owner.ShuffleThisDeck(owner.GetProjects()));


            }
            else if (relationship == 0)
            {
                // Neeeds Dem Fixation

                for (int i = 0; i < owner.GetOngoing().Count; i++)
                {
                    if (owner.GetOngoing()[i].GetType() == typeof(CardRaid))
                    {
                        owner.GetOngoing().RemoveAt(i);
                    }
                }
                for (int i = 0; i < owner.GetProjects().Count; i++)
                {
                    if (owner.GetProjects()[i].GetType() == typeof(CardRaid))
                    {
                        owner.GetProjects().RemoveAt(i);
                    }
                }
                for (int i = 0; i < owner.GetProjects().Count; i++)
                {
                    if (owner.GetProjects()[i].GetType() == typeof(CardTradeAgreement))
                    {
                        owner.GetProjects().RemoveAt(i);
                    }
                }
                for (int i = 0; i < owner.GetAssets().Count; i++)
                {
                    if (owner.GetAssets()[i].GetType() == typeof(CardTradeAgreement))
                    {
                        owner.GetAssets().RemoveAt(i);
                        
                    }
                }
                for (int i = 0; i < owner.GetDecisions().Count; i++)
                {
                    if (owner.GetDecisions()[i].GetType() == typeof(CardTradeAgreement))
                    {
                        owner.GetDecisions().RemoveAt(i);
                    }
                }


            }
            else if (relationship>1 && tradeAgreement == false)
            {
                //Put trade in
                Console.WriteLine(owner.GetName() + " wants to make trade agreement with  " + other.GetName());
                CardTradeAgreement cta = new CardTradeAgreement(owner, other);
                owner.GetProjects().Add(cta);
                tradeAgreement = true;
            }
            else if (relationship>9)
            {
                //Alliance
            }
            
        }

    }
}
