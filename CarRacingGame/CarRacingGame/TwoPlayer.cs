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

namespace CarRacingGame
{
    public partial class TwoPlayer : Form
    {
        public TwoPlayer()
        {
            InitializeComponent();
            picGameOver_1.Visible = false;
            picGameOver_2.Visible = false;
        }

        string strPlayer1;
        string strPlayer2;

        int timeLeft1;
        int timeLeft2;

        private void countdown1()
        {
            if (timeLeft1 > 0)
            {
                timeLeft1 = timeLeft1 - 1;
                lbCountDown.Text = timeLeft1.ToString();
                if (timeLeft1 == 0)
                {
                    lbCountDown.Text = "GO";
                    timerPL1.Start();
                    gamespeedpl1++;
                }
            }
            else
            {
                lbCountDown.Visible = false;
            }
        }

        private void countdown2()
        {
            if (timeLeft2 > 0)
            {
                timeLeft2 = timeLeft2 - 1;
                lbCountDown2.Text = timeLeft2.ToString();
                if (timeLeft2 == 0)
                {
                    lbCountDown2.Text = "GO";
                    timerPL2.Start();
                    gamespeedpl2++;
                }
            }
            else
            {
                lbCountDown2.Visible = false;
            }
        }

        public string Player1Name
        {
            get
            {
                return strPlayer1;
            }
            set
            {
                strPlayer1 = value;
            }
        }

        public string Player2Name
        {
            get
            {
                return strPlayer2;
            }
            set
            {
                strPlayer2 = value;
            }
        }

        int collectedcoinpl1 = 0;
        int collectedcoinpl2 = 0;

        Random r = new Random();
        Random s = new Random();
        int x;
        void enemyforplayer1(int speed)
        {
            if (enemy1.Top >= 500)
            {
                x = r.Next(100, 390);
                enemy1.Location = new Point(x, 0);
            }
            else
            {
                enemy1.Top += speed;
            }
            if (enemy2.Top >= 500)
            {
                x = r.Next(100, 400);
                enemy2.Location = new Point(x, 0);
            }
            else
            {
                enemy2.Top += speed;
            }
            if (enemy3.Top >= 500)
            {
                x = r.Next(100, 410);
                enemy3.Location = new Point(x, 0);
            }
            else
            {
                enemy3.Top += speed;
            }
            if (enemy1.Location == enemy2.Location || enemy2.Location == enemy3.Location || enemy1.Location == enemy3.Location)
            {
                enemy1.Location = new Point(x, 0);
                enemy2.Location = new Point(x, 0);
                enemy3.Location = new Point(x, 0);
            }
        }

        int y;
        void enemyforplayer2(int speed)
        {
            if (enemy4.Top >= 500)
            {
                y = s.Next(530, 860);
                enemy4.Location = new Point(y, 0);
            }
            else
            {
                enemy4.Top += speed;
            }
            if (enemy5.Top >= 500)
            {
                y = s.Next(530, 870);
                enemy5.Location = new Point(y, 0);
            }
            else
            {
                enemy5.Top += speed;
            }
            if (enemy6.Top >= 500)
            {
                y = s.Next(530, 880);
                enemy6.Location = new Point(y, 0);
            }
            else
            {
                enemy6.Top += speed;
            }
            if (enemy4.Location == enemy5.Location || enemy5.Location == enemy6.Location || enemy4.Location == enemy6.Location)
            {
                enemy4.Location = new Point(y, 0);
                enemy5.Location = new Point(y, 0);
                enemy6.Location = new Point(y, 0);
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
            if (tree9.Top >= 500)
            {
                tree9.Top = 0;
            }
            else
            {
                tree9.Top += speed;
            }
            if (tree10.Top >= 500)
            {
                tree10.Top = 0;
            }
            else
            {
                tree10.Top += speed;
            }
            if (tree11.Top >= 500)
            {
                tree11.Top = 0;
            }
            else
            {
                tree11.Top += speed;
            }
            if (tree12.Top >= 500)
            {
                tree12.Top = 0;
            }
            else
            {
                tree12.Top += speed;
            }
        }

        void coinplayer1(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = r.Next(100, 390);
                coin1.Location = new Point(x, 0);
            }
            else
            {
                coin1.Top += speed;
            }
            if (coin2.Top >= 500)
            {
                x = r.Next(100, 390);
                coin2.Location = new Point(x, 0);
            }
            else
            {
                coin2.Top += speed;
            }
            if (coin3.Top >= 500)
            {
                x = r.Next(100, 390);
                coin3.Location = new Point(x, 0);
            }
            else
            {
                coin3.Top += speed;
            }
            if (coin1.Location == coin2.Location || coin2.Location == coin3.Location || coin1.Location == coin3.Location)
            {
                coin1.Location = new Point(x, 0);
                coin2.Location = new Point(x, 0);
                coin3.Location = new Point(x, 0);
            }
        }

