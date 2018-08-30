using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHW_Net
{
    public class WeaponCraftingInfo
    {
        public bool craftable;
        public int previous;
        public int[] branches;
        public CraftingCost[] craftingMaterials;
        public CraftingCost[] upgradeMaterials;
    }
}
