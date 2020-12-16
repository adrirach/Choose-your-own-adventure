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
namespace Choose_your_own_adventure
{
    public partial class MineCraft : Form
    {
        int scene = 0;
        public MineCraft()
        {
            InitializeComponent();
            scenes.BackgroundImage = Properties.Resources.Minecraft_Forest;
            outputtext.Text = "You arrive in your brand new world ready to explore. \nYou look around, digesting the surrondings around you. \nYou feel ready to start your new adventure. \nBut where do you start?  ";
            abuttontext.Text = "Do you wanna go left?";
            dbuttontext.Text = "Do you wanna go right?";
        }


        private void Minecraft_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void keydown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    scene = 4;
                }
                else if (scene == 2)
                {
                    scene = 7;
                }
                else if (scene == 3)
                {
                    scene = 5;
                }
                else if (scene == 4)
                {
                    scene = 11;
                }
                else if (scene == 5)
                {
                    scene = 11;
                }
                else if (scene == 6)
                {
                    scene = 11;
                }
                else if (scene == 7)
                {
                    scene = 11;
                }
                else if (scene == 8)
                {
                    scene = 9;
                }
                else if (scene == 9)
                {
                    scene = 11;
                }
                else if (scene == 10)
                {
                    scene = 11;
                }
                else if (scene == 11)
                {
                    scene = 0;
                }
            }
                else if (e.KeyCode == Keys.D)
                {
                if (scene == 0)
                {
                    scene = 2;
                }

                else if (scene == 1)
                {
                    scene = 3;
                }
                else if (scene == 2)
                {
                    scene = 8;
                }
                else if (scene == 3)
                {
                    scene = 6;
                }
                else if (scene == 4)
                {
                    scene = 11;
                }
                else if (scene == 5)
                {
                    scene = 11;
                }
                else if (scene == 6)
                {
                    scene = 11;
                }
                else if (scene == 7)
                {
                    scene = 11;
                }
                else if (scene == 8)
                {
                    scene = 10;
                }
                else if (scene == 9)
                {
                    scene = 11;
                }
                else if (scene == 10)
                {                 
                    scene = 11;

                }
                else if (scene == 11)
                {
                    Application.Exit();
                }

            }
            switch (scene)
            {
                case 0:
                    scenes.BackgroundImage = Properties.Resources.Minecraft_Forest;
                    outputtext.Text = "You arrive in your brand new world ready to explore. \nYou look around, digesting the surrondings around you. \nYou feel ready to start your new adventure. \nBut where do you start?  ";
                    abuttontext.Text = "Do you wanna go left?";
                    dbuttontext.Text = "Do you wanna go right?";
                    break;
                case 1:
                    scenes.BackgroundImage = Properties.Resources.ravine_2;
                    outputtext.Text = "You start heading left. \nEventually finding your self right beside a ravine.";
                    abuttontext.Text = "Do you try jumping the ravine?";
                    dbuttontext.Text = "Or just go around?";
                    break;
                case 2:
                    scenes.BackgroundImage = Properties.Resources.snow;                    
                    outputtext.Text = "You start heading right. \nEventually finding yourself in s a snow biome. \nYou notice a very big cavern in a mountain.";
                    abuttontext.Text = "Do you explore the cave?";
                    dbuttontext.Text = "Or gather materials?";               
                    break;
                case 3:
                    scenes.BackgroundImage = Properties.Resources.night;
                    outputtext.Text = "Going around the ravine does take a bit of time, \nyou start feeling hungry and exhausted. \nNight is about to fall.";
                    abuttontext.Text = "Do you seek shelter?";
                    dbuttontext.Text = "Or build shelter?";
                   break;
                case 4:
                    scenes.BackgroundImage = Properties.Resources.gameover;
                    outputtext.Text = "With jumping the ravine, you undershoot the jump, \nresulting in you plummeting to your death. Game Over";
                    abuttontext.Text = "Next";
                    dbuttontext.Text = "";

                    break;
                case 5:
                    scenes.BackgroundImage = Properties.Resources.gameover;
                    outputtext.Text = "Seeking shelter does not go as planned, and a two creepers appear. \nYou very stupidly try to use dirt as your weapon of choice, \nbut the creepers ignite, \nresulting in your journey coming to an end. \nGame Over .";
                    abuttontext.Text = "Next";
                    dbuttontext.Text = "";
                    break;
                case 6:
                    scenes.BackgroundImage = Properties.Resources.end;
                    outputtext.Text = "You gather the essentials and start making your house. \nIt goes very well, with your house looking great. \nYou get set up and are ready to sleep. It is a success!";
                    abuttontext.Text = "Next";
                    dbuttontext.Text = "";
                    break;
                case 7:
                    scenes.BackgroundImage = Properties.Resources.gameover;
                    outputtext.Text = "Exploring the cave with no materials backfires! \nAn Enderman appears and isn't happy that you made eye contact, \nYou put up a fight with your fist, \nBut ultimatley you die\nGame Over";
                    abuttontext.Text = "Next";
                    dbuttontext.Text = "";
                    break;
                case 8:
                    scenes.BackgroundImage = Properties.Resources.night;
                    outputtext.Text = "Your Materials are now gathered and you have gathered some food from mobs. \nNight is now upon you.";
                    abuttontext.Text = "Do you go mining?";
                    dbuttontext.Text = "Or get resources For A Bed?";                   
                    break;
                case 9:                 
                    outputtext.Text = "With the resources you have gathered, mining is very easy. \nMobs do pose a threat but you do make it out of the mine. \nYou have successfully survived your first day in Minecraft.";
                    scenes.BackgroundImage = Properties.Resources.end;
                    abuttontext.Text = "Next";
                    dbuttontext.Text = "";
                    break;
                case 10:
                    scenes.BackgroundImage = Properties.Resources.gameover;
                    outputtext.Text = "Gathering resources for a bed at nighttime does not go as planned. \nYou do put up a fight, taking down a few zombies,\nbut a creeper sneaks up and ignites. Resluting in your demise.\nGame Over";
                    abuttontext.Text = "Next";
                    dbuttontext.Text = "";
                    break;
                case 11:                    
                    outputtext.Text = " Play again ";
                    abuttontext.Text = "Yes";
                    dbuttontext.Text = "No";
                    break;



            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}