        void coinplayer2(int speed)
        {
            if (coin5.Top >= 500)
            {
                y = s.Next(530, 860);
                coin5.Location = new Point(y, 0);
            }
            else
            {
                coin5.Top += speed;
            }
            if (coin6.Top >= 500)
            {
                y = s.Next(530, 860);
                coin6.Location = new Point(y, 0);
            }
            else
            {
                coin6.Top += speed;
            }
            if (coin7.Top >= 500)
            {
                y = s.Next(530, 860);
                coin7.Location = new Point(y, 0);
            }
            else
            {
                coin7.Top += speed;
            }
            if (coin5.Location == coin6.Location || coin6.Location == coin7.Location || coin5.Location == coin7.Location)
            {
                coin5.Location = new Point(y, 0);
                coin6.Location = new Point(y, 0);
                coin7.Location = new Point(y, 0);
            }
        }

        void gameoverplayer1()  
        {
            if (Car1.Bounds.IntersectsWith(enemy1.Bounds))
            {
                SoundPlayer cc1 = new SoundPlayer(@"G:\IT\carcrash.wav");
                cc1.Play();
                time_player1.Enabled = false;
                timerPL1.Enabled = false;
                picGameOver_1.Visible = true;
                gamespeedpl1 = 0;
                lbSpeed1.Text = "Speed = " + gamespeedpl1.ToString() + " MPH";
            }
            if (Car1.Bounds.IntersectsWith(enemy2.Bounds))
            {
                SoundPlayer cc2 = new SoundPlayer(@"G:\IT\carcrash.wav");
                cc2.Play();
                time_player1.Enabled = false;
                timerPL1.Enabled = false;
                picGameOver_1.Visible = true;
                gamespeedpl1 = 0;
                lbSpeed1.Text = "Speed = " + gamespeedpl1.ToString() + " MPH";
            }
            if (Car1.Bounds.IntersectsWith(enemy3.Bounds))
            {
                SoundPlayer cc3 = new SoundPlayer(@"G:\IT\carcrash.wav");
                cc3.Play();
                time_player1.Enabled = false;
                timerPL1.Enabled = false;
                picGameOver_1.Visible = true;
                gamespeedpl1 = 0;
                lbSpeed1.Text = "Speed = " + gamespeedpl1.ToString() + " MPH";
            }
        }

        void gameoverplayer2()
        {
            if (Car2.Bounds.IntersectsWith(enemy4.Bounds))
            {
                SoundPlayer cc4 = new SoundPlayer(@"G:\IT\carcrash.wav");
                cc4.Play();
                time_player2.Enabled = false;
                timerPL2.Enabled = false;
                picGameOver_2.Visible = true;
                gamespeedpl2 = 0;
                lbSpeed2.Text = "Speed = " + gamespeedpl2.ToString() + " MPH";
            }
            if (Car2.Bounds.IntersectsWith(enemy5.Bounds))
            {
                SoundPlayer cc5 = new SoundPlayer(@"G:\IT\carcrash.wav");
                cc5.Play();
                time_player2.Enabled = false;
                timerPL2.Enabled = false;
                picGameOver_2.Visible = true;
                gamespeedpl2 = 0;
                lbSpeed2.Text = "Speed = " + gamespeedpl2.ToString() + " MPH";
            }
            if (Car2.Bounds.IntersectsWith(enemy6.Bounds))
            {
                SoundPlayer cc6 = new SoundPlayer(@"G:\IT\carcrash.wav");
                cc6.Play();
                time_player2.Enabled = false;
                timerPL2.Enabled = false;
                picGameOver_2.Visible = true;
                gamespeedpl2 = 0;
                lbSpeed2.Text = "Speed = " + gamespeedpl2.ToString() + " MPH";
            }
        }

