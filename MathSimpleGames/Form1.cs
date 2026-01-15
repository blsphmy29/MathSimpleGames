using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathSimpleGames
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ResetForm(); // load default state on startup
        }

        // LOAD FORM INTO PANEL
        public void loadform(Form form)
        {
            if (mainPanel.Controls.Count > 0)
            {
                var oldForm = mainPanel.Controls[0] as Form;
                oldForm?.Close();
                mainPanel.Controls.Clear();
            }

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(form);
            mainPanel.Tag = form;
            form.Show();
        }

        // RESET TO DEFAULT STATE
        private void ResetForm()
        {
            // Clear panel
            if (mainPanel.Controls.Count > 0)
            {
                var oldForm = mainPanel.Controls[0] as Form;
                oldForm?.Close();
                mainPanel.Controls.Clear();
            }

            // Reset variables here if you have any
            // score = 0;
            // lives = 3;

            // OPTIONAL: load home screen
            // loadform(new HomeForm());
        }

        // RESET / HOME BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        // LOAD GAME BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new MiniMathGame1());
        }
    }
}
