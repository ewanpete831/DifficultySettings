using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DifficultySettings
{
    public partial class Form1 : Form
    {
        //setup Variables
        string heroName;
        string difficultyLevel = "Nonexistant";

        public Form1()
        {
            InitializeComponent();
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            //set name and difficulty variables
            heroName = nameInput.Text;
            difficultyLevel = "Easy";

            //button stays coloured
            easyButton.BackColor = Color.Lime;
            normalButton.BackColor = Color.Black;
            hardButton.BackColor = Color.Black;
        }

        private void normalButton_Click(object sender, EventArgs e)
        {
            //set name and difficulty variables
            heroName = nameInput.Text;
            difficultyLevel = "Intermediate";

            //button stays coloured
            easyButton.BackColor = Color.Black;
            normalButton.BackColor = Color.Yellow;
            hardButton.BackColor = Color.Black;
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            //set name and difficulty variables
            heroName = nameInput.Text;
            difficultyLevel = "Hard";

            //button stays coloured
            easyButton.BackColor = Color.Black;
            normalButton.BackColor = Color.Black;
            hardButton.BackColor = Color.Red;
        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            //make sure hero name is updated
            heroName = nameInput.Text;

            //set output text
            outputLabel.Text = $"Welcome, {heroName}" + 
                $"\nThe Bravest Hero of all! You have selected the {difficultyLevel} Path";
        }
    }
}
