using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avatar_toolset
{
    internal class avatar_parcer
    {
        public static void Load_avatar_list(string file_path)
        {
            List<avatar_item> items = JsonConvert.DeserializeObject<List<avatar_item>>(File.ReadAllText(file_path));
            int max = items.Count;
            List<OutfitSelection> tmp2 = new List<OutfitSelection>();

            Form1.main_ui.comboBox1.Items.Clear();
            Form1.main_ui.comboBox2.Items.Clear();
            Form1.main_ui.comboBox3.Items.Clear();
            Form1.main_ui.comboBox4.Items.Clear();


            outfitItems.Clear();
            avatarColorSwatchs.Clear();
            avatarMasks.Clear();
            avatarDecals.Clear();

            Form1.main_ui.progressBar1.Maximum = max;
            Form1.main_ui.progressBar1.Minimum = 0;
            for (int idx = 0; idx < items.Count; idx++)
            {
                avatar_item item = items[idx];
                tmp2.Add(FromRecNetString(item.AvatarItemDesc));
                int tmp = (idx + 1) / max;
                Form1.main_ui.progressBar1.Value = tmp;
                Form1.main_ui.label1.Text = $"loading {idx + 1}/{max}";
                Form1.main_ui.Update();
            }
            Form1.main_ui.label1.Text = $"formating avatar item";
            Form1.main_ui.Update();

            outfitItems.Add("");
            avatarColorSwatchs.Add("");
            avatarMasks.Add("");
            avatarDecals.Add("");

            foreach (OutfitSelection item in tmp2)
            {
                if (!outfitItems.Contains(item.outfitItem))
                {
                    outfitItems.Add(item.outfitItem);
                }
                if (!avatarColorSwatchs.Contains(item.avatarColorSwatch))
                {
                    avatarColorSwatchs.Add(item.avatarColorSwatch);
                }
                if (!avatarMasks.Contains(item.avatarMask))
                {
                    avatarMasks.Add(item.avatarMask);
                }
                if (!avatarDecals.Contains(item.avatarDecal))
                {
                    avatarDecals.Add(item.avatarDecal);
                }
            }
            Form1.main_ui.comboBox1.Items.AddRange(outfitItems.ToArray());
            Form1.main_ui.comboBox2.Items.AddRange(avatarColorSwatchs.ToArray());
            Form1.main_ui.comboBox3.Items.AddRange(avatarMasks.ToArray());
            Form1.main_ui.comboBox4.Items.AddRange(avatarDecals.ToArray());
        }
        public static List<string> outfitItems = new List<string>();

        public static List<string> avatarColorSwatchs = new List<string>();

        public static List<string> avatarMasks = new List<string>();

        public static List<string> avatarDecals = new List<string>();
        public class avatar_item
        {
            public string AvatarItemDesc { get; set; }
        }
        public class OutfitSelection
        {
            public string outfitItem { get; set; }
            public string avatarColorSwatch { get; set; }
            public string avatarMask { get; set; }
            public string avatarDecal { get; set; }
        }
        public class avatar_item_extended : avatar_item
        {
            public string AvatarItemDesc { get; set; }
            public int UnlockedLevel { get; set; }
            public int PlatformMask { get; set; }
            public string Tooltip { get; set; }
            public int Rarity { get; set; }
            public string FriendlyName { get; set; }
        }

        public static OutfitSelection FromRecNetString(string avatarItemDesc)
        {
            if (string.IsNullOrEmpty(avatarItemDesc))
            {
                return null;
            }
            string[] array = avatarItemDesc.Split(new char[] { ',' });
            if (array == null || array.Length != 4)
            {
                return null;
            }
            return new OutfitSelection
            {
                outfitItem = array[0],
                avatarColorSwatch = array[1],
                avatarMask = array[2],
                avatarDecal = array[3]
            };
        }
    }
}
