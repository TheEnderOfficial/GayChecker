namespace GayChecker
{
    public partial class Form1 : Form
    {
        Random r;
        public Form1()
        {
            InitializeComponent();
            r = new Random();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ѕро € тоже.");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Location = new Point(r.Next(button1.Size.Width, this.Size.Width - button1.Size.Width), r.Next(button1.Size.Height, this.Size.Height - button1.Size.Height));
        }
    }
}
