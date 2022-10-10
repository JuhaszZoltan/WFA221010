namespace WFA221010
{
    public partial class FrmMain : Form
    {
        static Random rnd = new();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnKoszones_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                caption: "üdvözlés",
                text: $"Hello {tbNev.Text}!",
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(
                red: rnd.Next(256),
                green: rnd.Next(256),
                blue: rnd.Next(256));
        }
    }
}