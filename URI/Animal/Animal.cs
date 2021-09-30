using System; 

class Animal {

    static void Main(string[] args) { 

                    String categoria, classe, comem;

                    categoria = Console.ReadLine();
                    classe = Console.ReadLine();
                    comem = Console.ReadLine();


                     if (categoria == "vertebrado" && classe == "ave" && comem == "carnivoro")
                        {
                             Console.WriteLine("aguia");
                        }
                     else if (categoria == "vertebrado" && classe == "ave" && comem == "onivoro")   
                        {
                             Console.WriteLine("pomba");
                        }
                     else if (categoria == "vertebrado" && classe == "mamifero" && comem == "onivoro")   
                        {
                             Console.WriteLine("homem");
                        }
                     else if (categoria == "vertebrado" && classe == "mamifero" && comem == "herbivoro")   
                        {
                             Console.WriteLine("vaca");
                        }
                     else if (categoria == "invertebrado" && classe == "inseto" && comem == "hematofago")   
                        {
                             Console.WriteLine("pulga");
                        }                        
                     else if (categoria == "invertebrado" && classe == "inseto" && comem == "herbivoro")   
                        {
                             Console.WriteLine("lagarta");
                        }  
                     else if (categoria == "invertebrado" && classe == "anelideo" && comem == "hematofago")   
                        {
                             Console.WriteLine("sanguessuga");
                        }
                     else if (categoria == "invertebrado" && classe == "anelideo" && comem == "onivoro")   
                        {
                             Console.WriteLine("minhoca");
                        }

                      
    }

}