using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure_Game
{
    public partial class Form1 : Form
    {

        int life;

        public Form1()
        {
            InitializeComponent();

            outputLabel.Text = "You wake up beside a river on a river bank.You try to \n turn on your phone, it's dead, but you remember \n charging it when you went to sleep.";

            redLabel.Text = "Look for a clue in the shack";
            blueLabel.Text = "Look for a clue in the forest";

            pictureBox.Image = Properties.Resources.river_bank;
        }

        //private bool blueButtonState;
        //private bool redButtonState;

        private void blueButton_Click(object sender, EventArgs e)
        {
            // int blue1 = 1;
            // int red1 = 1;

            {
                Button btnSender = (Button)sender;

                if (btnSender == redButton)
                {
                    outputLabel.Text = "You find Arachnid Ned (king of Spider land), you have 20% chance of survival";
                    pictureBox.Image = Properties.Resources.arachnid_ned;

                    Random randGen = new Random();
                    life = randGen.Next(1, 6);

                    switch (life)
                    {
                        case 1:
                            pictureBox.Image = Properties.Resources.lost;

                            break;
                        case 2:
                            pictureBox.Image = Properties.Resources.lost;

                            break;
                        case 3:
                            pictureBox.Image = Properties.Resources.lost;

                            break;
                        case 4:
                            pictureBox.Image = Properties.Resources.lost;

                            break;
                        case 5:
                            outputLabel.Text = "He seems to be hungry and all the fleas on his back seemed to be aggravating him.";
                            redLabel.Text = "run";
                            blueLabel.Text = "walk";

                            pictureBox.Image = Properties.Resources.arachnid_ned;

                            break;
                    }
                }

                else if (btnSender == blueButton)
                {
                    outputLabel.Text = "You find two paths";

                    redLabel.Text = "Go right";
                    blueLabel.Text = "Go left";

                    pictureBox.Image = Properties.Resources.two_paths;
                }
            }
        }

        /* blueButtonState = true;
        int blue1 = 1;
        int red1 = 1;

        outputLabel.Text = "You find two paths";

        redLabel.Text = "Go right";
        blueLabel.Text = "Go left";

        pictureBox.Image = Properties.Resources.two_paths;

        blue1 += 2;

        if (blue1 == 1)
        {
            redButtonState = true;
        }

        if (redButtonState == true & red1 == 1)
        {
            outputLabel.Text = "You find Arachnid Ned (king of Spider land)";

            Random randGen = new Random();
            life = randGen.Next(1, 3);

            switch (life)
            {
                case 1:

                    break;
            }

            redLabel.Text = "You drink";
            blueLabel.Text = "Go across";

            pictureBox.Image = Properties.Resources.lake;

            red1 += 2;
        }

        if (blueButtonState == true & blue1 == 3)
        {
            outputLabel.Text = "You encounter a lake, You are thirsty";

            redLabel.Text = "You drink";
            blueLabel.Text = "Go across";

            pictureBox.Image = Properties.Resources.lake;

            blue1 += 2;
        }
    }
    */
        private void redButton_Click(object sender, EventArgs e)
        {
            Button btnSender = (Button)sender;

            if (btnSender == redButton)
            {
                outputLabel.Text = "You find Arachnid Ned (king of Spider land), you have 20% chance of survival";
                pictureBox.Image = Properties.Resources.arachnid_ned;

                Random randGen = new Random();
                life = randGen.Next(1, 6);

                switch (life)
                {
                    case 1:
                        pictureBox.Image = Properties.Resources.lost;
                        return;
                    case 2:
                        pictureBox.Image = Properties.Resources.lost;
                        return;
                    case 3:
                        pictureBox.Image = Properties.Resources.lost;
                        return;
                    case 4:
                        pictureBox.Image = Properties.Resources.lost;
                        return;
                    case 5:
                        outputLabel.Text = "He seems to be hungry and all the fleas on his back seemed to be aggravating him.";
                        redLabel.Text = "run";
                        blueLabel.Text = "walk";

                        pictureBox.Image = Properties.Resources.arachnid_ned;

                        break;
                }
            }
        }
    }
}
