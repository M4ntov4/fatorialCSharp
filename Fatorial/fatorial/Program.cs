using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            int expo = 1; 
            string resposta;
           
                do
	            {
                   
                    Console.WriteLine("Insira um valor Inteiro: ");
                    valor = int.Parse(Console.ReadLine());


                        if (valor < 0)// se o usuario inserir um valor negativo
                    {
                              Console.Write("Valor invalido");              
                    }    

                    else //caso for 0 o fatorial deve ser 1
                    {
                        if (valor == 0)
	                     {
                            Console.Write("Valor é 1");
	                     }

                         else //regra lógica
	                     {
                            for(int i = 1; i <= valor; i++)
                            {
                               expo *= i;   // "expo = expo * i" "expo" ira receber um novo valor a cada
                                            //incremento do "i" multiplicado pelo "expo"
                
                            }
	                        Console.Write("deu: " + expo + ", ");
                    
                         }
                        
                 
                      
                    }


                    Console.WriteLine("deseja começar: ");
                    resposta = Console.ReadLine();

	            } while (resposta == "s" || resposta == "sim" || resposta == "si" || resposta == "im" || resposta == "simm");
                

               

            
            Console.ReadKey();
            
        }
    }
}
