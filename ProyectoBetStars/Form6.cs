using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBetStars
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 nuevaventana = new Form5();
            nuevaventana.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 nuevaventana = new Form7();
            nuevaventana.Show();
        }
    }
}
