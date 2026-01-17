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
        Label labelScore;
        int score = 0;

        public StartForm()
        {
            InitializeComponent();
            this.Size = new Size(620, 450);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Don't Touch The Color";

            SetupGame();
            NextRound();
        }

        private void SetupGame()
        {
            // Score label
            labelScore = new Label();
            labelScore.Text = "Score: 0";
            labelScore.Font = new Font("Arial", 16);
            labelScore.AutoSize = true;
            labelScore.Location = new Point(150, 20);
            this.Controls.Add(labelScore);

            // Create 4 buttons
            colorButtons = new Button[4];
            for (int i = 0; i < 4; i++)
            {
                Button button = new Button();
                button.Size = new Size(80, 80);
                button.Location = new Point(50 + (i % 2) * 120, 100 + (i / 2) * 120);
                button.Click += ColorButton_Click;
                colorButtons[i] = button;
                this.Controls.Add(button);
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

            labelScore.Text = "Score: " + score;
            NextRound();
        }
    }
}
