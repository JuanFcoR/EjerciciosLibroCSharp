using System;

namespace Cap4_Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cantidad de personas a preguntar la edad: ");
            int personas = Convert.ToInt16(Console.ReadLine());
            int mayor = 0,menor=200,promedio=0,sumpromedio=0,i;
            for(i=0;i<=personas; i++)
            {
                Console.Write("Edad: ");
                int edad = Convert.ToInt16(Console.ReadLine());
                if (edad > mayor)
                    mayor = edad;
                if (edad < menor)
                    menor = edad;
                sumpromedio += edad;
            }
            promedio = sumpromedio / i;

            Console.WriteLine($" Mayor {mayor}, Menor: {menor},Promedio: {promedio}");
            
        }
    }
}
