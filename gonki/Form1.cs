using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gonki
{
    public partial class Form1 : Form
    {
        private PictureBox[] roadlines;
        private PictureBox[] enemies;
        private PictureBox[] coins;

        private Random random;
        private int collectedCoins;
        public Form1()
        {
            InitializeComponent();
            init_game();
        }

        
        private void init_game()
        {
            new Settings();
            roadlines = new PictureBox[] { pbRoadLine1, pbRoadLine2, pbRoadLine3, pbRoadLine4};
            enemies = new PictureBox[] { Enemy1, Enemy2, Enemy3};
            coins = new PictureBox[] { Coin1, Coin2, Coin3, Coin4};
            random = new Random();
            collectedCoins = 0;
            LblGameOver.Visible = false;
            
            gen_start_pos();

            gameTimer.Interval = 1000 / Settings.TimerSpeed;
            gameTimer.Start();
        }
        private void gen_start_pos()
        {
            int startY = -Enemy1.Height;
            int x;
            for(int i = 0; i < enemies.Length; i++)
            {
                x = random.Next(pbBoundLeft.Right + enemies[i].Width / 2, pbBoundRight.Left - enemies[i].Width / 2);
                enemies[i].Location = new Point(x, startY);
                startY -= this.Height / enemies.Length;
            }
        }
        private void move_enemys()
        {
            int x;
            for (int i = 0; i < enemies.Length; i++)
            {
                if (enemies[i].Top >= this.Height)
                {
                    x = random.Next(pbBoundLeft.Right + enemies[i].Width / 2, pbBoundRight.Left - enemies[i].Width / 2);
                    enemies[i].Location = new Point(x, -enemies[i].Height);
                }
                else
                {
                    enemies[i].Top += (int)Settings.GameSpeed;
                }
                enemies[i].Top += (int)Settings.GameSpeed;

            }
        }
        private void move_coins()
        {
            int x;
            for (int i = 0; i < coins.Length; i++)
            {
                if (coins[i].Top >= this.Height)
                {
                    x = random.Next(pbBoundLeft.Right + coins[i].Width / 2, pbBoundRight.Left - coins[i].Width / 2);
                    coins[i].Location = new Point(x, -coins[i].Height);
                }
                else
                {
                    coins[i].Top += (int)Settings.GameSpeed;
                }
                coins[i].Top += (int)Settings.GameSpeed;

            }
        }
        private void move_lines()
        {
            for(int i = 0; i < roadlines.Length; i++)
            {
                if(roadlines[i].Top >= this.Height)
                {
                    roadlines[i].Top = -roadlines[i].Height;
                }
                else
                {
                    roadlines[i].Top += (int)Settings.GameSpeed;
                }
                roadlines[i].Top += (int)Settings.GameSpeed;

            }
        }
        private void is_get_coins()
        {
            for(int i = 0; i < coins.Length; i++)
            {
                if (car.Bounds.IntersectsWith(coins[i].Bounds))
                {
                    collectedCoins++;
                    int x = random.Next(pbBoundLeft.Right + coins[i].Width / 2, pbBoundRight.Left - coins[i].Width / 2);
                    coins[i].Location = new Point(x, -coins[i].Height);
                    Settings.GameSpeed += 0.5f;
                    Settings.MinSpeed+= 0.5f;
                    Settings.MaxSpeed+= 0.5f;
                }
                
            }
            lblCoins.Text = "Coins " + collectedCoins.ToString();
        }
        private void is_gameover()
        {
            for(int i = 0; i < enemies.Length; i++)
            {
                if (car.Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    Settings.IsGameOver = true;
                }
            }
        }
        private void gameover_actions()
        {
            gameTimer.Stop();
            LblGameOver.Visible = true;
            car.Image = Properties.Resources.взрыв;
            DialogResult dialogResult =  MessageBox.Show("Your score is " + collectedCoins.ToString() + "\nTry again?",
                "Gameover! :(", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                car.Image = Properties.Resources.car;
                init_game();
            }
            else
            {
                this.Close();
            }
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            move_lines();
            move_coins();
            move_enemys();
            is_get_coins();
            is_gameover();
            if (Settings.IsGameOver)
            {
                gameover_actions();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!Settings.IsGameOver)
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:
                        if (car.Left > pbBoundLeft.Right)
                        {
                            car.Left -= Settings.CarTurnSpeed;
                        }
                        break;
                    case Keys.Right:
                        if (car.Right < pbBoundRight.Left)
                        {
                            car.Left += Settings.CarTurnSpeed;
                        }
                        break;
                    case Keys.Up:
                        if (Settings.GameSpeed < Settings.MaxSpeed)
                        {
                            Settings.GameSpeed += 0.5f;
                        }
                        break;
                    case Keys.Down:
                        if (Settings.GameSpeed > Settings.MinSpeed)
                        {
                            Settings.GameSpeed -= 0.5f;
                        }
                        break;
                    default:
                        break;
                }
            }
            
        }

        private void Enemy1_Click(object sender, EventArgs e)
        {

        }

        private void car_Click(object sender, EventArgs e)
        {

        }
    }
}
