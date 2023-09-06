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
            Shape square = null;
            Shape circle = null;
            Shape rectangle = null;
            Shape triangle = null;
            string option;

            Console.WriteLine("Seleccione una figura para calcular su área:");
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Círculo");
            Console.WriteLine("3. Rectángulo");
            Console.WriteLine("4. Triángulo");
            Console.WriteLine("5. Salir");

            option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    float side;
                    Console.WriteLine("Introducir el lado del cuadrado: ");
                    side = float.Parse(Console.ReadLine());
                    square = new Square(side);
                    break;
                case "2":
                    float radius;
                    Console.WriteLine("Introducir el radio del circulo: ");
                    radius = float.Parse(Console.ReadLine());
                    circle = new Circle(radius);
                    break;
                case "3":
                    float b;
                    Console.WriteLine("Introducir la base del rectangulo: ");
                    b = float.Parse(Console.ReadLine());
                    float h;
                    Console.WriteLine("Introducir la altura del rectangulo: ");
                    h = float.Parse(Console.ReadLine());
                    rectangle = new Rectangle(h,b);
                    break;
                case "4":
                    float b2;
                    Console.WriteLine("Introducir la base del triangulo: ");
                    b2 = float.Parse(Console.ReadLine());
                    float h2;
                    Console.WriteLine("Introducir la altura del triangulo: ");
                    h2 = float.Parse(Console.ReadLine());
                    triangle = new Triangle(h2, b2);
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;

            }

            if (square != null)
            {
                Console.WriteLine($"El área es {square.CalculateArea()}");
            }
            if (circle != null)
            {
                Console.WriteLine($"El área es {circle.CalculateArea()}");
            }
            if (rectangle != null)
            {
                Console.WriteLine($"El área es {rectangle.CalculateArea()}");
            }
            if (triangle != null)
            {
                Console.WriteLine($"El área es {triangle.CalculateArea()}");
            }

            Console.ReadLine();

        }
    }
}
