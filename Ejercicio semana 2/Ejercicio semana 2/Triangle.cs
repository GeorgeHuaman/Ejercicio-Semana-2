using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_semana_2
{
    class Triangle : Shape,ICalculateArea
    {
        private float b;
        private float h;

        public Triangle(string name,float b, float h) : base("Triangulo", name)
        {
            this.b = b;
            this.h = h;
        }

        public float CalculateArea()
        {
            return (b * h) / 2;
        }
    }
}
