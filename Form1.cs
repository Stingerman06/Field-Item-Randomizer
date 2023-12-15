namespace Field_Item_Randomizer
{
    public partial class Form1 : Form
    {
        public bool[] selectedFiles = { false, false };
        public Form1()
        {
            InitializeComponent();
            InitializeVariables();
        }
        private void InitializeVariables()
        {
            button3.Enabled = false;
            openFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            folderBrowserDialog1.SelectedPath = AppDomain.CurrentDomain.BaseDirectory;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            textBox1.Text = Path.GetFullPath(openFileDialog1.FileName);
            selectedFiles[0] = true;
            if (selectedFiles[1])
            {
                button3.Enabled = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
            {

            }
            else
            {
                textBox2.Text = Path.GetFullPath(folderBrowserDialog1.SelectedPath);
                selectedFiles[1] = true;
                if (selectedFiles[0])
                {
                    button3.Enabled = true;
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string saveFile = textBox2.Text;
            string loadFile = textBox1.Text;
            int seed;
            if (!int.TryParse(textBox3.Text, out seed) || (int.TryParse(textBox3.Text, out seed) && seed == 0))
            {
                Random rand = new Random();
                seed = rand.Next();
                label1.Text = "Seed was randomized! Seed: " + seed.ToString();
                label1.ForeColor = Color.Red;
            }
            else
            {
                label1.Text = "Seed: " + seed.ToString();
                label1.ForeColor = Color.Black;
            }
            Randomize.Main(saveFile, loadFile, seed);
            label2.Text = "Done!";
        }
    }
}