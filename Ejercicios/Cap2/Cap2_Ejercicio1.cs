using System;

namespace Cap2_Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de lados: ");
            int lado=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la longitud del lado");
            double longitud = Convert.ToDouble(Console.ReadLine());

            double perimetro = lado * longitud;

            Console.WriteLine("El perimetro del poligono regular es: "+perimetro);
        }
    }
}
