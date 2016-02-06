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

        int relationship { get; set; }

        public Relation(Town own, Town oth) {
            owner = own;
            other = oth;
            relationship = 0;
        }


        public int GetRelationship() {
            return relationship;
        }
        public void SetRelationship(int chng) { relationship += chng; }


    }
}
