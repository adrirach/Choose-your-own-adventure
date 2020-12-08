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
    public partial class Form1 : Form
    {
        int scene = 0;
        public Form1()
        {
            InitializeComponent();
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
                    scene =9;
                }
                else if (scene == 9)
                {
                    scene = 11;
                }
                else if (scene == 10)
                {
                    scene = 11;
                }              
                else if (e.KeyCode == Keys.D) 
                {
                    if (scene == 0)
                    {
                        scene = 1;
                    }

                    else if (scene == 1)
                    {
                        scene = 2;
                    }
                    else if (scene == 2)
                    {
                        scene = 6;
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
                        scene = 20;
                    }
                    else if (scene == 9)
                    {
                        scene = 11;
                    }
                    else if (scene == 10)
                    {
                        scene = 11;
                    }

                }
            }
        }
    }
}
