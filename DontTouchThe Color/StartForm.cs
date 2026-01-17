using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DontTouchThe_Color
{
    public partial class StartForm : Form
    {
        Random rnd = new Random();
        Button[] colorButtons;
        Color forbiddenColor;
        Label lblScore;
        int score = 0;

        public StartForm()
        {
            InitializeComponent();
            this.Size = new Size(400, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Don't Touch The Color";

            SetupGame();
            NextRound();
        }

        private void SetupGame()
        {
            // Score label
            lblScore = new Label();
            lblScore.Text = "Score: 0";
            lblScore.Font = new Font("Arial", 16);
            lblScore.AutoSize = true;
            lblScore.Location = new Point(150, 20);
            this.Controls.Add(lblScore);

            // Create 4 buttons
            colorButtons = new Button[4];
            for (int i = 0; i < 4; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(80, 80);
                btn.Location = new Point(50 + (i % 2) * 120, 100 + (i / 2) * 120);
                btn.Click += ColorButton_Click;
                colorButtons[i] = btn;
                this.Controls.Add(btn);
            }
        }

        private void NextRound()
        {
            // Pick a forbidden color
            forbiddenColor = GetRandomColor();

            // Assign random colors to buttons
            foreach (Button btn in colorButtons)
            {
                Color c;
                do
                {
                    c = GetRandomColor();
                } while (c == forbiddenColor); // avoid forbidden color by default
                btn.BackColor = c;
            }

            // Randomly assign forbidden color to one button
            int forbiddenIndex = rnd.Next(colorButtons.Length);
            colorButtons[forbiddenIndex].BackColor = forbiddenColor;
        }

        private Color GetRandomColor()
        {
            Color[] colors = new Color[] { Color.Red, Color.Green, Color.Blue, Color.Yellow };
            return colors[rnd.Next(colors.Length)];
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            if (clicked.BackColor == forbiddenColor)
            {
                MessageBox.Show("Game Over!\nYour score: " + score);
                score = 0;
            }
            else
            {
                score++;
            }

            lblScore.Text = "Score: " + score;
            NextRound();
        }
    }
}
