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
using System.IO;

namespace CarRacingGame
{
    public partial class SaveScore : Form
    {
        public SaveScore()
        {
            InitializeComponent();
        }

        private void ReadFile()
        {
            lstHighScore.View = View.Details;
            lstHighScore.Columns.Add("Names");
            lstHighScore.Columns.Add("Total Coins");
            lstHighScore.Columns.Add("Total Points");
            for (int i = 0; i < lstHighScore.Columns.Count; i++)
            {
                lstHighScore.Columns[i].Width = -2;
            }
            string[] lines = File.ReadAllLines(@"G:\IT\HighScore.txt");
            for (int i = 0; i + 2 < lines.Length; i += 3)
            {
                lstHighScore.Items.Add(new ListViewItem(new[]
                {
                        lines[i],
                        lines[i + 1],
                        lines[i + 2]
                }));
            }
            for (int i = 0; i < lstHighScore.Columns.Count; i++)
            {
                lstHighScore.Columns[i].Width = -2;
            }
        }
        string strCoin;
        string strPoint;
        public string YourCoin
        {
            get
            {
                return strCoin;
            }
            set
            {
                strCoin = value;
            }
        }

        public string YourPoint
        {
            get
            {
                return strPoint;
            }
            set
            {
                strPoint = value;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SoundPlayer cp = new SoundPlayer(@"G:\IT\mouseclick.wav");
            cp.Play();
            if (txtName.Text == "")
            {
                MessageBox.Show("Name cannot be blank. Please fill again!", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                ListViewItem lstItem = lstHighScore.Items.Add(txtName.Text);
                lstItem.SubItems.Add(txtCoin.Text);
                lstItem.SubItems.Add(txtPoint.Text);
                StreamWriter txt = new StreamWriter(@"G:\IT\HighScore.txt", append: true);
                for (int i = 0; i + 4 < lstHighScore.Items.Count; i += 3)
                {
                    txt.WriteLine(txtName.Text);
                    txt.WriteLine(txtCoin.Text);
                    txt.WriteLine(txtPoint.Text);
                }
                txt.Close();
                btnAdd.Enabled = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SoundPlayer cp = new SoundPlayer(@"G:\IT\mouseclick.wav");
            cp.Play();
            lstHighScore.Items.Clear();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            SoundPlayer cp = new SoundPlayer(@"G:\IT\mouseclick.wav");
            cp.Play();
            DialogResult kq;
            kq = MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButtons.YesNo);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void SaveScore_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtName;
            txtCoin.Text = YourCoin;
            txtPoint.Text = YourPoint;
            ReadFile();
        }
    }
}
