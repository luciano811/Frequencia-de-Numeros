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

            string [] strNumeros = Console.ReadLine().Split(' ');
            int [] numeros = new int[qtd];
                        

            for (int i = 0; i < strNumeros.Length; i++) 
            {
                numeros[i] = Convert.ToInt32(strNumeros[i]);
                Console.WriteLine(numeros[i]);
            }

            Array.Sort(numeros);

            Console.WriteLine("\n\nOrganizando por ordem crescente\n");


                                                       
            
            for (int i = 0;i <= qtd; i = i++)
            {

                if (numeros[i] == numeros[i++])
                {
                    x++;
                    
                }
                


                Console.WriteLine($"O número {numeros[i]} aparece {x} vezes ");
                x = 1;
            }
            
            
            
            
            
            
            
            
            
            //int z = 5;
            
            //int[] numeros = new int[z];
            //Random rm = new Random();

            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    numeros[i] = rm.Next(1, 25);
            //    Console.WriteLine(numeros[i]);
            //}

            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    if (numeros[i] < numeros[i++])
            //    {
            //        Console.WriteLine(numeros[i]);
            //    }
            //}











            ////maior e menor altura
            //double[] alturas = new double[15];

            //double maiorAltura = alturas[0];
            //double menorAltura = 1;

            //int i = 0;
            //do
            //{
            //    Console.Write("Qual a altura? ");
            //    string strAltura = Console.ReadLine();
            //    alturas[i] = Convert.ToDouble(strAltura);

            //    if (alturas[i] <= menorAltura)
            //        menorAltura = alturas[i];

            //    if (alturas[i] > maiorAltura)
            //        maiorAltura = alturas[i];

            //    i++;
            //} while (i < 15);

            //Console.WriteLine("A maior altura é: " + maiorAltura);
            //Console.WriteLine("A menor altura é: " + menorAltura);

        }
    }
}
