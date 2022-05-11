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
            Form3 nuevaventana = new Form3();
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