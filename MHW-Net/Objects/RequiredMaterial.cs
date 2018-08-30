using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHW_Net
{
    public class RequiredMaterial
    {
        public int quantity;
        public struct item
        {
            public int id;
            public string name;
            public string description;
            public int rarity, carryLimit, sellPrice, buyPrice;
        }
    }
}
