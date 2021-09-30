using System;
using System.Globalization;

namespace area
{
    class Program
    {
        static void Main(string[] args)
        {
            string[]   medidas = Console.ReadLine().Split(null);
            double a = double.Parse(medidas[0], CultureInfo.InvariantCulture);
            double b = double.Parse(medidas[1], CultureInfo.InvariantCulture);
            double c = double.Parse(medidas[2], CultureInfo.InvariantCulture);

            double triangulo = a*c/2;
            double circulo = 3.14159*(c*c);
            double trapezio = (a+b)/2*c;
            double quadrado = b*b;
            double retangulo = a*b;


            Console.WriteLine("TRIANGULO: {0:0.000}\n"+
                              "CIRCULO: {1:0.000}\n"+
                              "TRAPEZIO: {2:0.000}\n"+
                              "QUADRADO: {3:0.000}\n"+
                              "RETANGULO: {4:0.000}", triangulo, circulo, trapezio, quadrado, retangulo);

        }
    }
}
