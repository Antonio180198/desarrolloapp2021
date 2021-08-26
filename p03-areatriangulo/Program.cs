//Calcular el are de un triangulo

using System;

namespace p03_areatriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            float b,h,a;
            b=h=a=0;
            Console.WriteLine("calculando el area de un triangulo\n");
            Console.Write("Dame la base ");
            b=float.Parse(Console.ReadLine());
            Console.Write("Dame la altura ");
            h=float.Parse(Console.ReadLine());
            a=(b*h)/2;
            Console.WriteLine($"El area del triangulo es {a}");
        }
    }
}
