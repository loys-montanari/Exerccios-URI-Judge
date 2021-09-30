using System; 

class produto {

    static void Main(string[] args) { 

                    
                    string nome;
                    double salario, vendas, total;
                    
                    nome = Console.ReadLine();
                    salario = Convert.ToDouble(Console.ReadLine());
                    vendas = Convert.ToDouble(Console.ReadLine());
                    
                    total = salario + vendas*0.15;
                    


                    Console.WriteLine("TOTAL = {0}",total);
    }

}