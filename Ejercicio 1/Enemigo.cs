using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1
{
    class Enemigo
    {

        public int X { get; set; }
        public int Y { get; set; }

        private int _valorPuntos;
       
        public int ValorPuntos
        {
           get
            {
                return _valorPuntos;
            }
            set
            {
                if (value >= 100)
                {
                    _valorPuntos = value;

                }
                else
                {
                    throw new Exception("El valor tiene que ser mayor a 100");
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
