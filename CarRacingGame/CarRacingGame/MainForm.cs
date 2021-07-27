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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            SoundPlayer btnplayc = new SoundPlayer(@"G:\IT\mouseclick.wav");
            btnplayc.Play();
            ChoosePlayer cp = new ChoosePlayer();
            cp.MdiParent = this.MdiParent;
            cp.Show();
        }

        private void btnHTP_Click(object sender, EventArgs e)
        {
            SoundPlayer btnhtpc = new SoundPlayer(@"G:\IT\mouseclick.wav");
            btnhtpc.Play();
            HowToPlay htp = new HowToPlay();
            htp.MdiParent = this.MdiParent;
            htp.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            SoundPlayer btnexit = new SoundPlayer(@"G:\IT\mouseclick.wav");
            btnexit.Play();
            DialogResult dr;
            dr = MessageBox.Show("Are you sure you want to quit the game?", "Exit", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SoundPlayer msplay = new SoundPlayer(@"G:\IT\music.wav");
            msplay.Play();
        }
    }
}
