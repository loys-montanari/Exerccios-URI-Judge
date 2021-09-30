using System; 

class URI {

    static void Main(string[] args) { 
          
            double Raio, pi, volume;
            
            Raio = double.Parse(Console.ReadLine());
            
            pi = 3.14159;
            volume = (4.00/3)*pi*Math.Pow(Raio,3);

            Console.WriteLine("VOLUME = {0:0.000}", volume);

    }

}