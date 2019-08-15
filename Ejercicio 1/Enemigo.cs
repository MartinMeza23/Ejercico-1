using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1
{
    class Enemigo
    {

        public int X { get; set; }
        public int Y { get; set; }

        public int Ganar 
        {
           get
            {
                return Ganar;
            }
            set
            {
                if (value == 100)
                {
                    Ganar = value;

                }
                else
                {
                    throw new Exception("");
                }
                   
            }
        }

        public void Moverse()
        {

        }

        public void Disparar()
        {

        }

        public void Explotar()
        {

        }


    }
}
