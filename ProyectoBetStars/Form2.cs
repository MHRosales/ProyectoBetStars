﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 nuevaventana = new Form3();
            nuevaventana.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 nuevaventana = new Form4();
            nuevaventana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
