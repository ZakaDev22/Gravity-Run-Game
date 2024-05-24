using Gravity_Run_Game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gravity_Run_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        // global variables
        int gravity = 0;
        int gravityValue = 8;
        int obstacleSpeed = 10;
        int Score = 0;
        int HighScore = 0;
        bool gameOver = false;
        Random randomNumber = new Random();

        bool pause = true;


        private void GameTimerEvent(object sender, EventArgs e)
        {
            lbScore.Text = "Score: " + Score;
            lbHithScore.Text = "HighScore: " + HighScore;
            Player.Top += gravity;

            // when the player land on the platform.
            if (Player.Top > 347)
            {
                gravity = 0;
                Player.Top = 347;
                Player.Image = Resources.run_down0;
            }
            else if (Player.Top < 43)
            {
                gravity = 0;
                Player.Top = 43;
                Player.Image = Resources.run_up0; 
            }

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;

                    if(x.Left < -1)
                    {
                        x.Left = randomNumber.Next(1200, 3000);
                        Score++;
                    }

                    if(x.Bounds.IntersectsWith(Player.Bounds))
                    {
                        GameTimer.Stop();
                        gameOver = true;
                        lbScore.Text += "   Game Over!!!  Press Enter To Play Again";

                        // Set The HighScore
                        if(Score > HighScore)
                        {
                            HighScore = Score;
                        }
                    }

                }

                if (x is PictureBox && (string)x.Tag == "Beast")
                {
                    x.Left -= obstacleSpeed;

                    if (x.Left < -1)
                    {
                        x.Left = randomNumber.Next(2500, 5500);
                        Score++;
                    }

                    if (x.Bounds.IntersectsWith(Player.Bounds))
                    {
                        GameTimer.Stop();
                        gameOver = true;
                        lbScore.Text += "   Game Over!!!  Press Enter To Play Again";

                        // Set The HighScore
                        if (Score > HighScore)
                        {
                            HighScore = Score;
                        }
                    }
                }
            }

            if(Score >= 10)
            {
                pictureBox3.Image = Resources.b2;
                obstacleSpeed = 20;
                gravityValue = 12;
                lbSpeed.Text = "Speed: x2";
                lbLevel.Text = "Level: 2";
            }

            if (Score >= 20)
            {
                pictureBox3.Image = Resources.b3;
                obstacleSpeed = 25;
                gravityValue = 16;
                lbSpeed.Text = "Speed: x3";
                lbLevel.Text = "Level: 3";
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.P)
            {
                if (gameOver)
                    return;

                if(pause)
                {
                    GameTimer.Stop();
                    pause = false;
                    lbPlayerButton.Visible = true;
                    pcplayyerButtun.Visible = true;

                }
                else
                {
                    GameTimer.Start();
                    pause = true;
                    lbPlayerButton.Visible = false;
                    pcplayyerButtun.Visible = false;
                }
            }

            if(e.KeyCode == Keys.Space)
            {
                if(Player.Top == 347)
                {
                    Player.Top -= 10;
                    gravity = -gravityValue;
                }

                else if (Player.Top == 43)
                {
                    Player.Top += 10;
                    gravity = gravityValue;
                }
            }

            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }
        }

        private void RestartGame()
        {
            lbScore.Parent = pictureBox1;
            lbHithScore.Parent = pictureBox2;
            lbSpeed.Parent = pictureBox1;
            lbHithScore.Top = 0;

            Player.Location = new Point(140, 140);
            Player.Image = Resources.run_down0;

            pictureBox3.Image = Resources.b1;

            Score = 0;
            gravityValue = 8;
            gravity = gravityValue;
            obstacleSpeed = 10;
            gameOver = false;

            lbLevel.Text = "Level: 1";

            lbPlayerButton.Visible = false;
            pcplayyerButtun.Visible = false;

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left = randomNumber.Next(1200, 3000);
                }

                if (x is PictureBox && (string)x.Tag == "Beast")
                {
                    x.Left = randomNumber.Next(2500, 5500);
                }
               
            }

            GameTimer.Start();
        }

      
    }
}
