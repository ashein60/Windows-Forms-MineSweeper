using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class MainForm : Form
    {
        private Grid grid1;
        private int gridWidth, gridHeight, bombs;
        public  int GridWidth
        {
            get { return gridWidth; }
            set { gridWidth = value; }
        }
        public int GridHeight
        {
            get { return gridHeight; }
            set { gridHeight = value; }
        }
        public int Bombs
        {
            get { return bombs; }
            set { bombs = value; }
        }

        public MainForm()
        {
            InitializeComponent();
            DefaultGrid();
            NewGame();
        }

        //Start and End Game
        public void NewGame()
        {
            grid1 = new Grid(gridWidth, gridHeight, bombs);
            ResizeGame();
            gamePanel.Invalidate();
        }
        private void ResizeGame()
        {
            gamePanel.Width = gridWidth * Square.Width - 1;
            gamePanel.Height = gridHeight * Square.Height - 1;
        }
        private void DefaultGrid()
        {
            gridWidth = 10;
            gridHeight = 10;
            bombs = 10;
        }

        //Click
        private void gamePanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (!grid1.Destroyed) //if game isn't over
            {
                if (e.Button == MouseButtons.Left) //reveal square if left click
                {
                    grid1.Click(e.X, e.Y, true);
                }
                else if (e.Button == MouseButtons.Right) //add a flag if right clicked
                {
                    grid1.Click(e.X, e.Y, false);
                }
            }

            gamePanel.Invalidate();
        }

        //Buttons
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(this);
            settingsForm.ShowDialog();
        }

        //Paint
        private void gamePanel_Paint(object sender, PaintEventArgs e)
        {
            grid1.Paint(e);
        }
    }
}
