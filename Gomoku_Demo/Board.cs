using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Gomoku_Demo
{
     class Board
    {
        private static readonly Point NO_MATCH_NODE = new Point(-1, -1); 

        private static readonly int OFFSET = 75;
        private static readonly int NODE_RADIUS = 10;
        private static readonly int NODE_DISTRANCE = 75;

        private Piece[,] pieces = new Piece[9,9];
        public bool CanBePlaced(int x , int y)    //判斷是否能放棋
        {
            // TODO: 找出最近的節點(NODE)
            Point nodeId = FindtheClosetNode(x, y);
            
            // TODO: 如果沒有的話，回傳false
            if(nodeId == NO_MATCH_NODE)
                return false;

            // TODO: 如果有的話，檢查是否已經棋子存在
            if (pieces[nodeId.X, nodeId.Y] != null)
                return false;
            
            return true;
        }
        public Piece PlaceAPiece(int x , int y, PieceType type)  // 傳type來 判斷黑或白色
        {
            // TODO: 找出最近的節點(NODE)
            Point nodeId = FindtheClosetNode(x, y);

            // TODO: 如果沒有的話，回傳false
            if (nodeId == NO_MATCH_NODE)
                return null;

            // TODO: 如果有的話，檢查是否已經棋子存在
            if (pieces[nodeId.X, nodeId.Y] != null)
                return null;

            // TODO: 根據type 產生對應的棋子
            if (type == PieceType.BLACK)
                pieces[nodeId.X, nodeId.Y] = new BlackPiece(x, y);
            else if (type == PieceType.WHITE)
                pieces[nodeId.X, nodeId.Y] = new WhitePiece(x, y);

            return pieces[nodeId.X, nodeId.Y];
        }
        private Point FindtheClosetNode(int x , int y)
        {
            int nodeIdX = FindtheClosetNode(x);
            if (nodeIdX == -1)
                return NO_MATCH_NODE;   //沒有符合的點

            int nodeIdY = FindtheClosetNode(y);
            if (nodeIdY == -1)
                return NO_MATCH_NODE;

            return new Point(nodeIdX, nodeIdY);
        }
        private int FindtheClosetNode(int pos)
        {
            if (pos < OFFSET - NODE_RADIUS)
                return -1;
            pos -= OFFSET;
            int quotient = pos / NODE_DISTRANCE;   // 商數
            int remainder = pos % NODE_DISTRANCE;  // 餘數
            
            if (remainder <= NODE_RADIUS)
                return quotient;
            else if (remainder >= NODE_RADIUS - NODE_RADIUS)
                return quotient + 1;
            else
                return -1;
        }
    }
}
