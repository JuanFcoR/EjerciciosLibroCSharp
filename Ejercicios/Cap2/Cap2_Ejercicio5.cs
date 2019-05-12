using System;

namespace Cap2_Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese cantidad de dolares:");
            int dolares = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese cambio del dia del dolar a euro:");
            double cambioDiaDolar = Convert.ToDouble(Console.ReadLine());
            double euroC = cambioDiaDolar * dolares;
            Console.WriteLine("Es un total de :"+euroC+" Euros");
            Console.WriteLine("Ingrese cantidad de Euros:");
            int euros = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese cambio del dia del euro a dolar :");
            double cambioDiaEuro = Convert.ToDouble(Console.ReadLine());
            double dolarC = cambioDiaEuro * euros;
            Console.WriteLine("Es un total de :" + dolarC + " Dolares");




        }
    }
}
