using System.Text;

namespace Gmail_Suffix_Generator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            SuffiixLength.Value = 5;
            CountGeneratorEmail.Value = 10;
        }

        private void StartGenerator_Click(object sender, EventArgs e)
        {
            try
            {
                Log.AppendText(Suffix.GeneratorEmail(TextBoxEmail.Text, (int)SuffiixLength.Value, (int)CountGeneratorEmail.Value));
            }
            catch (Exception ex) { Log.AppendText(ex.Message); }
        }

        private void Log_TextChanged(object sender, EventArgs e)
        {
            Log.ScrollToCaret();
        }
    }
}
