using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace Roadbuilder
{
    sealed public partial class Roadbuilder : Form
    {

        public void OnLoad()
        {

        }

        public void OnUpdate()
        {
            //Beispiel
            //moveup();
        }

        public void OnRender(PaintEventArgs e)
        {
            //Beispiel
            //e.Graphics.FillRectangle(new SolidBrush(Color.Green), new Rectangle(new Point(x, 50), new Size(50, 50)));

            Texture2D test = new Texture2D("data\\res\\textures\\test.png");

             e.Graphics.FillRectangle(test.TextureBrush, new Rectangle(new Point(50, 50), new Size(50, 50)));
        }

        public void OnInput(string PressType, KeyEventArgs e)
        {
            if (PressType == KeyPressType.KEYDOWN)
            { 
                //Abfrage für Loslassen der Taste
            }
            else if (PressType == KeyPressType.KEYUP)
            { 
                //Abfrage für Drücken der Taste

                /*
                if (e.KeyCode == Keys.Up)
                {
                    moveup(); Beispiel
                }*/
            }
        }

        //Beispiel
        /*public void moveup()
        {
            x += 5;
        }*/

    }
}
