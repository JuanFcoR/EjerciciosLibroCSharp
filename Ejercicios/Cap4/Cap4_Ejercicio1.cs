using System;

namespace Cap4_Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabal de multiplicar ingrese el numero");
            int num = Convert.ToUInt16(Console.ReadLine());
            int res = 0;
            for(int i =0; i<=10;i++)
            {
                res = i * num;
                Console.WriteLine($"{num} X {i} = {res}");
            }
        }
    }
}
