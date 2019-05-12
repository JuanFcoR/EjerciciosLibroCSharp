using System;

namespace Cap2_Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese cantidad de celcius: ");
            double celcius = Convert.ToDouble(Console.ReadLine());
            double farenheit = ((celcius + 32) * 9)/5;
            Console.WriteLine("Es un total de: "+farenheit+" Farenheit");
        }
    }
}
