using System; 

class valores {

    static void Main(string[] args) { 

                    
                    int A, B, C, D, CD, AB;
                                        
                    string[] x = Console.ReadLine().Split(null);

                    A = int.Parse(x[0]);
                    B = int.Parse(x[1]);
                    C = int.Parse(x[2]);
                    D = int.Parse(x[3]);
                    CD = C+D;
                    AB = A+B;
                     
                   if ((B > C) && (D > A) && (CD > AB) && (C > 0) && (D > 0)  && (A % 2 == 0))  {
                        Console.WriteLine("Valores aceitos");
                   }

                   else {
                        Console.WriteLine("Valores nao aceitos");
                   }
                    
    }

}