using System;

namespace Cap3_Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero y le dire su dia: ");
            int num= Convert.ToInt16(Console.ReadLine());
            string dia="Ninguno";

            switch(num)
            {
                case 1:
                    dia = "Lunes";
                    break;
                case 2:
                    dia = "Martes";
                    break;
                case 3:
                    dia = "Miercoles";
                    break;
                case 4:
                    dia = "Jueves";
                    break;
                case 5:
                    dia = "Viernes";
                    break;
                case 6:
                    dia = "Sabado";
                    break;
                case 7:
                    dia = "Domingo";
                    break;
                default:
                    Console.WriteLine("Dia invalido");
                    Console.Read();
                    break;
            }

            Console.WriteLine(dia);


        }
    }
}
