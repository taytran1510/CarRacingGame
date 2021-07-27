/*
1. Nhóm 13:
Trương Bình Minh - 14110123
Lê Đỗ Trà My - 18133030
Lương Uy Long - 18133026
Trần Như Thuận - 18133054
2. Đồ án môn học Lập trình hướng đối tượng
3. Xây dựng game đua xe 2D
Cập nhật lần cuối: 18/12/2019
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Collections;
using System.IO;

namespace CarRacingGame
{
    public partial class OnePlayer : Form
    {
        public OnePlayer()
        {
            InitializeComponent();
            picGameOver.Visible = false;
            timer2 = new Timer();
            timer2.Tick += timer2_Tick;
            timer2.Interval = 1000;
        }

        int timeLeft;
        private void time_Tick(object sender, EventArgs e)
        {
            countdown();
            moveline(gamespeed);
            movetree(gamespeed);
            enemy(gamespeed);
            coin(gamespeed);
            coinscollection();
            gameover();
            lbSpeed.Text = "Speed = " + gamespeed.ToString() + " MPH";
        }

        private void countdown()
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                lbCountDown.Text = timeLeft.ToString();
                if (timeLeft == 0)
                {
                    lbCountDown.Text = "GO";
                    timer2.Start();
                    gamespeed++;
                }
            }
            else
            {
                lbCountDown.Visible = false;
            }
        }

        int collectedcoin = 0;
        double points = 0;

        Random r = new Random();
        int x;
        void enemy(int speed)
        {
            if (enemy1.Top >= 500)
            {
                x = r.Next(110, 450);
                enemy1.Location = new Point(x, 0);
            }
            else
            {
                enemy1.Top += speed;
            }
            if (enemy2.Top >= 500)
            {
                x = r.Next(100, 440);
                enemy2.Location = new Point(x, 0);
            }
            else
            {
                enemy2.Top += speed;
            }
            if (enemy3.Top >= 500)
            {
                x = r.Next(120, 445);
                enemy3.Location = new Point(x, 0);
            }
            else
            {
                enemy3.Top += speed;
            }
        }

        void moveline(int speed)
        {
            if (picB1.Top >= 500)
            {
                picB1.Top = 0;
            }
            else
            {
                picB1.Top += speed;
            }
            if (picB2.Top >= 500)
            {
                picB2.Top = 0;
            }
            else
            {
                picB2.Top += speed;
            }
            if (picB3.Top >= 500)
            {
                picB3.Top = 0;
            }
            else
            {
                picB3.Top += speed;
            }
            if (picB4.Top >= 500)
            {
                picB4.Top = 0;
            }
            else
            {
                picB4.Top += speed;
            }
            if (picB5.Top >= 500)
            {
                picB5.Top = 0;
            }
            else
            {
                picB5.Top += speed;
            }
            if (picB6.Top >= 500)
            {
                picB6.Top = 0;
            }
            else
            {
                picB6.Top += speed;
            }
            if (picB7.Top >= 500)
            {
                picB7.Top = 0;
            }
            else
            {
                picB7.Top += speed;
            }
            if (picB8.Top >= 500)
            {
                picB8.Top = 0;
            }
            else
            {
                picB8.Top += speed;
            }
            if (picB9.Top >= 500)
            {
                picB9.Top = 0;
            }
            else
            {
                picB9.Top += speed;
            }
            if (picB10.Top >= 500)
            {
                picB10.Top = 0;
            }
            else
            {
                picB10.Top += speed;
            }
        }

        void movetree(int speed)
        {
            if (tree1.Top >= 500)
            {
                tree1.Top = 0;
            }
            else
            {
                tree1.Top += speed;
            }
            if (tree2.Top >= 500)
            {
                tree2.Top = 0;
            }
            else
            {
                tree2.Top += speed;
            }
            if (tree3.Top >= 500)
            {
                tree3.Top = 0;
            }
            else
            {
                tree3.Top += speed;
            }
            if (tree4.Top >= 500)
            {
                tree4.Top = 0;
            }
            else
            {
                tree4.Top += speed;
            }
            if (tree5.Top >= 500)
            {
                tree5.Top = 0;
            }
            else
            {
                tree5.Top += speed;
            }
            if (tree6.Top >= 500)
            {
                tree6.Top = 0;
            }
            else
            {
                tree6.Top += speed;
            }
            if (tree7.Top >= 500)
            {
                tree7.Top = 0;
            }
            else
            {
                tree7.Top += speed;
            }
            if (tree8.Top >= 500)
            {
                tree8.Top = 0;
            }
            else
            {
                tree8.Top += speed;
            }
        }

        void coin(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = r.Next(100, 440);
                coin1.Location = new Point(x, 0);
            }
            else
            {
                coin1.Top += speed;
            }
            if (coin2.Top >= 500)
            {
                x = r.Next(100, 440);
                coin2.Location = new Point(x, 0);
            }
            else
            {
                coin2.Top += speed;
            }
            if (coin3.Top >= 500)
            {
                x = r.Next(100, 440);
                coin3.Location = new Point(x, 0);
            }
            else
            {
                coin3.Top += speed;
            }
            if (coin4.Top >= 500)
            {
                x = r.Next(100, 440);
                coin4.Location = new Point(x, 0);
            }
            else
            {
                coin4.Top += speed;
            }
        }

        void gameover()
        {
            if(car.Bounds.IntersectsWith(enemy1.Bounds))
            {
                SoundPlayer carcrash = new SoundPlayer(@"G:\IT\carcrash.wav");
                carcrash.Play();
                time.Enabled = false;
                timer2.Enabled = false;
                picGameOver.Visible = true;
                btnSave.Enabled = true;
                btnReplay.Enabled = true;
                btnThoat.Enabled = true;
                gamespeed = 0;
                lbSpeed.Text = "Speed = " + gamespeed.ToString() + " MPH";
            }
            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                SoundPlayer carcrash = new SoundPlayer(@"G:\IT\carcrash.wav");
                carcrash.Play();
                time.Enabled = false;
                timer2.Enabled = false;
                picGameOver.Visible = true;
                btnSave.Enabled = true;
                btnReplay.Enabled = true;
                btnThoat.Enabled = true;
                gamespeed = 0;
                lbSpeed.Text = "Speed = " + gamespeed.ToString() + " MPH";
            }
            if (car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                SoundPlayer carcrash = new SoundPlayer(@"G:\IT\carcrash.wav");
                carcrash.Play();
                time.Enabled = false;
                timer2.Enabled = false;
                picGameOver.Visible = true;
                btnSave.Enabled = true;
                btnReplay.Enabled = true;
                btnThoat.Enabled = true;
                gamespeed = 0;
                lbSpeed.Text = "Speed = " + gamespeed.ToString() + " MPH";
            }
        }

        void coinscollection()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                SoundPlayer coinscollect = new SoundPlayer(@"G:\IT\coins.wav");
                coinscollect.Play();
                collectedcoin++;
                points += 1 * gamespeed;
                lbCoins.Text = "Coins = " + collectedcoin.ToString();
                lbPoints.Text = "Points = " + points.ToString();
                x = r.Next(90, 450);
                coin1.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                SoundPlayer coinscollect = new SoundPlayer(@"G:\IT\coins.wav");
                coinscollect.Play();
                collectedcoin++;
                points += 1 * gamespeed;
                lbCoins.Text = "Coins = " + collectedcoin.ToString();
                lbPoints.Text = "Points = " + points.ToString();
                x = r.Next(90, 450);
                coin2.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                SoundPlayer coinscollect = new SoundPlayer(@"G:\IT\coins.wav");
                coinscollect.Play();
                collectedcoin++;
                points += 1 * gamespeed;
                lbCoins.Text = "Coins = " + collectedcoin.ToString();
                lbPoints.Text = "Points = " + points.ToString();
                x = r.Next(90, 450);
                coin3.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                SoundPlayer coinscollect = new SoundPlayer(@"G:\IT\coins.wav");
                coinscollect.Play();
                collectedcoin++;
                points += 1 * gamespeed;
                lbCoins.Text = "Coins = " + collectedcoin.ToString();
                lbPoints.Text = "Points = " + points.ToString();
                x = r.Next(90, 450);
                coin4.Location = new Point(x, 0);
            }
        }

        int gamespeed = 0;


        private void StartNewGame1Player()
        {
            var gameForm = new OnePlayer();
            gameForm.Show();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            SoundPlayer et = new SoundPlayer(@"G:\IT\mouseclick.wav");
            et.Play();
            DialogResult kq;
            kq = MessageBox.Show("Are you sure you want to quit the game?", "Exit", MessageBoxButtons.YesNo);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            SoundPlayer rp = new SoundPlayer(@"G:\IT\mouseclick.wav");
            rp.Play();
            DialogResult dgr;
            dgr = MessageBox.Show("Do you want to play again?", "Replay", MessageBoxButtons.YesNo);
            if (dgr == DialogResult.Yes)
            {
                this.StartNewGame1Player();
                this.Close();
            }
        }

        private void OnePlayer_Load(object sender, EventArgs e)
        {
            timeLeft = 50;
            lbCountDown.Text = "READY!";
            time.Start();
            btnSave.Enabled = false;
            btnReplay.Enabled = false;
            btnThoat.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SoundPlayer cp = new SoundPlayer(@"G:\IT\mouseclick.wav");
            cp.Play();
            SaveScore sc = new SaveScore();
            sc.MdiParent = this.MdiParent;
            sc.YourCoin = collectedcoin.ToString();
            sc.YourPoint = points.ToString();
            sc.Show();
        }

        int i = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            i++;
            lbTimer.Text = i.ToString() + "s";
            if (lbTimer.Text == "5s")
            {
                gamespeed++;
            }
            if (lbTimer.Text == "10s")
            {
                gamespeed++;
            }
            if (lbTimer.Text == "15s")
            {
                gamespeed++;
            }
            if (lbTimer.Text == "20s")
            {
                gamespeed++;
            }
            if (lbTimer.Text == "30s")
            {
                gamespeed++;
            }
            if (lbTimer.Text == "40s")
            {
                gamespeed++;
            }
            if (lbTimer.Text == "50s")
            {
                gamespeed++;
            }
            if (lbTimer.Text == "60s")
            {
                gamespeed++;
            }
            if (lbTimer.Text == "70s")
            {
                gamespeed++;
            }
            if (lbTimer.Text == "80s")
            {
                gamespeed++;
            }
            if (lbTimer.Text == "90s")
            {
                gamespeed++;
            }
            if (lbTimer.Text == "100s")
            {
                gamespeed++;
            }
            if (lbTimer.Text == "110s")
            {
                gamespeed++;
            }
            if (lbTimer.Text == "120s")
            {
                gamespeed++;
            }
            if (lbTimer.Text == "130s")
            {
                gamespeed++;
            }
            if (lbTimer.Text == "140s")
            {
                gamespeed++;
            }
            if (lbTimer.Text == "150s")
            {
                gamespeed++;
            }
            if (lbTimer.Text == "160s")
            {
                gamespeed++;
            }
            if (lbTimer.Text == "170s")
            {
                gamespeed++;
            }
            if (lbTimer.Text == "180s")
            {
                gamespeed++;
            }
        }

        private void OnePlayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (car.Left > 90)
                {
                    car.Left += -20;
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                if (car.Right < 460)
                {
                    car.Left += 25;
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                {
                    gamespeed++;
                }
            }
        }
    }
}
