using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_semana_2
{
    class Circle : Shape, ICalculateArea
    {
        private float radius;

        public Circle (string name, float radius) : base ("Circulo", name)
        {
            this.radius = radius;
        }

        public float CalculateArea()
        {
            return radius * radius * 3.14f;
        }
    }
}
