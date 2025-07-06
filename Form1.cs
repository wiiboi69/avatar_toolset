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
    }
}
