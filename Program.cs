using System;

namespace Exerc_cio_Media4Notas_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] Notas = new double[5];
            double soma = 0;
            double resposta;
            int c;
            
            Console.WriteLine("Media de Notas");
            Console.WriteLine("Digite Suas notas Abaixo");
            for( c = 1 ; c  < Notas.Length; c++){

            Console.Write($"Nota {c}:");

            Notas[c] = Convert.ToDouble(Console.ReadLine());

            soma+= Notas[c];

             if(Notas[c] < 0 || Notas[c] > 10 )
            {
            Console.WriteLine("\n Digite apenas asnotas entre 0  a 10");
            break;
            }
               
              
            }
           resposta = soma / 4;
           if (resposta >= 7){
               Console.WriteLine($"Você ficou com média {resposta}. Resultado: Aprovado");
           }
           else if (resposta  >= 5 & resposta <=6 ){
                Console.WriteLine($"Você ficou com média {resposta}. Resultado: Recuperação");
           }
           else if(resposta < 5){
                Console.WriteLine($"Você ficou com média {resposta}. Resultado: Reprovado");
           }
        }
    }
}
