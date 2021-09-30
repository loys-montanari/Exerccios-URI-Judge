using System;

namespace notas_e_moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            

          int valor = Convert.ToInt32(Console.ReadLine());

          int cem = Convert.ToInt32(valor/100);
          int cinquenta = Convert.ToInt32((valor%100)/50);
          int vinte = Convert.ToInt32((valor%100)%50/20);
          int dez = Convert.ToInt32(((valor%100)%50)%20/10);
          int cinco = Convert.ToInt32((((valor%100)%50)%20)%10/5);
          int dois = Convert.ToInt32(((((valor%100)%50)%20)%10)%5/2);
          int um = Convert.ToInt32((((((valor%100)%50)%20)%10)%5)%2);


Console.WriteLine("{7}\n"+
                            "{0} nota(s) de R$ 100,00\n"+
                            "{1} nota(s) de R$ 50,00\n"+
                            "{2} nota(s) de R$ 20,00\n"+
                            "{3} nota(s) de R$ 10,00\n"+
                            "{4} nota(s) de R$ 5,00\n"+
                            "{5} nota(s) de R$ 2,00\n"+
                            "{6} nota(s) de R$ 1,00",
                             cem, cinquenta, vinte, dez, cinco, dois, um, valor);
       

        }
    }
}
