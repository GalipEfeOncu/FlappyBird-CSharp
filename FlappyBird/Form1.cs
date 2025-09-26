using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        // Player physics
        private int velocity = 0;
        private const int gravity = 1;
        private const int jumpPower = -13;
        private const int maxVelocity = 1;

        // Pipe settings
        private const int pipeWidth = 75;
        private const int pipeSlidingSpeed = 3;
        private const int pipeSpawnInterval = 200;
        private const int minGap = 150;
        private const int maxGap = 250;
        private const int minTopPipeHeight = 150;
        private const int maxTopPipeHeight = 300;
        private int pipeSpawnCounter = 0;
        private readonly List<PictureBox> pipes = new List<PictureBox>();

        // Form settings
        private const int formWidth = 1280;
        private const int formHeight = 720;


        public Form1()
        {
            InitializeComponent();
            gameTimer.Tick += gameTimer_Tick;
            gameTimer.Start();
            Form form = this;
            form.Width = formWidth;
            form.Height = formHeight;
            form.MinimizeBox = false;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.StartPosition = FormStartPosition.CenterScreen;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            velocity += gravity;
            pictureBird.Top += velocity;

            if (pictureBird.Top < 0) pictureBird.Top = 0;
            if (pictureBird.Bottom > this.Height) pictureBird.Top = this.Height - pictureBird.Height;

            if (velocity > maxVelocity) velocity = maxVelocity;
            if (velocity < jumpPower) velocity = jumpPower;

            //pipe kodları
            pipeSpawnCounter++;
            if (pipeSpawnCounter >= pipeSpawnInterval)
            {
                CreatePipe();
                pipeSpawnCounter = 0;
            }

            foreach (var pipe in pipes)
            {
                pipe.Left -= pipeSlidingSpeed;
                if (pipe.Right < 0)
                {
                    this.Controls.Remove(pipe);
                    pipes.Remove(pipe);
                    break;
                }
            }

            //Collider kodları
            foreach (var pipe in pipes)
            {
                if (pictureBird.Bounds.IntersectsWith(pipe.Bounds))
                {
                    gameTimer.Stop();
                    MessageBox.Show("Game Over");
                }
            }

            if (pictureBird.Top < 0 || pictureBird.Bottom > this.Height)
            {
                gameTimer.Stop();
                MessageBox.Show("Game Over");
            }

            if (pictureBird.Bounds.IntersectsWith(pictureGround.Bounds))
            {
                gameTimer.Stop();
                MessageBox.Show("Game Over");
            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                velocity = jumpPower;
        }

        private void CreatePipe()
        {
            Random rnd = new Random();
            int gap = rnd.Next(minGap, maxGap);
            int pipeHeight = rnd.Next(minTopPipeHeight, maxTopPipeHeight);

            PictureBox topPipe = new PictureBox();
            topPipe.Image = Properties.Resources.pipe_green1;
            topPipe.SizeMode = PictureBoxSizeMode.StretchImage;
            topPipe.Width = pipeWidth;
            topPipe.Height = pipeHeight;
            topPipe.Top = 0;
            topPipe.Left = this.Width;
            this.Controls.Add(topPipe);
            pipes.Add(topPipe);

            PictureBox bottomPipe = new PictureBox();
            bottomPipe.Image = Properties.Resources.pipe_green;
            bottomPipe.SizeMode = PictureBoxSizeMode.StretchImage;
            bottomPipe.Width = pipeWidth;
            bottomPipe.Height = this.Height - pipeHeight - gap;
            bottomPipe.Top = pipeHeight + gap;
            bottomPipe.Left = this.Width;
            this.Controls.Add(bottomPipe);
            pipes.Add(bottomPipe);
        }
    }
}
