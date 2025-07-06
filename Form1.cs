using Newtonsoft.Json;

namespace avatar_toolset
{
    public partial class Form1 : Form
    {
        public static Form1 main_ui = null;
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.FileOk += OpenFileDialog1_FileOk;
            main_ui = this;
        }

        private void load_avatars_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void OpenFileDialog1_FileOk(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            if (openFileDialog1.FileName is null)
                return;
            label1.Text = "Loading avatar detail from " + openFileDialog1.FileName;
            try
            {
                avatar_parcer.Load_avatar_list(openFileDialog1.FileName);
            }
            catch
            {

            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = $"{comboBox1.Text},{comboBox2.Text},{comboBox3.Text},{comboBox4.Text}";
        }

        private void randoimize_Click(object sender, EventArgs e)
        {
            string path = openFileDialog1.FileName;
 
            try
            {
                string newFilePath = Path.Combine(Environment.CurrentDirectory, "randomized_output.json");

                List<avatar_parcer.avatar_item_extended> randomizedItems = new List<avatar_parcer.avatar_item_extended>();

                if (File.Exists(newFilePath))
                {
                    string existingJson = File.ReadAllText(newFilePath);
                    randomizedItems = JsonConvert.DeserializeObject<List<avatar_parcer.avatar_item_extended>>(existingJson)
                                      ?? new List<avatar_parcer.avatar_item_extended>();
                }

                Random rand = new Random();
                int howManyToGenerate = 100000; 

                for (int i = 0; i < howManyToGenerate; i++)
                {
                    string outfit = GetRandomOrEmpty(avatar_parcer.outfitItems, rand);
                    string swatch = GetRandomOrEmpty(avatar_parcer.avatarColorSwatchs, rand);
                    string mask = GetRandomOrEmpty(avatar_parcer.avatarMasks, rand);
                    string decal = GetRandomOrEmpty(avatar_parcer.avatarDecals, rand);

                    var newItem = new avatar_parcer.avatar_item_extended
                    {
                        AvatarItemDesc = $"{outfit},{swatch},{mask},{decal}",
                        UnlockedLevel = 0,
                        PlatformMask = -1,
                        Tooltip = "",
                        Rarity = 0,
                        FriendlyName = "Randomized Item " + (randomizedItems.Count + 1)
                    };

                    randomizedItems.Add(newItem);
                }

                File.WriteAllText(newFilePath, JsonConvert.SerializeObject(randomizedItems, Formatting.Indented));
                MessageBox.Show($"{howManyToGenerate} randomized items saved to:\n{newFilePath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private string GetRandomOrEmpty(List<string> list, Random rand)
        {
            if (list == null || list.Count == 0) return "";

            int startIndex = list[0] == "" ? 1 : 0;

            if (list.Count <= startIndex) return ""; 

            int idx = rand.Next(startIndex, list.Count);
            return list[idx];
        }


    }
}
