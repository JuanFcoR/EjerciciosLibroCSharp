using System;

namespace Cap4_Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese numero");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la potencia a elevar");
            int potencia =Convert.ToInt32(Console.ReadLine());
            int res = num;
            for (int i = 0; i < potencia-1; i++)
            {
                res *= num;
            }

            Console.WriteLine(res);
        }
    }
}
