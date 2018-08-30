using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MHW_Net
{
    public class Armor
    {
        public int id;
        public string slug;
        public string name;
        public ArmorType type;
        public string rank;
        public int rarity;
        public struct defense
        {
            public int Base, max, augmented;
        }
        public struct resistances
        {
            public int fire, water, ice, thunder, dragon;
        }
        public Slot[] slots;
        public SetInfo armorSet;
        public struct assets
        {
            public string imageMale, imageFemale;
        }
        public RequiredMaterial[] materials;
        // TODO: attributes
    }
}
