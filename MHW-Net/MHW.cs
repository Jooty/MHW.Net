using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;

namespace MHW_Net
{
    public class MHW
    {
        public static Armor GetArmor(int id)
        {
            string request = $"https://mhw-db.com/armor/{id}";

            var wc = new WebClient();
            string dbData = wc.DownloadString(request);

            Armor armor = JsonConvert.DeserializeObject<Armor>(dbData);
            return armor;
        }

        public static ArmorSet GetArmorSet(int id)
        {
            string request = $"https://mhw-db.com/armor/sets/{id}";

            var wc = new WebClient();
            string dbData = wc.DownloadString(request);

            ArmorSet armorSet = JsonConvert.DeserializeObject<ArmorSet>(dbData);
            return armorSet;
        }

        public static Charm GetCharm(int id)
        {
            string request = $"https://mhw-db.com/charms/{id}";

            var wc = new WebClient();
            string dbData = wc.DownloadString(request);

            Charm charm = JsonConvert.DeserializeObject<Charm>(dbData);
            return charm;
        }

        public static Decoration GetDecoration(int id)
        {
            string request = $"https://mhw-db.com/decorations/{id}";

            var wc = new WebClient();
            string dbData = wc.DownloadString(request);

            Decoration decoration = JsonConvert.DeserializeObject<Decoration>(dbData);
            return decoration;
        }

        public static Weapon GetWeapon(int id)
        {
            string request = $"https://mhw-db.com/weapons/{id}";

            var wc = new WebClient();
            string dbData = wc.DownloadString(request);

            Weapon weapon = JsonConvert.DeserializeObject<Weapon>(dbData);
            return weapon;
        }

        public static Item GetItem(int id)
        {
            string request = $"https://mhw-db.com/items/{id}";

            var wc = new WebClient();
            string dbData = wc.DownloadString(request);

            Item item = JsonConvert.DeserializeObject<Item>(dbData);
            return item;
        }

        public static T Get<T>(int id)
        {
            IDictionary<Type, string> dict = new Dictionary<Type, string>()
            {
                { typeof(Armor), "armor" },
                { typeof(Weapon), "weapons" },
                { typeof(Charm), "charms" },
                { typeof(ArmorSet), "armor/sets" },
                { typeof(Decoration), "decorations" }
            };

            string request = $"https://mhw-db.com/{dict.First(s => s.Key == typeof(T)).Value}/{id}";

            var wc = new WebClient();
            string dbData = wc.DownloadString(request);

            var value = JsonConvert.DeserializeObject<T>(dbData);
            return value;
        }
    }
}
