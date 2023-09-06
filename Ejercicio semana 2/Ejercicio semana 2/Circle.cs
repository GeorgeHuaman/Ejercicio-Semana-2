using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_semana_2
{
    class Circle : Shape
    {
        private float radius;

        public Circle (float radius)
        {
            this.radius = radius;
        }

        public override float CalculateArea()
        {
            return radius * radius * 3.14f;
        }
    }
}
