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


            string aluno; double p1, p2, trabalho;

            Console.Write("Por favor, insira seu nome e sobrenome: ");
            aluno = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Olá " + aluno );
            Console.WriteLine("Vamos vê como você se saiu, prepare-se ");
            Console.Write("\nPor favor, digite a nota da sua Primeira Prova: ");
            p1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Agora, digite a nota da sua Segunda Prova: ");
            p2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Por último, digite a nota que você tirou no Trabalho: ");
            trabalho = Convert.ToDouble(Console.ReadLine());

            if ((p1 < 0 || p1 > 10) || (p2 < 0 || p2 > 10) || (trabalho < 0 || trabalho > 10))
            {

                Console.WriteLine("Por favor, tome cuidado, digite uma nota válida. Não é permitido números menor que 0 ou maior que 10");
                Console.ReadKey();
            }

            else
            {
                double media = (p1 + p2 + trabalho) / 3;

                if (media >= 8.5)
                {

                    Console.WriteLine("Se prepare, chegou a hora...");
                    Console.WriteLine("Meus Parabéns " + aluno + "! Sua média foi de " + media + "\nConceito: A");
                    Console.ReadKey();

                }

                else if (media >= 7 && media < 8.5)
                {
                    Console.WriteLine("Se prepare, chegou a hora...");
                    Console.WriteLine("Parabéns " + aluno + "! Sua média foi de " + media + "\nConceito: B");
                    Console.ReadKey();

                }

                else if (media >= 6 && media < 7)
                {
                    Console.WriteLine("Se prepare, chegou a hora...");
                    Console.WriteLine(aluno + ", sabemos que você é capaz, se esforce só mais um pouco! Sua média foi " + media + "\nConceito: C");
                    Console.ReadKey();
                }

                else if (media >= 0.1 && media < 6)
                {
                    Console.WriteLine("Se prepare, chegou a hora...");
                    Console.WriteLine(aluno + ", te vemos na próxima prova... sua média foi de " + media + "\nConceito: D");
                    Console.ReadKey();
                }

                else if (media == 0)
                {
                    Console.WriteLine("Um instante, por favor...");
                    Console.WriteLine(aluno + ", infelizmente sentimos em te dizer que sua média foi " + media + "\nConceito: E");
                    Console.ReadKey();
                }

            }

        }
    }

}
    

