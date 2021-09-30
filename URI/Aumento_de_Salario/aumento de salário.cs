using System; 

class AUMENTO {

    static void Main(string[] args) { 

                    double salario, novosalario, reajuste, percent;

                    salario = double.Parse(Console.ReadLine());

                             if (salario <= 400)
            {
                percent = 0.15;
            }
            else if (salario > 400 && salario <= 800)
            {
                percent = 0.12;
            }
            else if(salario > 800 && salario <= 1200) 
            {
                percent = 0.10;
            }
            else if(salario > 1200 && salario <= 2000)
            {
                percent = 0.07;
            }
            else
            {
                percent = 0.04;
            }
                    
                    novosalario = salario*(percent + 1);
                    reajuste = novosalario - salario;

                    Console.WriteLine("Novo salario: {0:0.00}", novosalario);
                    Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                    Console.WriteLine("Em percentual: {0} %", Math.Round(percent*100));
                      
    }

}