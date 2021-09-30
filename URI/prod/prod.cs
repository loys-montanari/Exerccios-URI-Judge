using System; 

class produto {

    static void Main(string[] args) { 

                    int n1, n2, resultado;

                    n1 = Convert.ToInt32(Console.ReadLine());
                    n2 = Convert.ToInt32(Console.ReadLine());
                    
                    resultado = n1*n2;


                    Console.WriteLine("PROD = {0}",resultado);
    }

}