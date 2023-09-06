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
            //Shape s = new Circle(10);

            //Console.WriteLine($"El área del {s.GetName()} es : {s.CalculateArea()}");
            //Console.ReadLine();

            bool continuar = true;
            Shape square = new Square(10);
            Shape circle = new Circle(10);
            Shape rectangle = new Rectangle(10, 5);
            Shape triangle = new Triangle(7, 3);

            while (continuar)
            {
                Console.WriteLine("Seleccione una figura para calcular su área:");
                Console.WriteLine("1. Cuadrado");
                Console.WriteLine("2. Círculo");
                Console.WriteLine("3. Rectángulo");
                Console.WriteLine("4. Triángulo");
                Console.WriteLine("5. Salir");

                int opcion;
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine($"El área del {square.GetName()} es { square.CalculateArea()}");
                            break;
                        case 2:
                            Console.WriteLine($"El área del {circle.GetName()} es { circle.CalculateArea()}");
                            break;
                        case 3:
                            Console.WriteLine($"El área del {rectangle.GetName()} es { rectangle.CalculateArea()}");
                            break;
                        case 4:
                            Console.WriteLine($"El área del {triangle.GetName()} es { triangle.CalculateArea()}");
                            break;
                        case 5:
                            continuar = false;
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Intente de nuevo.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Intente de nuevo.");
                }
            }
        }
    }
}
