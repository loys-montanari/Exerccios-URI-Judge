using System; 

class Imposto {

    static void Main(string[] args) { 
                    
                   double salario;

                    salario = double.Parse(Console.ReadLine());

            if (salario <= 2000)
            {
                Console.WriteLine("Isento");
            }
            else if (salario > 2000 && salario <= 3000)
            {    
                Console.WriteLine("R$ {0:0.00}", (salario - 2000) * 0.08);
            }
            else if(salario > 3000 && salario <= 4500) 
            {
                Console.WriteLine("R$ {0:0.00}", (1000 * 0.08) + ((salario - 3000) * 0.18));
            }
            else if (salario > 4500)
            {
                Console.WriteLine("R$ {0:0.00}", (1000 * 0.08) + (1500 * 0.18) + ((salario - 4500) * 0.28));
            }           

                      
    }

}