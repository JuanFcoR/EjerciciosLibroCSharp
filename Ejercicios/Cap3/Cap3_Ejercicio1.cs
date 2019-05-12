using System;

namespace Cap3_Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el numero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine($"El numero {num} es par");
            else
                Console.WriteLine($"El numero {num} es impar");
        }
    }
}
