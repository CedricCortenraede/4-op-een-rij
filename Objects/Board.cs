using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4opeenrij
{
    class Board
    {
        public int BoardWidth, BoardHeight, Move;

        private int[,] board = new int[,] {
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 }, };

        public Board()
        {
            BoardWidth = 700;
            BoardHeight = 600;
            Move = 0;



            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    board[i, j] = 0;
                }
            }
        }
        public void drawBoard(PaintEventArgs e)
        {
            Console.WriteLine("Sup fgts");
            Pen line = new Pen(Color.Black);
            int lineXi = 0, lineXf = 700;
            int lineYi = 0, lineYf = 600;
            SolidBrush myBrush = new SolidBrush(Color.White);

            for (int startY = 0; startY <= BoardWidth; startY += 100)
            {
                e.Graphics.DrawLine(line, startY, lineYi, startY, lineYf);
            }

            for (int startX = 0; startX <= BoardHeight; startX += 100)
            {
                e.Graphics.DrawLine(line, lineXi, startX, lineXf, startX);
            }

            for (int y = 0; y <= BoardHeight; y += 100)
            {
                for (int x = 0; x <= BoardWidth; x += 100)
                {
                    e.Graphics.FillEllipse(myBrush, new Rectangle(x, y, 100, 100));
                }
            }

        }

        public void drawGamePiece(Color brushColor, int x, int y, Graphics f)
        {
            SolidBrush myBrush = new SolidBrush(brushColor);

            
            f.FillEllipse(myBrush, x * 100 - 100, (y * 100) - 100, 100, 100);

        }
    }
}