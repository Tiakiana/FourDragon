﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4DragonsCons
{
    class CardImproveRelation : ICard
    {
        public int cost
        {
            get;

            set;
        }

        public CardImproveRelation(Town own)
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
            return "Improve relationship to ";
        }

    }
}
