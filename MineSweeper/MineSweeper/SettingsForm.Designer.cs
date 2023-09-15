namespace MineSweeper
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rowsLabel = new System.Windows.Forms.Label();
            this.rowsText = new System.Windows.Forms.TextBox();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.columnsText = new System.Windows.Forms.TextBox();
            this.columnsLabel = new System.Windows.Forms.Label();
            this.bombsText = new System.Windows.Forms.TextBox();
            this.bombsLabel = new System.Windows.Forms.Label();
            this.newGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rowsLabel
            // 
            this.rowsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowsLabel.Location = new System.Drawing.Point(15, 90);
            this.rowsLabel.Name = "rowsLabel";
            this.rowsLabel.Size = new System.Drawing.Size(85, 25);
            this.rowsLabel.TabIndex = 0;
            this.rowsLabel.Text = "Rows";
            this.rowsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rowsText
            // 
            this.rowsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowsText.Location = new System.Drawing.Point(100, 90);
            this.rowsText.Name = "rowsText";
            this.rowsText.Size = new System.Drawing.Size(75, 26);
            this.rowsText.TabIndex = 1;
            this.rowsText.Text = "10";
            this.rowsText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // settingsLabel
            // 
            this.settingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel.Location = new System.Drawing.Point(0, 15);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(200, 25);
            this.settingsLabel.TabIndex = 2;
            this.settingsLabel.Text = "Size Settings";
            this.settingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // columnsText
            // 
            this.columnsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnsText.Location = new System.Drawing.Point(100, 50);
            this.columnsText.Name = "columnsText";
            this.columnsText.Size = new System.Drawing.Size(75, 26);
            this.columnsText.TabIndex = 4;
            this.columnsText.Text = "10";
            this.columnsText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnsLabel
            // 
            this.columnsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnsLabel.Location = new System.Drawing.Point(15, 50);
            this.columnsLabel.Name = "columnsLabel";
            this.columnsLabel.Size = new System.Drawing.Size(85, 25);
            this.columnsLabel.TabIndex = 3;
            this.columnsLabel.Text = "Columns";
            this.columnsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bombsText
            // 
            this.bombsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bombsText.Location = new System.Drawing.Point(100, 130);
            this.bombsText.Name = "bombsText";
            this.bombsText.Size = new System.Drawing.Size(75, 26);
            this.bombsText.TabIndex = 6;
            this.bombsText.Text = "10";
            this.bombsText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bombsLabel
            // 
            this.bombsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bombsLabel.Location = new System.Drawing.Point(15, 130);
            this.bombsLabel.Name = "bombsLabel";
            this.bombsLabel.Size = new System.Drawing.Size(85, 25);
            this.bombsLabel.TabIndex = 5;
            this.bombsLabel.Text = "Bombs";
            this.bombsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // newGame
            // 
            this.newGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGame.Location = new System.Drawing.Point(25, 170);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(140, 35);
            this.newGame.TabIndex = 7;
            this.newGame.TabStop = false;
            this.newGame.Text = "New Game";
            this.newGame.UseVisualStyleBackColor = true;
            this.newGame.MouseClick += new System.Windows.Forms.MouseEventHandler(this.newGame_MouseClick);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 220);
            this.Controls.Add(this.newGame);
            this.Controls.Add(this.bombsText);
            this.Controls.Add(this.bombsLabel);
            this.Controls.Add(this.columnsText);
            this.Controls.Add(this.columnsLabel);
            this.Controls.Add(this.settingsLabel);
            this.Controls.Add(this.rowsText);
            this.Controls.Add(this.rowsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rowsLabel;
        private System.Windows.Forms.TextBox rowsText;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.TextBox columnsText;
        private System.Windows.Forms.Label columnsLabel;
        private System.Windows.Forms.TextBox bombsText;
        private System.Windows.Forms.Label bombsLabel;
        private System.Windows.Forms.Button newGame;
    }
}