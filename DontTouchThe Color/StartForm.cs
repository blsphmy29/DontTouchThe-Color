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
        Random random = new Random();
        Button[] colorButtons;
        Color forbiddenColor;
        Label labelScore;
        Label labelInstruction;
        Label labelTimer;
        Timer gameTimer;
        int score = 0;
        int timeLeft = 10;

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
            labelScore.Location = new Point(20, 20);
            this.Controls.Add(labelScore);

            // Instruction label
            labelInstruction = new Label();
            labelInstruction.Font = new Font("Arial", 16);
            labelInstruction.AutoSize = true;
            labelInstruction.Location = new Point(20, 60);
            labelInstruction.ForeColor = Color.Black;
            this.Controls.Add(labelInstruction);

            // Timer label
            labelTimer = new Label();
            labelTimer.Text = "Time: 10";
            labelTimer.Font = new Font("Arial", 16);
            labelTimer.AutoSize = true;
            labelTimer.Location = new Point(250, 20);
            this.Controls.Add(labelTimer);

            gameTimer = new Timer();
            gameTimer.Interval = 1000; // 1 second
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();

            // Create 9 buttons
            colorButtons = new Button[9];

            int startX = 25;
            int startY = 100;
            int spacing = 120;


            for (int i = 0; i < 9; i++)
            {
                Button button = new Button();
                button.Size = new Size(100, 100);

                int col = i % 3;   // 0,1,2
                int row = i / 3;   // 0,1,2

                button.Location = new Point(
                    startX + col * spacing,
                    startY + row * spacing
                );

                button.Click += ColorButton_Click;
                colorButtons[i] = button;
                this.Controls.Add(button);
            }
        }

        private void ResetGame()
        {
            score = 0;
            timeLeft = 10;
            labelScore.Text = "Score: 0";
            labelTimer.Text = "Time: 10";
            gameTimer.Start();
            NextRound();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            labelTimer.Text = "Time: " + timeLeft;

            if (timeLeft <= 0)
            {
                gameTimer.Stop();
                MessageBox.Show("Time's up!\nYour score: " + score);
                ResetGame();
            }
        }

        private void NextRound()
        {
            // Pick a forbidden color
            forbiddenColor = GetRandomColor();
            labelInstruction.Text = "Don't touch the color " + forbiddenColor.Name.ToLower() + ".";
            labelInstruction.ForeColor = forbiddenColor;

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
            int forbiddenIndex = random.Next(colorButtons.Length);
            colorButtons[forbiddenIndex].BackColor = forbiddenColor;
        }

        private Color GetRandomColor()
        {
            Color[] colors = new Color[] { Color.Red, Color.Blue, Color.Yellow, Color.Green, Color.Orange, Color.Violet};
            return colors[random.Next(colors.Length)];
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            Button clicked = sender as Button;

            if (clicked.BackColor == forbiddenColor)
            {
                MessageBox.Show("Game Over!\nYour score: " + score);
                ResetGame();
            }
            else
            {
                score++;
                timeLeft++;
            }

            labelScore.Text = "Score: " + score;
            labelTimer.Text = "Time: " + timeLeft;
            NextRound();
        }
    }
}
