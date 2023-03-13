using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird_Atestat
{
    public partial class Customize : Form
    {
        public Customize()
        {
            InitializeComponent();
        }

        private void Customize_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Apply_Click(object sender, EventArgs e)
        {

            this.Hide();
            Joc f = new Joc();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            variabile.imagine = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            variabile.imagine = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            variabile.imagine = 3;
        }
        private void p4_Click(object sender, EventArgs e)
        {
            variabile.imagine = 4;
        }

        private void bird1_Click(object sender, EventArgs e)
        {
            variabile.bird = 1;
        }

        private void bird2_Click(object sender, EventArgs e)
        {
            variabile.bird = 2;
        }
        private void bird3_Click(object sender, EventArgs e)
        {
            variabile.bird = 3;
        }
        private void bird4_Click(object sender, EventArgs e)
        {
            variabile.bird = 4;
        }

        private void bird5_Click(object sender, EventArgs e)
        {
            variabile.bird = 5;
        }
        private void bird6_Click(object sender, EventArgs e)
        {
            variabile.bird = 6;
        }
    }
}
