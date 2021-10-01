
using System.Reflection;
using System.Reflection.Emit;
using System.Data;

using System.Runtime.Intrinsics.X86;
using System;

namespace simulado
{
    class Aeronave
    {   
        public string nome;
        public int maxabastecimento;
        public float combustivelatual;
        public float consumomedio;
        public int maxpassageiros;
        public float autonomia;
        public float horasdevoo;
      
        public string FichaAeronave(){
                string ficha = string.Format("Modelo:                        {0}\n"+
                                             "Capacidade de Abastecimento:   {1:#,0.00} lts\n"+
                                             "Nível Tanque:                  {2:0.00%}\n"+
                                             "Consumo Médio:                 {3} km/l\n"+
                                             "Capacidade máxima passageiros: {4}\n"+
                                             "Autonomia:                     {5:#,0.00} km\n"+
                                             "Horas totais de voo:           {6:#,0} hrs\n"+
                                             "______________________________________\n"+
                                             "\n",  
                                             nome, maxabastecimento, combustivelatual, consumomedio, maxpassageiros, autonomia, horasdevoo);
                return ficha;
        }            
        public Aeronave(){
                nome = "";
                maxabastecimento = 0;
                maxpassageiros = 0;
                consumomedio = 0f;
                horasdevoo = 0f;
                combustivelatual =0f;
        } 

        public Aeronave(string n, int abs,  int psgr ,  float cmedio, float hrsvoo, float tanque){
                nome = n;
                maxabastecimento = abs;
                maxpassageiros = psgr;
                consumomedio = cmedio;
                horasdevoo = hrsvoo;
                combustivelatual =tanque;
                
        }

        public string getNome(){
            return nome;
        }

        public int getPsgr(){
            return maxpassageiros;
        }
        public void setNome(string n){
               nome = n;
        }    
        public void setPsgr(int p){
            maxpassageiros = p;
        }        

        public void setAutonomia(){
            autonomia = maxabastecimento*combustivelatual*consumomedio;
        }                         
        

        public void TransferirCombustivel(Aeronave d){
                  if (d.combustivelatual == 0 && d.maxabastecimento >= autonomia/consumomedio) {
                      d.combustivelatual =  autonomia/consumomedio/d.maxabastecimento;
                      combustivelatual = 0;
                      autonomia = 0;                     
                      d.setAutonomia();
                      Console.WriteLine("Combustível transferido de {0} para {1} com sucesso!\n", nome, d.nome);
                      }
                  else if (d.combustivelatual != 0)
                  {
                      Console.WriteLine("A Aeronave {0} não está com o tanque vazio.");
                      
                  }    
                  else {
                      Console.WriteLine("A Aeronave {0} não suporta essa quantidade de combustível!");
                  }         
        }

        public void Voar(int h){
                   if (h <= autonomia){
                     combustivelatual = combustivelatual - (h/consumomedio/maxabastecimento);  
                     setAutonomia(); 
                     horasdevoo = horasdevoo + h;
                     Console.WriteLine("Horas de voo atualizadas: {0} hrs!\n", horasdevoo);
                   }
        }
    }    

    class MeuPrograma{

      public static void Main(){
        Aeronave B747 = new Aeronave(){
                nome = "Boeing 747-8",
                maxabastecimento = 1000,
                maxpassageiros = 480,
                consumomedio = 5,
                horasdevoo = 200,
                combustivelatual =0.8f,
        } ;
        Aeronave A380 = new Aeronave(){
                nome = "Airbus A380",
                maxabastecimento = 1500,
                maxpassageiros = 600,
                consumomedio = 3,
                horasdevoo = 300,
                combustivelatual = 0f,             
        };

      
        B747.setAutonomia();
        A380.setAutonomia();
        Console.WriteLine(B747.FichaAeronave());
        Console.WriteLine(A380.FichaAeronave());
        
        B747.TransferirCombustivel(A380);
        Console.WriteLine("Fichas Atualizadas!\n");        
        Console.WriteLine(B747.FichaAeronave());
        Console.WriteLine(A380.FichaAeronave());        
        
        A380.Voar(20);
        Console.WriteLine(A380.FichaAeronave()); 
        
      

      }
    }
}
