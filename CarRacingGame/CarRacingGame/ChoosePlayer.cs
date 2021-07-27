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
    public partial class ChoosePlayer : Form
    {
        public ChoosePlayer()
        {
            InitializeComponent();
        }

        private void btnPlayer1_Click(object sender, EventArgs e)
        {
            SoundPlayer cp = new SoundPlayer(@"G:\IT\mouseclick.wav");
            cp.Play();
            OnePlayer op = new OnePlayer();
            op.MdiParent = this.MdiParent;
            op.Show();
            this.Close();
        }

        private void btnPlayer2_Click(object sender, EventArgs e)
        {
            SoundPlayer cp = new SoundPlayer(@"G:\IT\mouseclick.wav");
            cp.Play();
            PlayerName pn = new PlayerName();
            pn.MdiParent = this.MdiParent;
            pn.Show();
            this.Close();
        }
    }
}
