using System;

namespace Frequencia_de_Numeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;

            Console.WriteLine("Digite a qtd de numeros");

            int qtd = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite os numeros separados por espaço");

            string[] strNumeros = Console.ReadLine().Split(' ');
            int[] numeros = new int[qtd];


            for (int i = 0; i < strNumeros.Length; i++)
            {
                numeros[i] = Convert.ToInt32(strNumeros[i]);
                Console.WriteLine(numeros[i]);
            }



            Console.WriteLine("\n\nOrganizando por ordem crescente\n");
            Array.Sort(numeros);

            for (int i = 0; i < numeros.Length; i++)
                Console.WriteLine(numeros[i]);

            Console.WriteLine();


            for (int i = 0; i < qtd; i++)
            {

                if (i != qtd - 1)
                    if (numeros[i] == numeros[i + 1])
                    {

                        x++;
                        continue;

                    }

                    else if (numeros[i] == numeros[qtd - 1])
                    {
                        Console.WriteLine($"O número {numeros[i]} aparece {x} vezes ");
                    }

                Console.WriteLine($"O número {numeros[i]} aparece com a frequência: {x}");
                x = 1;
            }
        }
    }
}