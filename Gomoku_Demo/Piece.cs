using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;    //引用form 的
using System.Drawing;          //引用 color 型別的涵式庫

namespace Gomoku_Demo
{
    abstract class Piece : PictureBox  //abstract 讓Piece建立黑棋或白棋，不要誤建錯
    {
        private static readonly int IMAGE_WIDTH = 50; 
        public Piece(int x , int y)
        {
            this.BackColor = Color.Transparent;
            this.Location = new Point(x - IMAGE_WIDTH  / 2, y - IMAGE_WIDTH / 2);   // point型別
            this.Size = new Size(IMAGE_WIDTH, IMAGE_WIDTH);
        }
    }
}
