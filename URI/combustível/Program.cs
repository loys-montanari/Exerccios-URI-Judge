using System;

namespace combustível
{
    class Program
    {
        static void Main(string[] args)
        {
	
          int num=0, alcool=0, gasolina=0, diesel=0;
		
	      while (num != 4){
	  	  num = int.Parse(Console.ReadLine());
		
        if (num ==1)
        {
			alcool= alcool +1;
		}else if (num == 2 )
        {
			gasolina = gasolina +1;
		}else if (num ==3)
        {
			diesel = diesel +1;
		}
	}
        
        Console.WriteLine("MUITO OBRIGADO\n"+
                          "Alcool: {0}\n"+
                          "Gasolina: {1}\n"+
                          "Diesel: {2}", alcool, gasolina, diesel);



        }
    }
}
