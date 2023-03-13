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
    public partial class Instructiuni : Form
    {
        public Instructiuni()
        {
            InitializeComponent();
            
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Joc f = new Joc();
            f.Show();
        }

        private void Instructiuni_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
