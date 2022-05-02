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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 nuevaventana = new Form7();
            nuevaventana.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 nuevaventana = new Form7();
            nuevaventana.Show();
        }
    }
}
