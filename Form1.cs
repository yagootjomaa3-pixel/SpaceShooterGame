using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace space_shooter
{
    public partial class Form1 : Form
    {

        PictureBox[] Stars;
        int backgroundspeed;
        int score = 0;
        Random rad;

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Stars = new PictureBox[10];
            backgroundspeed = 4;
            rad = new Random();
            for (int i = 0; i < Stars.Length; i++)
            {
                Stars[i] = new PictureBox();
                Stars[i].BorderStyle = BorderStyle.None;
                Stars[i].Location = new Point(rad.Next(20, 580), rad.Next(-10, 400));
                if (i % 2 == 1)
                {
                    Stars[i].Size = new Size(2, 2);
                    Stars[i].BackColor = Color.Wheat;
                }
                else
                {
                    Stars[i].Size = new Size(3, 3);
                    Stars[i].BackColor = Color.DarkGray;
                }
                this.Controls.Add(Stars[i]);
                starsTimer.Start();
            }



        }
        private void movebgtimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Stars.Length / 2; i++)
            {
                Stars[i].Top += backgroundspeed;

                if (Stars[i].Top >= this.Height)
                {
                    Stars[i].Top = -Stars[i].Height;
                }
            }

            for (int i = Stars.Length / 2; i < Stars.Length; i++)
            {
                Stars[i].Top += backgroundspeed - 2;

                if (Stars[i].Top >= this.Height)
                {
                    Stars[i].Top = -Stars[i].Height;
                }
            }
        }

        private void leftMoveTimer_Tick(object sender, EventArgs e)
        {
            this.Text = "Moving Left";
            if (pictureBox1.Left > 0)
            {
                pictureBox1.Left -= 10;
            }
        }

        private void rightMoveTimer_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Left < this.Width - pictureBox1.Width - 20)
            {
                pictureBox1.Left += 10;
            }
        }


        private void upMoveTimer_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5;
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { leftMoveTimer.Start(); }
            if (e.KeyCode == Keys.Right) { rightMoveTimer.Start(); }
            if (e.KeyCode == Keys.Up) { upMoveTimer.Start(); }
            if (e.KeyCode == Keys.Down) { downMoveTimer.Start(); }

            
        }




        private void downMoveTimer_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Top < this.Height - 100)
            {
                pictureBox1.Top += 15;
            }
        }
        void CreateBullet()
        {
            PictureBox bullet = new PictureBox(); 
            bullet.Size = new Size(5, 20);
            bullet.BackColor = Color.Yellow;
            bullet.Tag = "bullet";
            bullet.Left = pictureBox1.Left + (pictureBox1.Width / 2) - 2;
            bullet.Top = pictureBox1.Top - 20;
            this.Controls.Add(bullet);
            bullet.BringToFront();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { leftMoveTimer.Stop(); }
            if (e.KeyCode == Keys.Right) { rightMoveTimer.Stop(); }
            if (e.KeyCode == Keys.Up) { upMoveTimer.Stop(); }
            if (e.KeyCode == Keys.Down) { downMoveTimer.Stop(); }

            if (e.KeyCode == Keys.Space)
            {
                CreateBullet();
            }
        } 

        private void starsTimer_Tick(object sender, EventArgs e)
        {


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "bullet")
                {
                    x.Top -= 50;
                    if (x.Bounds.IntersectsWith(enemy1.Bounds))
                    {
                        score++; // نزيد النقاط
                        labelScore.Text = "Score: " + score;
                        this.Controls.Remove(x);
                        enemy1.Top += 5;
                        enemy1.Left = rad.Next(20, 500);
                    }
                    if (x.Bounds.IntersectsWith(enemy2.Bounds))
                    {
                        this.Controls.Remove(x);
                        enemy2.Top = -100;
                        enemy2.Left = rad.Next(20, 550);
                    }
                }
                if (x is PictureBox && (string)x.Tag == "star")
                {
                    x.Top += 5;
                    x.Visible = (rad.Next(0, 10) > 1);
                    if (x.Top > this.Height) { x.Top = -50; }
                }

            }
            enemy1.Top += 2;
            enemy2.Top += 1;

            if (enemy1.Top > this.Height)
            {
                enemy1.Top = -100;
                enemy1.Left = rad.Next(20, 500);
            }

            if (enemy2.Top > this.Height)
            {
                enemy2.Top = -100;
                enemy2.Left = rad.Next(20, 550);
        }
            if (pictureBox1.Bounds.IntersectsWith(enemy1.Bounds) || pictureBox1.Bounds.IntersectsWith(enemy2.Bounds))
            {
                starsTimer.Stop(); 
                MessageBox.Show("Game Over!");
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "bullet")
                {
                    if (x.Top < -100)
                    {
                        this.Controls.Remove(x);
                    }
                }
            }


            
            {
                PictureBox bullet = new PictureBox();
                bullet.Size = new Size(5, 20);
                bullet.BackColor = Color.Yellow;
                bullet.Tag = "bullet";
                bullet.Left = pictureBox1.Left + (pictureBox1.Width / 2) - 2;
                bullet.Top = pictureBox1.Top - 20;
                this.Controls.Add(bullet);
                bullet.BringToFront();
            }
        }

        private void MoveBgTimer_Tick_1(object sender, EventArgs e)
        {


































        }
    }
} 





