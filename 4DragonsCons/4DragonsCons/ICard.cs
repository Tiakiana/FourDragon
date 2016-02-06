using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4DragonsCons
{
    interface ICard
    {
        int name { get; set; }
        int cost { get; set; }

        Town owner { get; set; }

        void OnDraw();
        void OnProduction();
        void OnComplete();
        void OnRelation();
        void OnResearch();

    }
}
