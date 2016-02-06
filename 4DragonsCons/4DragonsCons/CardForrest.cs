﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4DragonsCons
{
    class CardForrest : ICard
    {
        public int cost
        {
            get;

            set;
        }

        public CardForrest(Town own)
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
            owner.GetAssets().Add(this);
            owner.GetDiscoveries().Remove(this);
            CardHunter chh = new CardHunter(owner);
            owner.GetProjects().Add(chh);
            CardSawmill cs = new CardSawmill(owner);
            owner.GetDiscoveries().Add(cs);



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
            return "Forrest";
        }
    }
}
