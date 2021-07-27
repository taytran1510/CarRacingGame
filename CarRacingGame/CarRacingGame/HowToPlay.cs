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
    public partial class HowToPlay : Form
    {
        public HowToPlay()
        {
            InitializeComponent();
        }

        private void btnPlayer1_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"G:\IT\mouseclick.wav");
            sp.Play();
            HTP1Player player1htp = new HTP1Player();
            player1htp.MdiParent = this.MdiParent;
            player1htp.Show();
        }

        private void btnPlayer2_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"G:\IT\mouseclick.wav");
            sp.Play();
            HTP2Player player2htp = new HTP2Player();
            player2htp.MdiParent = this.MdiParent;
            player2htp.Show();
        }
    }
}
