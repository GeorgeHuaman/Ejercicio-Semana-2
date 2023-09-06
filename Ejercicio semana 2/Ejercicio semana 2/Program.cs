using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_semana_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Circle(10);

            Console.WriteLine($"El área del {s.GetName()} es : {s.CalculateArea()}");
            Console.ReadLine();
        }
    }
}
