using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gomoku_Demo
{
    internal class BlackPiece : Piece    // 繼承
    {
        public BlackPiece(int x , int y) : base(x , y)
        {
            this.Image = Properties.Resources.black;    //呼叫資料內的圖
        }
    }
}
