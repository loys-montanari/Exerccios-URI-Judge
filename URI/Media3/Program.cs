using System;
using System.Globalization;

namespace media3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[]   notas = Console.ReadLine().Split(null);
            float n1 = float.Parse(notas[0], CultureInfo.InvariantCulture);
            float n2 = float.Parse(notas[1], CultureInfo.InvariantCulture);
            float n3 = float.Parse(notas[2], CultureInfo.InvariantCulture);
            float n4 = float.Parse(notas[3], CultureInfo.InvariantCulture);

            float media = ((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1)) / 10;

            if (media >= 7) 
            {
                      
                Console.WriteLine("Media: " + Math.Round(media, 1).ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5)
            {
                Console.WriteLine("Media: " + Math.Round(media, 1).ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno reprovado.");
            }
            else if (media >= 5 && media <= 6.9)
             {
                   
                      float exame = float.Parse(Console.ReadLine());
                      Console.WriteLine("Media: " + Math.Round(media, 1).ToString("F1", CultureInfo.InvariantCulture));                      
                      Console.WriteLine("Aluno em exame.");
                      Console.WriteLine("Nota do exame: " + Math.Round(exame, 1).ToString("F1", CultureInfo.InvariantCulture));
                      float novamedia =  (media+exame)/2;


                      if (novamedia >= 5 )
                      {

                          Console.WriteLine("Aluno aprovado.");
                      }
                      else 
                      {

                          Console.WriteLine("Aluno reprovado.");
                      }

                Console.WriteLine("Media final: " + Math.Round(novamedia, 1).ToString("F1", CultureInfo.InvariantCulture));
            }
                 
            
        }
    }
}
