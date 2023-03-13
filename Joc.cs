using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Flappy_Bird_Atestat
{
    public partial class Joc : Form
    {
        int gravity = 2;
        int score = 0;
        int viteza = 4;
        int ok1 = 0 , ok2 = 0, ok3 = 0;
        int hearts = 3;
        int pb1=1, pt1=1, pb2=1, pt2=1, pb3=1, pt3=1;

        public Joc()
        {
            InitializeComponent();
            if (variabile.imagine==1)
            {
                Image x = new Bitmap("p7.png");
                this.BackgroundImage = x;
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (variabile.imagine == 2)
            {
                Image x = new Bitmap("p2.png");
                this.BackgroundImage = x;
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (variabile.imagine == 3)
            {
                Image x = new Bitmap("p3.png");
                this.BackgroundImage = x;
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (variabile.imagine == 4)
            {
                Image x = new Bitmap("p4.png");
                this.BackgroundImage = x;
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }


            if (variabile.bird == 1)
            {
                Image x = new Bitmap("bird1.png");
                flappyBird.Image =  x;
            }
            else if (variabile.bird == 2)
                {
                    Image x = new Bitmap("bird2.png");
                    flappyBird.Image = x;
                }
            else if (variabile.bird == 3)
            {
                Image x = new Bitmap("bird3.png");
                flappyBird.Image = x;
            }
            else if (variabile.bird == 4)
            {
                Image x = new Bitmap("bird4.png");
                flappyBird.Image = x;
            }
            else if (variabile.bird == 5)
            {
                Image x = new Bitmap("bird5.png");
                flappyBird.Image = x;
            }
            else if (variabile.bird == 6)
            {
                Image x = new Bitmap("bird6.png");
                flappyBird.Image = x;
            }

        }
        private void endGame()
        {
            timerGame.Stop();
            retry.Visible = true;
            retry.Enabled = true;
            scoreText.Text += " Game Over!";    
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            flappyBird.Top = flappyBird.Top + gravity;
            pipeBottom.Left = pipeBottom.Left - viteza;
            pipeTop.Left = pipeTop.Left - viteza;
            pipeBottom2.Left = pipeBottom2.Left - viteza;
            pipeTop2.Left = pipeTop2.Left - viteza;
            pipeBottom3.Left = pipeBottom3.Left - viteza;
            pipeTop3.Left = pipeTop3.Left - viteza;
            ban1.Left = ban1.Left - viteza;
            ban2.Left = ban2.Left - viteza;
            ban3.Left = ban3.Left - viteza;
            scoreText.Text = Convert.ToString("Score: " + score);

            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = pipeTop.Left = 1000;
                ban1.Left = 1025;
                ok1 = 0;
                ban1.Visible = true;
            }
            if (pipeBottom2.Left < -150)
            {
                pipeTop2.Left = pipeBottom2.Left = 1000;
                ok2 = 0;
                ban2.Left = 1025;
                ban2.Visible = true;
            }
            if (pipeBottom3.Left < -150)
            {
                pipeTop3.Left = pipeBottom3.Left = 1000;
                ok3 = 0;
                ban3.Left = 1025;
                ban3.Visible = true;

            }

            if(pipeBottom.Right < 220 && pipeBottom.Right > 210)
            {
                if (ok1 == 0)
                {   
                    score++; 
                    ok1 = 1; 
                }
            }

            if (pipeBottom2.Right < 220 && pipeBottom2.Right > 210)
            {
                if (ok2 == 0)
                {
                    score++;
                    ok2 = 1;
                }
            }

            if (pipeBottom3.Right < 220 && pipeBottom3.Right > 210)
            {
                if (ok3 == 0)
                {
                    score++;
                    ok3 = 1;
                }
            }
                        
            if((pb1==0 && flappyBird.Left>pipeBottom.Right)||(pb2 == 0 && flappyBird.Left > pipeBottom2.Right)||(pb3 == 0 && flappyBird.Left > pipeBottom3.Right)||(pt1 == 0 && flappyBird.Left > pipeTop.Right)|| (pt2 == 0 && flappyBird.Left > pipeTop2.Right)|| (pt3 == 0 && flappyBird.Left > pipeTop3.Right))
            {
                pb1 = pb2 = pb3 = pt1 = pt2 = pt3 = 1;
                hearts = hearts - 1;
                if(hearts == 2)
                {
                    Image x = new Bitmap("heart2.png");
                    inima1.Image = x;
                }
                else if (hearts == 1)
                {
                    Image x = new Bitmap("heart2.png");
                    inima2.Image = x;
                }
                else if (hearts == 0)
                {
                    Image x = new Bitmap("heart2.png");
                    inima3.Image = x;
                    endGame();
                }
            }

            if (flappyBird.Bounds.IntersectsWith(ground.Bounds)|| flappyBird.Top < -25)
            {
                endGame();
            }
            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds))
            {
                pb1 = 0;
            }
            if (flappyBird.Bounds.IntersectsWith(pipeTop.Bounds))
            {
                pt1 = 0;
            }         
            if (flappyBird.Bounds.IntersectsWith(pipeBottom2.Bounds))
            {
                pb2 = 0;
            }
            if (flappyBird.Bounds.IntersectsWith(pipeTop2.Bounds))
            {
                pt2 = 0;
            }
            if (flappyBird.Bounds.IntersectsWith(pipeBottom3.Bounds))
            {
                pb3 = 0;
            }
            if (flappyBird.Bounds.IntersectsWith(pipeTop3.Bounds))
            {
                pt3 = 0;  
            }
            if (flappyBird.Bounds.IntersectsWith(ban1.Bounds))
            {
                ban1.Visible = false;
            }
            if (flappyBird.Bounds.IntersectsWith(ban2.Bounds))
            {
                ban2.Visible = false;
            }
            if (flappyBird.Bounds.IntersectsWith(ban3.Bounds))
            {
                ban3.Visible = false;
            }
        }

        private void Flappy_Bird_Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                gravity = -3;
            }
        }

        private void Flappy_Bird_Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                gravity = 3;
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            timerGame.Enabled = true;

            start.Visible = false;
            start.Enabled = false;

            dificultate.Visible = false;
            dificultate.Enabled = false;

            customize.Visible = false;
            customize.Enabled = false;

            instructions.Visible = false;
            instructions.Enabled = false;

            exit.Visible = false;
            exit.Enabled = false;

            easy.Visible = false;
            easy.Enabled = false;

            medium.Visible = false;
            medium.Enabled = false;

            hard.Visible = false;
            hard.Enabled = false;
        }

        private void easy_Click(object sender, EventArgs e)
        {
            viteza = 4;
        }

        private void medium_Click(object sender, EventArgs e)
        {
            viteza = 6;
        }

        private void hard_Click(object sender, EventArgs e)
        {
            viteza = 7;
        }

        private void instructions_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instructiuni f = new Instructiuni();
            f.Show();
        }

        private void customize_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Customize f = new Customize();
            f.Show();
        }

        private void dificultate_Click(object sender, EventArgs e)
        {
            easy.Visible = true;
            easy.Enabled = true;
            medium.Visible = true;
            medium.Enabled = true;
            hard.Visible = true;
            hard.Enabled = true;

        }

        private void retry_Click(object sender, EventArgs e)
        {
            pb1 = pb2 = pb3 = pt1 = pt2 = pt3 = 1;
            hearts = 3;

            Image x = new Bitmap("heart1.png");
            inima1.Image = x;
            inima2.Image = x;   
            inima3.Image = x;

            retry.Visible = false;
            retry.Enabled = false;

            start.Visible = true;
            start.Enabled = true;

            dificultate.Visible = true;
            dificultate.Enabled = true;

            customize.Visible = true;
            customize.Enabled = true;

            instructions.Visible = true;
            instructions.Enabled = true;

            exit.Visible = true;
            exit.Enabled = true;

            scoreText.Text = "Score";
            score = 0;

            pipeBottom.Left = 375;
            pipeTop.Left = 375; 
            ban1.Left = 395;

            pipeBottom2.Left = 750;
            pipeTop2.Left = 750;
            ban2.Left = 770;

            pipeBottom3.Left = 1100;
            pipeTop3.Left = 1100;
            ban3.Left = 1120;

            flappyBird.Top = 202;

            ban1.Visible = true;
            ban2.Visible = true;
            ban3.Visible = true;

        }
    }
}
