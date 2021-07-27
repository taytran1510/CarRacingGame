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

namespace CarRacingGame
{
    public partial class PlayerName : Form
    {
        public PlayerName()
        {
            InitializeComponent();
        }

        private void PlayerName_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtPlayer1;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            TwoPlayer tp = new TwoPlayer();
            tp.MdiParent = this.MdiParent;
            tp.Player1Name = txtPlayer1.Text;
            if (txtPlayer2.Text == txtPlayer1.Text)
            {
                MessageBox.Show("Names cannot be duplicated. Please fill again!", "Warning", MessageBoxButtons.OK);
            }
            else if (txtPlayer1.Text == "" || txtPlayer2.Text == "")
            {
                MessageBox.Show("Names cannot be blank. Please fill again!", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                tp.Player2Name = txtPlayer2.Text;
                tp.Show();
                this.Close();
            }
        }
    }
}
