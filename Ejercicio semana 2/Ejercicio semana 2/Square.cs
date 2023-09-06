using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_semana_2
{
    class Square : Shape
    {
        private float sideSquare;

        public Square(float sideSquare)
        {
            this.sideSquare = sideSquare;
        }

        public override float CalculateArea()
        {
            return sideSquare * sideSquare;
        }
    }
}
