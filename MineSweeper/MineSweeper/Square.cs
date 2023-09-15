using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MineSweeper
{
    public class Square
    {
        private static readonly int width = 25;
        private static readonly int height = 25;
        public static int Width
        {
            get { return width; }
        }
        public static int Height
        {
            get { return height; }
        }

        private readonly int x, y;

        private bool hidden, flagged, bomb;
        private int numberOfBombs; //how many bombs are touching this square, -1 = bomb

        public bool Hidden
        {
            get { return hidden; }
            set { hidden = value; }
        }
        public bool Flagged
        {
            get { return flagged; }
        }
        public bool Bomb
        {
            get { return bomb; }
            set { bomb = value; }
        }
        public int NumberOfBombs
        {
            get { return numberOfBombs; }
            set { numberOfBombs = value; }
        }

        public Square(int x, int y)
        {
            this.x = x;
            this.y = y;

            hidden = true;
            flagged = false;
            bomb = false;
            numberOfBombs = -1;
        }

        public bool Click(int mouseX, int mouseY, bool reveal)
        {
            bool clicked = false;

            if (mouseX >= x && mouseX <= x + width)
            {
                if (mouseY >= y && mouseY <= y + height)
                {
                    if (reveal) //if attempt to reveal
                    {
                        if (!flagged) //reveal if no flag
                        {
                            hidden = false;
                        }
                    }
                    else if (hidden)//toggle flagged
                    {
                        if (flagged)
                        {
                            flagged = false;
                        }
                        else
                        {
                            flagged = true;
                        }
                    }
                    clicked = true;
                }
            }

            return clicked;
        }

        public void Paint(PaintEventArgs e, Brush[] numberFill, Font numberFont)
        {
            if (hidden)
            {
                Brush fill = new SolidBrush(Color.FromArgb(190, 190, 190));
                e.Graphics.FillRectangle(fill, x, y, width - 1, height - 1);
                fill.Dispose();

                if (flagged) //draw an x
                {
                    Pen flagPen = new Pen(Color.Red);
                    flagPen.Width = 2;
                    e.Graphics.DrawLine(flagPen, x + 5, y + 5, x + width - 6, y + height - 6);
                    e.Graphics.DrawLine(flagPen, x + width - 6, y + 5, x + 5, y + height - 6);
                    flagPen.Dispose();
                }
            }
            else
            {
                Brush fill = new SolidBrush(Color.FromArgb(225, 225, 225));
                e.Graphics.FillRectangle(fill, x, y, width - 1, height - 1); //paints background
                fill.Dispose();

                if (bomb) //is bomb
                {
                    Brush bombBrush = new SolidBrush(Color.Black);
                    e.Graphics.FillEllipse(bombBrush, x + 3, y + 3, width - 7, height - 7);
                    bombBrush.Dispose();
                }
                else //number how close to bomb
                {
                    if (numberOfBombs > 0)
                    {
                        e.Graphics.DrawString(Convert.ToString(numberOfBombs), numberFont, numberFill[numberOfBombs - 1], x + 1, y - 2);
                    }
                }
            }
        }
    }
}
