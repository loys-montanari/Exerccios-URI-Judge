using System; 

class SALARY {

    static void Main(string[] args) { 

                    int cod, horas;
                    double valor, salario;

                    cod = Convert.ToInt32(Console.ReadLine());
                    horas = Convert.ToInt32(Console.ReadLine());
                    valor = Convert.ToDouble(Console.ReadLine());
                    
                    salario = horas*valor;


                    Console.WriteLine("NUMBER = {0}",cod);
                    Console.WriteLine("SALARY = U$ {0:0.00}",salario);
    }

}