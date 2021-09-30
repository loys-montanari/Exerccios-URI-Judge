using System;

namespace relogio
{
    class Program
    {
        static void Main(string[] args)
        {
            string[]   angulos = {""};

            
            while (angulos[0] != null )
            {   
                angulos = Console.ReadLine().Split(null);
                
                if (int.Parse(angulos[0]) > 360 ||  int.Parse(angulos[0]) < 0 || int.Parse(angulos[1]) > 360 || int.Parse(angulos[1]) < 0 )
                {
                    break;
                }

                int hh = int.Parse(angulos[0]);
                int mm = int.Parse(angulos[1]);
                double hora = hh/30;
                double minutos = mm/6;
                Console.WriteLine("{0:00}:{1:00}", hora, minutos);  

                 
            }

        }
    }
}
