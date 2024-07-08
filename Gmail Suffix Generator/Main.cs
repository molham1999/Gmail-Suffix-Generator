using System.Text;

namespace Gmail_Suffix_Generator
{
    public partial class Main : Form
    {
        private readonly Suffix _suffix = new();
        public Main()
        {
            InitializeComponent();
        }

        private void StartGenerator_Click(object sender, EventArgs e)
        {
            Log.AppendText(_suffix.GeneratorEmail(TextBoxEmail.Text, 5, (int)CountGeneratorEmail.Value) + Environment.NewLine);
        }
    }
}