        void enablebtn()
        {
            if (time_player1.Enabled == false && time_player2.Enabled == false)
            {
                int a = int.Parse(pointpl1.ToString());
                int b = int.Parse(pointpl2.ToString());
                if (a > b)
                {
                    MessageBox.Show("The winner is " + lbpl1.Text + "!", "Result", MessageBoxButtons.OK);
                }
                if (a < b)
                {
                    MessageBox.Show("The winner is " + lbpl2.Text + "!", "Result", MessageBoxButtons.OK);
                }
                if (a == b)
                {
                    MessageBox.Show("Draw!", "Result", MessageBoxButtons.OK);
                }
                btnReplay.Enabled = true;
                btnThoat.Enabled = true;
            }
        }

        void coinscollectionpl1()
        {
            if (Car1.Bounds.IntersectsWith(coin1.Bounds))
            {
                SoundPlayer coinspl1 = new SoundPlayer(@"G:\IT\coins.wav");
                coinspl1.Play();
                collectedcoinpl1++;
                pointpl1 += 1 * gamespeedpl1;
                lbCoinsPl1.Text = "Coins = " + collectedcoinpl1.ToString();
                lbPointPL1.Text = "Points = " + pointpl1.ToString();
                x = r.Next(90, 450);
                coin1.Location = new Point(x, 0);
            }
            if (Car1.Bounds.IntersectsWith(coin2.Bounds))
            {
                SoundPlayer coinspl1 = new SoundPlayer(@"G:\IT\coins.wav");
                coinspl1.Play();
                collectedcoinpl1++;
                pointpl1 += 1 * gamespeedpl1;
                lbCoinsPl1.Text = "Coins = " + collectedcoinpl1.ToString();
                lbPointPL1.Text = "Points = " + pointpl1.ToString();
                x = r.Next(90, 450);
                coin2.Location = new Point(x, 0);
            }
            if (Car1.Bounds.IntersectsWith(coin3.Bounds))
            {
                SoundPlayer coinspl1 = new SoundPlayer(@"G:\IT\coins.wav");
                coinspl1.Play();
                collectedcoinpl1++;
                pointpl1 += 1 * gamespeedpl1;
                lbCoinsPl1.Text = "Coins = " + collectedcoinpl1.ToString();
                lbPointPL1.Text = "Points = " + pointpl1.ToString();
                x = r.Next(90, 450);
                coin3.Location = new Point(x, 0);
            }
        }

        void coinscollectionpl2()
        {
            if (Car2.Bounds.IntersectsWith(coin5.Bounds))
            {
                SoundPlayer coinspl2 = new SoundPlayer(@"G:\IT\coins.wav");
                coinspl2.Play();
                collectedcoinpl2++;
                pointpl2 += 1 * gamespeedpl2;
                lbCoinsPl2.Text = "Coins = " + collectedcoinpl2.ToString();
                lbPointPL2.Text = "Points = " + pointpl2.ToString();
                y = s.Next(500, 850);
                coin5.Location = new Point(y, 0);
            }
            if (Car2.Bounds.IntersectsWith(coin6.Bounds))
            {
                SoundPlayer coinspl2 = new SoundPlayer(@"G:\IT\coins.wav");
                coinspl2.Play();
                collectedcoinpl2++;
                pointpl2 += 1 * gamespeedpl2;
                lbCoinsPl2.Text = "Coins = " + collectedcoinpl2.ToString();
                lbPointPL2.Text = "Points = " + pointpl2.ToString();
                y = s.Next(500, 850);
                coin6.Location = new Point(x, 0);
            }
            if (Car2.Bounds.IntersectsWith(coin7.Bounds))
            {
                SoundPlayer coinspl2 = new SoundPlayer(@"G:\IT\coins.wav");
                coinspl2.Play();
                collectedcoinpl2++;
                pointpl2 += 1 * gamespeedpl2;
                lbCoinsPl2.Text = "Coins = " + collectedcoinpl2.ToString();
                lbPointPL2.Text = "Points = " + pointpl2.ToString();
                y = s.Next(500, 850);
                coin7.Location = new Point(y, 0);
            }
        }

