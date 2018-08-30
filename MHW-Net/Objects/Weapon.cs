using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHW_Net
{
    public class Weapon
    {
        public int id;
        public string slug;
        public string name;
        public WeaponType type;
        public int rarity;
        public Attack attack;
        public Slot[] slots;
        public WeaponElement[] elements;
        public WeaponCraftingInfo crafting;
        public WeaponAssets assets;
        public WeaponSharpness[] durability;
        // TODO: public WeaponAttributes attributes;
    }
}
