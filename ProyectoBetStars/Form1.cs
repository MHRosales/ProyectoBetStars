namespace ProyectoBetStars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 nuevaventana = new Form2();
            nuevaventana.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 nuevaventana = new Form4();
            nuevaventana.Show();
        }
    }
}