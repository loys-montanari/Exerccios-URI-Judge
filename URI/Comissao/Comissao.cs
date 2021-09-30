using System; 

class COMISSAO {

    static void Main(string[] args) { 

                    
                    string nome;
                    double salario, vendas, total;
                    
                    nome = Console.ReadLine();
                    salario = Convert.ToDouble(Console.ReadLine());
                    vendas = Convert.ToDouble(Console.ReadLine());
                    
                    total = Math.Round(salario + (vendas*0.15),2);
                    


                    Console.WriteLine("TOTAL = {0:0.00}",total);
    }

}