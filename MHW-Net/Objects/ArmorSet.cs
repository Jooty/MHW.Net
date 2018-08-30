using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHW_Net
{
    public class ArmorSet
    {
        public int id;
        public string name;
        public ArmorRank rank;
        public Armor[] pieces;
        public ArmorSetBonus bonus;
    }
}
