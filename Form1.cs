namespace WinFormdRandomNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCliclk(object sender, EventArgs e)
        {
            Random random = new Random();
            int a = Convert.ToInt32(HighBox.Text);
            int b = Convert.ToInt32(LowBox.Text);
            int c = random.Next(a, b+1);
            LabelOut.Text = c.ToString();
        }

    }
}