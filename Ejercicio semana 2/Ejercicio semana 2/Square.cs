using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_semana_2
{
    class Square : Shape
    {
        private float side;

        public Square (float side)
        {
            this.name = "Square";
        }

        public override float CalculateArea()
        {
            return side * side;
        }
    }
}
