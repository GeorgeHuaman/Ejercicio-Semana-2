using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_semana_2
{
    class Rectangle : Shape, ICalculateArea
    {
        private float b;
        private float h;

        public Rectangle(string name,float b, float h) : base("Rectangulo", name)
        {
            this.b = b;
            this.h = h;
        }

        public float CalculateArea()
        {
            return b * h;
        }
    }
}
