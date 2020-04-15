using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Adventure_Game
{
    public partial class AdventureGame : Form
    {

        int scene = 0;

        SoundPlayer player;

        Random randGen = new Random();

        int random;

        public AdventureGame()
        {
            InitializeComponent();

            player = new SoundPlayer(Properties.Resources.game_start_sound);
            player.Play();

            pictureBox.Image = Properties.Resources.river_bank;

            outputLabel.Text = "You wake up beside a river on a river bank.You try to turn on your phone, it's dead, but you remember charging it when you went to sleep. \n \n Press 'R' button on keyboard for red option. \n Press 'B' button on keyboard for blue option";
            redLabel.Text = "Go in the shack";
            blueLabel.Text = "Go in the forest";

        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene

            if (e.KeyCode.Equals(Keys.R))      //red button press
            {
                if (scene == 0) { scene = 2; }
                else if (scene == 1) { scene = 4; }
                else if (scene == 2) { scene = 6; }
                else if (scene == 3) { scene = 99; }
                else if (scene == 5) { scene = 7; }
                else if (scene == 6) { scene = 10; }
                else if (scene == 7) { scene = 9; }
                else if (scene == 8) { scene = 99; }

                else if (scene == 9) { scene = 10; }
                else if (scene == 10) { scene = 9; }
                else if (scene == 11) { scene = 13; }
                else if (scene == 12) { scene = 99; }
                else if (scene == 14) { scene = 15; }
                else if (scene == 15) { scene = 99; }
                else if (scene == 16) { scene = 13; }
                else if (scene == 17) { scene = 21; }
                else if (scene == 18) { scene = 20; }

                else if (scene == 20) { scene = 24; }
                else if (scene == 21) { scene = 23; }
                else if (scene == 24) { scene = 26; }
                else if (scene == 25) { scene = 27; }

                else if (scene == 28) { scene = 29; }
                else if (scene == 29) { scene = 89; }
                else if (scene == 89) { scene = 0; }
                else if (scene == 99) { scene = 0; }

            }
            else if (e.KeyCode.Equals(Keys.B))  //blue button press
            {
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 3; }
                else if (scene == 2) { scene = 5; }
                else if (scene == 3) { scene = 30; }
                else if (scene == 5) { scene = 6; }
                else if (scene == 6) { scene = 28; }
                else if (scene == 7) { scene = 10; }
                else if (scene == 8) { scene = 12; }

                else if (scene == 9) { scene = 99; }
                else if (scene == 10) { scene = 11; }
                else if (scene == 11) { scene = 12; }
                else if (scene == 12) { scene = 14; }
                else if (scene == 14) { scene = 16; }
                else if (scene == 15) { scene = 99; }
                else if (scene == 16) { scene = 99; }
                else if (scene == 17) { scene = 18; }

                else if (scene == 20) { scene = 25; }
                else if (scene == 21) { scene = 22; }
                else if (scene == 24) { scene = 99; }
                else if (scene == 25) { scene = 21; }
                else if (scene == 28) { scene = 21; }
                else if (scene == 29) { scene = 89; }
                else if (scene == 89) { scene = 100; }
                else if (scene == 99) { scene = 100; }

            }

            /// Display text and game options to screen based on the current scene
            switch (scene)
            {
                case 0:
                    player = new SoundPlayer(Properties.Resources.game_start_sound);
                    player.Play();

                    pictureBox.Image = Properties.Resources.river_bank;

                    outputLabel.Text = "You wake up beside a river on a river bank.You try to turn on your phone, it's dead, but you remember charging it when you went to sleep.";
                    redLabel.Text = "Go in the shack";
                    blueLabel.Text = "Go in the forest";
                    break;

                case 1:
                    pictureBox.Image = Properties.Resources.two_paths;

                    outputLabel.Text = "You find two paths";
                    redLabel.Text = "Go right";
                    blueLabel.Text = "Go left";
                    break;

                case 2:
                    pictureBox.Image = Properties.Resources.creepy_stairs;

                    outputLabel.Text = "You find stairs up to the attic";
                    redLabel.Text = "Go up the stairs";
                    blueLabel.Text = "explore first floor";
                    break;

                case 3:
                    pictureBox.Image = Properties.Resources.lake;

                    outputLabel.Text = "You encounter a lake, You are thirsty";
                    redLabel.Text = "Drink from it";
                    blueLabel.Text = "Go across";

                    break;

                case 4:
                    pictureBox.Image = Properties.Resources.arachnid_ned;

                    outputLabel.Text = "You find Arachnid Ned (king of Spider land) \n You have 20% chance of survival";
                    redLabel.Text = "";
                    blueLabel.Text = "";

                    random = randGen.Next(1, 5);

                    switch (random)
                    {
                        case 1:
                            pictureBox.Image = Properties.Resources.lost;

                            player = new SoundPlayer(Properties.Resources.game_over_sound);
                            player.Play();

                            outputLabel.Text = "Play again?";

                            redLabel.Text = "Yes";
                            blueLabel.Text = "No";

                            break;

                        case 2:
                            pictureBox.Image = Properties.Resources.lost;

                            player = new SoundPlayer(Properties.Resources.game_over_sound);
                            player.Play();

                            outputLabel.Text = "Play again?";

                            redLabel.Text = "Yes";
                            blueLabel.Text = "No";

                            break;

                        case 3:
                            pictureBox.Image = Properties.Resources.lost;

                            player = new SoundPlayer(Properties.Resources.game_over_sound);
                            player.Play();

                            outputLabel.Text = "Play again?";

                            redLabel.Text = "Yes";
                            blueLabel.Text = "No";

                            break;

                        case 4:
                            pictureBox.Image = Properties.Resources.lost;

                            player = new SoundPlayer(Properties.Resources.game_over_sound);
                            player.Play();

                            outputLabel.Text = "Play again?";

                            redLabel.Text = "Yes";
                            blueLabel.Text = "No";

                            break;

                        case 5:
                            pictureBox.Image = Properties.Resources.arachnid_2;

                            scene = 8;

                            break;

                        default:
                            break;
                    }
                    break;

                case 5:
                    pictureBox.Image = Properties.Resources.old_stove;

                    outputLabel.Text = "You find the kitchen stove on ";
                    redLabel.Text = "Explore kitchen";
                    blueLabel.Text = "Take stairs";
                    break;

                case 6:
                    pictureBox.Image = Properties.Resources.duffel_bag;

                    outputLabel.Text = "You find a bloody duffel bag";
                    redLabel.Text = "Look outside";
                    blueLabel.Text = "Open";
                    break;

                case 7:
                    pictureBox.Image = Properties.Resources.ripped_curtains;

                    outputLabel.Text = "You see that the curtains of the living room seemed to be thrashed and ripped apart. You can see a liquid on them. ";
                    redLabel.Text = "Explore kitchen";
                    blueLabel.Text = "Go outside";
                    break;

                case 8:
                    pictureBox.Image = Properties.Resources.arachnid_2;

                    outputLabel.Text = "He seems to be hungry and all the fleas on his back seemed to be aggravating him.";
                    redLabel.Text = "Run away";
                    blueLabel.Text = "Walk away";
                    break;

                case 9:
                    pictureBox.Image = Properties.Resources.colourless_liquid;

                    outputLabel.Text = "You find a clear colourless liquid in the pantry.";
                    redLabel.Text = "Go outside";
                    blueLabel.Text = "Drink it";
                    break;

                case 10:
                    pictureBox.Image = Properties.Resources.man_on_swings;

                    outputLabel.Text = "You see someone sitting on the swings in the backyard";
                    redLabel.Text = "Go back";
                    blueLabel.Text = "See who it is";
                    break;

                case 11:
                    pictureBox.Image = Properties.Resources.dead_man;

                    outputLabel.Text = "He is dead and has a bloody knife beside him in the grass.";
                    redLabel.Text = "Pick up knife";
                    blueLabel.Text = "Run into woods";
                    break;

                case 12:
                    pictureBox.Image = Properties.Resources.lion;

                    outputLabel.Text = "You encounter a lion";
                    redLabel.Text = "Run away";
                    blueLabel.Text = "Walk away";
                    break;

                case 13:
                    pictureBox.Image = Properties.Resources.poison_knife;

                    outputLabel.Text = "It has poison on it. \n You have 70% of survival";
                    redLabel.Text = "";
                    blueLabel.Text = "";

                    Thread.Sleep(2000);

                    random = randGen.Next(1, 11);

                    switch (random)
                    {
                        case 1:
                            pictureBox.Image = Properties.Resources.lost;

                            player = new SoundPlayer(Properties.Resources.game_over_sound);
                            player.Play();

                            outputLabel.Text = "Play again?";

                            redLabel.Text = "Yes";
                            blueLabel.Text = "No";

                            break;

                        case 2:
                            pictureBox.Image = Properties.Resources.lost;

                            player = new SoundPlayer(Properties.Resources.game_over_sound);
                            player.Play();

                            outputLabel.Text = "Play again?";

                            redLabel.Text = "Yes";
                            blueLabel.Text = "No";

                            break;

                        case 3:
                            pictureBox.Image = Properties.Resources.lost;

                            player = new SoundPlayer(Properties.Resources.game_over_sound);
                            player.Play();

                            outputLabel.Text = "Play again?";

                            redLabel.Text = "Yes";
                            blueLabel.Text = "No";

                            break;

                        case 4:
                            pictureBox.Image = Properties.Resources.stairs;

                            scene = 17;
                            break;

                        case 5:
                            pictureBox.Image = Properties.Resources.stairs;

                            scene = 17;

                            break;

                        case 6:
                            pictureBox.Image = Properties.Resources.stairs;

                            scene = 17;

                            break;

                        case 7:
                            pictureBox.Image = Properties.Resources.stairs;

                            scene = 17;

                            break;

                        case 8:
                            pictureBox.Image = Properties.Resources.stairs;

                            scene = 17;

                            break;

                        case 9:
                            pictureBox.Image = Properties.Resources.stairs;

                            scene = 17;

                            break;

                        case 10:
                            pictureBox.Image = Properties.Resources.stairs;

                            scene = 17;

                            break;

                        default:
                            break;
                    }
                    break;

                case 14:
                    pictureBox.Image = Properties.Resources.back_to_the_shack;

                    outputLabel.Text = "The lion is following you. You make a few sharp turns in an attempt to lose him, it doesn't work.You reach the shack.";
                    redLabel.Text = "Go into house";
                    blueLabel.Text = "Kill it";
                    break;

                case 15:
                    pictureBox.Image = Properties.Resources.lion_2;

                    outputLabel.Text = "The lion corners you and you get eaten";
                    redLabel.Text = "";
                    blueLabel.Text = "";

                    break;

                case 16:
                    pictureBox.Image = Properties.Resources.dinner;

                    outputLabel.Text = "You have your dinner";
                    redLabel.Text = "Eat or";
                    blueLabel.Text = "Not to eat";
                    break;

                case 17:
                    pictureBox.Image = Properties.Resources.stairs;

                    outputLabel.Text = "You find stairs behind the shed.";
                    redLabel.Text = "Go around";
                    blueLabel.Text = "Go up";
                    break;

                case 18:
                    pictureBox.Image = Properties.Resources.scooby;

                    outputLabel.Text = "There is an apartment up there and the Scooby Doo theme song is playing ";
                    redLabel.Text = "You don't sing";
                    blueLabel.Text = "You sing";
                    break;

                case 19:
                    pictureBox.Image = Properties.Resources.sunset;

                    outputLabel.Text = "You fly into the sunset. You wake up, it was all a dream.";
                    redLabel.Text = "";
                    blueLabel.Text = "";

                    Thread.Sleep(2000);

                    scene = 89;

                    break;

                case 20:
                    pictureBox.Image = Properties.Resources.red_will;

                    outputLabel.Text = "You encounter a will which seems as if it's written in red ink.";
                    redLabel.Text = "You read it";
                    blueLabel.Text = "Leave it alone";
                    break;

                case 21:
                    pictureBox.Image = Properties.Resources.grave;

                    outputLabel.Text = "You find a grave marked That cold ain't the weather, it's death approaching. As soon as you read that, you feel an unidentified breeze. As you turn around you think you saw a ghost. ";
                    redLabel.Text = "Go to grave";
                    blueLabel.Text = "Face the ghost";
                    break;

                case 22:
                    pictureBox.Image = Properties.Resources.trap;

                    outputLabel.Text = "It really was a trap";
                    redLabel.Text = "";
                    blueLabel.Text = "";

                    Thread.Sleep(2000);

                    scene = 99;

                    break;

                case 23:
                    pictureBox.Image = Properties.Resources.ghost;

                    outputLabel.Text = "The ghost takes your soul and you go to the devil";
                    redLabel.Text = "";
                    blueLabel.Text = "";

                    Thread.Sleep(2000);

                    scene = 99;

                    break;

                case 24:
                    pictureBox.Image = Properties.Resources.cage;

                    outputLabel.Text = "It's a trap and a cage falls on you, there is no way out and the only thing you have is a Swiss army knife. ";
                    redLabel.Text = "You don't cut through";
                    blueLabel.Text = "cut through";
                    break;

                case 25:
                    pictureBox.Image = Properties.Resources.door_and_window;

                    outputLabel.Text = "You are trapped and the only two ways out are the door or the window";
                    redLabel.Text = "Go through window";
                    blueLabel.Text = "Go through door";
                    break;

                case 26:
                    pictureBox.Image = Properties.Resources.masked_person;

                    outputLabel.Text = "A person in a mask comes and throws you outside the window.";
                    redLabel.Text = "";
                    blueLabel.Text = "";

                    Thread.Sleep(2000);

                    scene = 19;
                    break;

                case 27:
                    pictureBox.Image = Properties.Resources.arrow_2;

                    outputLabel.Text = "There are arrows faced up and you fall to your death.";
                    redLabel.Text = "";
                    blueLabel.Text = "";

                    Thread.Sleep(2000);

                    scene = 99;

                    break;

                case 28:
                    pictureBox.Image = Properties.Resources.flying_spoon;

                    outputLabel.Text = "A spoon flies out at you and you catch it. It has the letters Dr.F engraved on it. You look further and you find a cashiers' name tag labelled Dr. Faart. You have heard that name before and decide to search it around the house and find a book.";
                    redLabel.Text = "Open it";
                    blueLabel.Text = "Leave it alone";
                    break;

                case 29:
                    pictureBox.Image = Properties.Resources.my_name_is_faart;

                    outputLabel.Text = "You found out he was your long lost brother and you wake up screaming, My last name isn't Faart!";
                    redLabel.Text = "";
                    blueLabel.Text = "";

                    Thread.Sleep(1000);
                    break;

                case 30:

                    outputLabel.Text = "You have 50% chance of survival";
                    redLabel.Text = "";
                    blueLabel.Text = "";

                    random = randGen.Next(1, 3);

                    switch (random)
                    {

                        case 1:
                            pictureBox.Image = Properties.Resources.lost;

                            player = new SoundPlayer(Properties.Resources.game_over_sound);
                            player.Play();

                            outputLabel.Text = "Play again?";

                            redLabel.Text = "Yes";
                            blueLabel.Text = "No";

                            scene = 99;
                            break;

                        case 2:
                            scene = 12;
                            break;
                    }
                    break;

                case 99:

                    player = new SoundPlayer(Properties.Resources.game_over_sound);
                    player.Play();

                    pictureBox.Image = Properties.Resources.lost;

                    outputLabel.Text = "Play again?";

                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";

                    Thread.Sleep(3000);
                    break;

                case 89:
                    player = new SoundPlayer(Properties.Resources.game_start_sound);
                    player.Play();

                    pictureBox.Image = Properties.Resources.winner_screen;

                    outputLabel.Text = "Play again?";

                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";

                    Thread.Sleep(3000);

                    break;
                case 100:
                    Close();
                    break;
            }
        }
    }
}
