using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ball
{
    public class Ball
    {

        int posicionX;
        int posicionY;
        int radio;

        int velocidadX;
        int velocidadY;

        Color colorB;

        SolidBrush SolidBrushbrushB;
        Random rnd = new Random();


        Size bound;
        public Ball(Size s) //size del tamno del picture box
        {
            bound = s;

            posicionX = rnd.Next(0,s.Width);
            posicionY = rnd.Next(0,s.Height);
            radio = rnd.Next();
           
            velocidadX = rnd.Next();
            velocidadY = rnd.Next();


            SolidBrushbrushB = new SolidBrush(Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)));
;
         

            

        }

        public void Dibujar (Graphics g)

        {
           
            g.FillEllipse(SolidBrushbrushB, posicionX - radio /2, posicionY - radio, radio / 2, radio / 2);

           

        }

        public void Mover ()
        {
            posicionX = posicionX+ velocidadX;
            posicionY = posicionY +velocidadY;
            /*

            if (posicionX -radio <0 || posicionX + radio > ancho)
            {
                velocidadX = -velocidadX;

            }

            if (posicionX - radio < 0 || posicionX + radio > alto)
            {
                velocidadY = -velocidadY;
            }
            */
            

        }


    }
}
