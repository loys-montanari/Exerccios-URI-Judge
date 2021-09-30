using System;

namespace notas_e_moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            

          double valor = Convert.ToDouble(Console.ReadLine());

          int cem = Convert.ToInt32(Math.Truncate(valor/100));
          int cinquenta = Convert.ToInt32(Math.Truncate((valor%100)/50));
          int vinte = Convert.ToInt32(Math.Truncate((valor%100)%50/20));
          int dez = Convert.ToInt32(Math.Truncate(((valor%100)%50)%20/10));
          int cinco = Convert.ToInt32(Math.Truncate((((valor%100)%50)%20)%10/5));
          int dois = Convert.ToInt32(Math.Truncate(((((valor%100)%50)%20)%10)%5/2));
          int um = Convert.ToInt32(Math.Truncate((((((valor%100)%50)%20)%10)%5)%2))*100;

          int moeda = Convert.ToInt32(((valor - Math.Truncate(valor))*100)+um);

          int cemc = moeda/100;
          int cinquentac = (moeda%100)/50;
          int vintecincoc = (moeda%100)%50/25;
          int dezc = ((moeda%100)%50)%25/10;
          int cincoc =(((moeda%100)%50)%25)%10/5;
          int umc = ((((moeda%100)%50)%25)%10)%5;

Console.WriteLine("NOTAS:\n"+
                            "{0} nota(s) de R$ 100.00\n"+
                            "{1} nota(s) de R$ 50.00\n"+
                            "{2} nota(s) de R$ 20.00\n"+
                            "{3} nota(s) de R$ 10.00\n"+
                            "{4} nota(s) de R$ 5.00\n"+
                            "{5} nota(s) de R$ 2.00",
                             cem, cinquenta, vinte, dez, cinco, dois);

Console.WriteLine("MOEDAS:\n"+
                            "{0} moeda(s) de R$ 1.00\n"+
                            "{1} moeda(s) de R$ 0.50\n"+
                            "{2} moeda(s) de R$ 0.25\n"+
                            "{3} moeda(s) de R$ 0.10\n"+
                            "{4} moeda(s) de R$ 0.05\n"+
                            "{5} moeda(s) de R$ 0.01",
                             cemc, cinquentac, vintecincoc, dezc, cincoc, umc);
        

        }
    }
}