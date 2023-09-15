using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MineSweeper
{
    public class Grid
    {
        private Square[,] squares;
        private int width, height;

        private bool won;
        private bool destroyed;
        public bool Destroyed
        {
            get { return destroyed; }
        }

        public Grid(int width, int height, int numOfBombs)
        {
            this.width = width;
            this.height = height;

            squares = new Square[width, height];
            CreateGrid();
            CreateBombs(numOfBombs);
            SetNumOfBombsTouching();

            won = false;
            destroyed = false;
        }

        private void CreateGrid()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    squares[x, y] = new Square(x * Square.Width, y * Square.Height);
                }
            }
        }
        private void CreateBombs(int numOfBombs)
        {
            Random rand = new Random();

            for (int i = 0; i < numOfBombs; i++)
            {
                int posX, posY;

                do //randomize a bomb location until it's placed in an empty spot
                {
                    posX = rand.Next(0, width);
                    posY = rand.Next(0, height);

                } while (squares[posX, posY].Bomb);

                squares[posX, posY].Bomb = true; //place the bomb
            }
        }
        private void SetNumOfBombsTouching()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (!squares[x, y].Bomb)
                    {
                        squares[x, y].NumberOfBombs = CountBombsTouching(x, y, width, height);
                    }
                }
            }
        }
        private int CountBombsTouching(int x, int y, int width, int height)
        {
            int amount = 0;

            amount += CheckBomb(x - 1, y, width, height); //left
            amount += CheckBomb(x - 1, y - 1, width, height); //upper left
            amount += CheckBomb(x, y - 1, width, height); //up
            amount += CheckBomb(x + 1, y - 1, width, height); //upper right
            amount += CheckBomb(x + 1, y, width, height); //right
            amount += CheckBomb(x + 1, y + 1, width, height); //lower right
            amount += CheckBomb(x, y + 1, width, height); //down
            amount += CheckBomb(x - 1, y + 1, width, height); //lower left

            return amount;
        }
        private int CheckBomb (int x, int y, int width, int height) //returns 1 if bomb 
        {
            int bomb = 0;

            if (x >= 0 && x < width)
            {
                if (y >= 0 && y < height)
                {
                    if (squares[x, y].Bomb)
                    {
                        bomb = 1;
                    }
                }
            }

            return bomb;
        }

        public void Click(int mouseX, int mouseY, bool reveal)
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (squares[x, y].Click(mouseX, mouseY, reveal))
                    {
                        if (reveal && !squares[x ,y].Flagged) //only if reveal and not flagged the square
                        {
                            if (squares[x, y].Bomb)
                            {
                                destroyed = true; //clicked a bomb, game over
                            }
                            else if (squares[x, y].NumberOfBombs == 0)
                            {
                                squares[x, y].Hidden = true; //reset for recursion method
                                RevealTouchingHidden(x, y);
                            }

                            CheckWin();
                        }
                        break; 
                    }
                }
            }
        }
        private void RevealTouchingHidden(int x, int y)
        {
            if (x >= 0 && x < width && y >= 0 && y < height) //within bounds
            {
                if (squares[x, y].Hidden && !squares[x, y].Bomb) //reveal if hidden and not bomb
                {
                    squares[x, y].Hidden = false;

                    if (squares[x, y].NumberOfBombs == 0) //recursion if empty
                    {
                        //every square touching
                        RevealTouchingHidden(x - 1, y - 1); //left-up
                        RevealTouchingHidden(x - 1, y + 1); //left-down
                        RevealTouchingHidden(x - 1, y); //left

                        RevealTouchingHidden(x + 1, y - 1); //right-up
                        RevealTouchingHidden(x + 1, y + 1); //right-down
                        RevealTouchingHidden(x + 1, y); //right

                        RevealTouchingHidden(x, y - 1);  //up
                        RevealTouchingHidden(x, y + 1); //down
                    }
                }
            }
        }
        private void CheckWin()
        {
            won = true;

            foreach (Square square in squares)
            {
                if (square.Hidden && !square.Bomb)
                {
                    won = false; //if any non-bomb is hidden, game is still going
                    break;
                }
            }

            if (won)
            {
                destroyed = true;
            }
        }

        public void Paint(PaintEventArgs e)
        {
            //create font and brushes for text
            Font numberFont = new Font("Franklin Gothic", 17, FontStyle.Bold); //Cambria, Franklin Gothic
            Brush[] numberFill = CreateNumberBrush();

            //paint squares
            foreach (Square square in squares)
            {
                square.Paint(e, numberFill, numberFont);
            }

            //remove font and brushes
            for (int i = 0; i < numberFill.Length; i++)
            {
                numberFill[i].Dispose();
            }

            numberFont.Dispose();
        }
        private Brush[] CreateNumberBrush()
        {
            Brush[] numberFill = new SolidBrush[8];
            numberFill[0] = new SolidBrush(Color.FromArgb(0, 60, 255)); //blue
            numberFill[1] = new SolidBrush(Color.FromArgb(0, 150, 0)); //green
            numberFill[2] = new SolidBrush(Color.FromArgb(255, 0, 0)); //red
            numberFill[3] = new SolidBrush(Color.FromArgb(0, 200, 255)); //light blue
            numberFill[4] = new SolidBrush(Color.FromArgb(180, 255, 0)); //light green
            numberFill[5] = new SolidBrush(Color.FromArgb(255, 0, 180)); //light red
            numberFill[6] = new SolidBrush(Color.FromArgb(0, 50, 160)); //dark blue
            numberFill[7] = new SolidBrush(Color.FromArgb(0, 80, 0)); //dark green

            return numberFill;
        }
    }
}
