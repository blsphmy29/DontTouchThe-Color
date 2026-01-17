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
    public partial class mainMenu : Form
    {

        public mainMenu()
        {
            InitializeComponent();
        }

        private void LoadForm(Form form)
        {
            screenPanel.Controls.Clear(); 
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            screenPanel.Controls.Add(form);
            form.Show();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            LoadForm(new StartForm());
        }

        private void buttonOptions_Click(object sender, EventArgs e)
        {
            LoadForm(new OptionsForm());
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
