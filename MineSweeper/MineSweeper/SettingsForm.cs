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
    public partial class SettingsForm : Form
    {
        private MainForm mainForm;

        public SettingsForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            SetText();
        }
        private void SetText()
        {
            rowsText.Text = Convert.ToString(mainForm.GridHeight);
            columnsText.Text = Convert.ToString(mainForm.GridWidth);
            bombsText.Text = Convert.ToString(mainForm.Bombs);
        }

        private void newGame_MouseClick(object sender, MouseEventArgs e)
        {
            mainForm.GridWidth = Convert.ToInt32(columnsText.Text);
            mainForm.GridHeight = Convert.ToInt32(rowsText.Text);
            mainForm.Bombs = Convert.ToInt32(bombsText.Text);
            mainForm.NewGame();
            this.Close();
        }
    }
}
