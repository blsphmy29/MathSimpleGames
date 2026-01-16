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
        int secretNumber;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            secretNumber = random.Next(1, 101);
        }

        private void InitializeComponent()
        {
            this.buttonGuess = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonGuess
            // 
            this.buttonGuess.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuess.Location = new System.Drawing.Point(12, 245);
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.Size = new System.Drawing.Size(356, 100);
            this.buttonGuess.TabIndex = 0;
            this.buttonGuess.Text = "Guess";
            this.buttonGuess.UseVisualStyleBackColor = true;
            this.buttonGuess.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.MaxLength = 100;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(356, 100);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(380, 357);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonGuess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Guess the Number Game";
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int guess;

          
            {
                MessageBox.Show("Please enter a valid number between 1 and 100.");
                return;
            }

            if (guess < 1 || guess > 100)
            {
                MessageBox.Show("Your guess is out of range! Please guess a number between 1 and 100.");
            }
            else if (guess < secretNumber)
            {
                MessageBox.Show("Too low! Try again.");
            }
            else if (guess > secretNumber)
            {
                MessageBox.Show("Too high! Try again.");
            }
            else
            {
                MessageBox.Show("Congratulations! You've guessed the number!");
                secretNumber = random.Next(1, 101); // Reset the game
            }

            richTextBox1.Clear();
            richTextBox1.Focus();
        }
    }
}
