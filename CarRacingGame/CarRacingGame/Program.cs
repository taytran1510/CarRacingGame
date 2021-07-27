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
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacingGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