        int gamespeedpl1 = 0;
        int gamespeedpl2 = 0;
        double pointpl1 = 0;
        double pointpl2 = 0;

        private void TwoPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z)
            {
                if (Car1.Left > 80)
                {
                    Car1.Left += -20;
                }
            }
            if (e.KeyCode == Keys.C)
            {
                if (Car1.Right < 410)
                {
                    Car1.Left += 20;
                }
            }
            if (e.KeyCode == Keys.S)
            {
                if (gamespeedpl1 < 21)
                {
                    gamespeedpl1++;
                }
            }
            if (e.KeyCode == Keys.Left)
            {
                if (Car2.Left > 510)
                {
                    Car2.Left += -20;
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                if (Car2.Right < 880)
                {
                    Car2.Left += 20;
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                if (gamespeedpl2 < 21)
                {
                    gamespeedpl2++;
                }
            }
        }

        private void StartNewGame2Player()
        {
            var nameForm = new PlayerName();
            nameForm.Show();
        }

        private void TwoPlayer_Load(object sender, EventArgs e)
        {
            timeLeft1 = 50;
            timeLeft2 = 50;
            lbCountDown.Text = "READY!";
            lbCountDown2.Text = "READY!";
            time.Start();
            lbpl1.Text = Player1Name;
            lbpl2.Text = Player2Name;
            lbPlay1.Text = Player1Name;
            lbPlay2.Text = Player2Name;
            btnReplay.Enabled = false;
            btnThoat.Enabled = false;
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            SoundPlayer rp = new SoundPlayer(@"G:\IT\mouseclick.wav");
            rp.Play();
            DialogResult dgr;
            dgr = MessageBox.Show("Do you want to play again?", "Replay", MessageBoxButtons.YesNo);
            if (dgr == DialogResult.Yes)
            {
                this.StartNewGame2Player();
                this.Close();
            }
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

        private void time_player2_Tick(object sender, EventArgs e)
        {
            countdown2();
            moveline(gamespeedpl2);
            movetree(gamespeedpl2);
            enemyforplayer2(gamespeedpl2);
            coinplayer2(gamespeedpl2);
            coinscollectionpl2();
            gameoverplayer2();
            enablebtn();
            lbSpeed2.Text = "Speed = " + gamespeedpl2.ToString() + " MPH";
        }

        private void time_player1_Tick(object sender, EventArgs e)
        {
            countdown1();
            moveline(gamespeedpl1);
            movetree(gamespeedpl1);
            enemyforplayer1(gamespeedpl1);
            coinplayer1(gamespeedpl1);
            coinscollectionpl1();
            gameoverplayer1();
            enablebtn();
            lbSpeed1.Text = "Speed = " + gamespeedpl1.ToString() + " MPH";
        }

        int i = 0;
        private void timerPL1_Tick(object sender, EventArgs e)
        {
            i++;
            lbTimerPlayer1.Text = i.ToString() + "s";
            if (lbTimerPlayer1.Text == "5s")
            {
                gamespeedpl1++;
            }
            if (lbTimerPlayer1.Text == "10s")
            {
                gamespeedpl1++;
            }
            if (lbTimerPlayer1.Text == "15s")
            {
                gamespeedpl1++;
            }
            if (lbTimerPlayer1.Text == "20s")
            {
                gamespeedpl1++;
            }
            if (lbTimerPlayer1.Text == "30s")
            {
                gamespeedpl1++;
            }
            if (lbTimerPlayer1.Text == "40s")
            {
                gamespeedpl1++;
            }
            if (lbTimerPlayer1.Text == "50s")
            {
                gamespeedpl1++;
            }
            if (lbTimerPlayer1.Text == "60s")
            {
                gamespeedpl1++;
            }
            if (lbTimerPlayer1.Text == "70s")
            {
                gamespeedpl1++;
            }
            if (lbTimerPlayer1.Text == "80s")
            {
                gamespeedpl1++;
            }
            if (lbTimerPlayer1.Text == "90s")
            {
                gamespeedpl1++;
            }
            if (lbTimerPlayer1.Text == "100s")
            {
                gamespeedpl1++;
            }
            if (lbTimerPlayer1.Text == "110s")
            {
                gamespeedpl1++;
            }
            if (lbTimerPlayer1.Text == "120s")
            {
                gamespeedpl1++;
            }
            if (lbTimerPlayer1.Text == "130s")
            {
                gamespeedpl1++;
            }
            if (lbTimerPlayer1.Text == "140s")
            {
                gamespeedpl1++;
            }
            if (lbTimerPlayer1.Text == "150s")
            {
                gamespeedpl1++;
            }
            if (lbTimerPlayer1.Text == "160s")
            {
                gamespeedpl1++;
            }
            if (lbTimerPlayer1.Text == "170s")
            {
                gamespeedpl1++;
            }
            if (lbTimerPlayer1.Text == "180s")
            {
                gamespeedpl1++;
            }
        }

        int j = 0;
        private void timerPL2_Tick(object sender, EventArgs e)
        {
            j++;
            lbTimerPlayer2.Text = j.ToString() + "s";
            if (lbTimerPlayer2.Text == "5s")
            {
                gamespeedpl2++;
            }
            if (lbTimerPlayer2.Text == "10s")
            {
                gamespeedpl2++;
            }
            if (lbTimerPlayer2.Text == "15s")
            {
                gamespeedpl2++;
            }
            if (lbTimerPlayer2.Text == "20s")
            {
                gamespeedpl2++;
            }
            if (lbTimerPlayer2.Text == "30s")
            {
                gamespeedpl2++;
            }
            if (lbTimerPlayer2.Text == "40s")
            {
                gamespeedpl2++;
            }
            if (lbTimerPlayer2.Text == "50s")
            {
                gamespeedpl2++;
            }
            if (lbTimerPlayer2.Text == "60s")
            {
                gamespeedpl2++;
            }
            if (lbTimerPlayer2.Text == "70s")
            {
                gamespeedpl2++;
            }
            if (lbTimerPlayer2.Text == "80s")
            {
                gamespeedpl2++;
            }
            if (lbTimerPlayer2.Text == "90s")
            {
                gamespeedpl2++;
            }
            if (lbTimerPlayer2.Text == "100s")
            {
                gamespeedpl2++;
            }
            if (lbTimerPlayer2.Text == "110s")
            {
                gamespeedpl2++;
            }
            if (lbTimerPlayer2.Text == "120s")
            {
                gamespeedpl2++;
            }
            if (lbTimerPlayer2.Text == "130s")
            {
                gamespeedpl2++;
            }
            if (lbTimerPlayer2.Text == "140s")
            {
                gamespeedpl2++;
            }
            if (lbTimerPlayer2.Text == "150s")
            {
                gamespeedpl2++;
            }
            if (lbTimerPlayer2.Text == "160s")
            {
                gamespeedpl2++;
            }
            if (lbTimerPlayer2.Text == "170s")
            {
                gamespeedpl2++;
            }
            if (lbTimerPlayer2.Text == "180s")
            {
                gamespeedpl2++;
            }
        }
    }
}
