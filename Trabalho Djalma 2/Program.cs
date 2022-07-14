using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Djalma_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double trabalho, prova1, prova2, media;
            int sair;

            do
            {
                Console.WriteLine("-----Universidade Unifaat-----");
                Console.Write("");
                Console.Write("Informe o nome do aluno: ");
                nome = Console.ReadLine();
                Console.Write("Informe a nota do trabalho: ");
                trabalho = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe a nota da primeira prova: ");
                prova1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe a nota da segunda prova: ");
                prova2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                media = (trabalho + prova1 + prova2) / 3;

                if (media >= 8.5)
                {
                    Console.WriteLine($"O aluno {nome} obteve conceito A");
                }
                else if (media >= 7)
                {
                    Console.WriteLine($"O aluno {nome} ficou com conceito B");
                }
                else if (media >= 6)
                {
                    Console.WriteLine($"O aluno {nome} ficou com conceito C");
                }
                else if (media >= 0.1)
                {
                    Console.WriteLine($"O aluno {nome} ficou com conceito D");
                }
                else
                {
                    Console.WriteLine($"O aluno {nome} ficou com conceito E");
                }


                Console.WriteLine("Digite 1 para CONTINUAR e 2 para SAIR");
                sair = Convert.ToInt32(Console.ReadLine());
            } while (sair != 2);
           

        }
    }

}
    

