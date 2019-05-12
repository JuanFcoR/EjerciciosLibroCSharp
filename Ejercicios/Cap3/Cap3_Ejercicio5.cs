using System;

namespace Cap3_Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que desea calcular: \n 1-Area \n 2-Perimetro:");
            int opcion = Convert.ToInt16(Console.ReadLine());
            double area, perimetro, valor, ap;
            int lados;

            if (opcion > 0 && opcion < 3)
            {
                if (opcion == 1)
                {
                    Console.WriteLine("Ingrese la cantidad de lados: ");
                    lados = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor de cada lado: ");
                    valor = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor de la apotema: ");
                    ap = Convert.ToDouble(Console.ReadLine());
                    area = (lados * valor * ap) / 2;
                    Console.WriteLine(area);

                }
                else
                {
                    Console.WriteLine("Ingrese la cantidad de lados: ");
                    lados = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor de cada lado: ");
                    valor = Convert.ToDouble(Console.ReadLine());
                    perimetro = (lados * valor);
                    Console.WriteLine(perimetro);

                }
            }
            else
                Console.WriteLine("Esta opcion no existe");
        }
    }
}
