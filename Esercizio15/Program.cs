using System;

namespace Esercizio15
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = 0;
            double perimetro = 0;
            Console.WriteLine("inserisci i due lati");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("E' un quadrato");
                perimetro = a * 4;
                area = a * a;
                Console.WriteLine($"Il perimetro è {perimetro} e l'area è {area}");
            }
            else Console.WriteLine("E' un rettangolo");
            perimetro = (a + b)*2;
            area = a * b;
            Console.WriteLine($"Il perimetro è {perimetro} e l'area è {area}");

            Console.ReadLine();

        }
    }
}
