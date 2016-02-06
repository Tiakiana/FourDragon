using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4DragonsCons
{
     class CardStartProject : ICard
    {
        public CardStartProject(Town own) {
            owner = own;

        }

        public int cost
        {
            get;

            set;
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
            //throw new NotImplementedException();
        }

        public void OnDraw()
        {
            if (owner.GetProjects().Count>0)
            {
                owner.GetProjects()[0].OnDraw();
            }
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
            return "Start Project"; 
        }
    }
}
