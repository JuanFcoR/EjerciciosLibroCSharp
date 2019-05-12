using System;

namespace Cap2_Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los Grados: ");
            int grado =Convert.ToInt32(Console.ReadLine());
            double radian = (grado*Math.PI)/180;
            Console.WriteLine("Es un total de: "+radian+" radianes");
        }
    }
}
