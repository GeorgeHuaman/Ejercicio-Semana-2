using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_semana_2
{
    class Square : Shape, ICalculateArea
    {
        private float sideSquare;

        public Square(string name,float sideSquare) : base ("Cuadrado", name)
        {
            this.sideSquare = sideSquare;
        }

        public float CalculateArea()
        {
            return sideSquare * sideSquare;
        }
    }
}
