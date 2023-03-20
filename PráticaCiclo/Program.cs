using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PráticaCiclo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1° - Exercício

            /*Faça sequência de Fibonacci*/

            //Console.WriteLine("***Sequência de Fibonnaci***");
            //Console.WriteLine("Digite a quantidade de sequência que deseja ver: ");
            //int n = int.Parse(Console.ReadLine());

            //int x = 0, y = 1, total;

            //for (int i = 0; i < n; i++)
            //{
            //    total = x + y;
            //    Console.WriteLine("O numero é " + total);
            //    y = x;
            //    x = total;

            //}

            //Console.ReadKey();

            #endregion

            #region 2° - Exercício

            /*Faça um programa que exiba os números de 1 a 10 usando um loop for.*/

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.ReadKey();

            #endregion

            #region 3° - Exercício

            /*Faça um programa que exiba os números pares de 1 a 20 usando
             um loop while.*/

            //int num = 1;

            //while (num <= 20)
            //{
            //    if(num % 2 == 0)
            //        {
            //            Console.WriteLine("N°: " + num);
            //        }
            //    num++;
            //}

            //Console.ReadKey();

            #endregion

            #region 4° - Exercício

            /*Faça um programa que leia a lista de números inteiros e exiba o maior
             valor lido.*/

            //int maior = 0;

            //Console.WriteLine("Digite o tamanho da lista que deseja: ");
            //int n = int.Parse(Console.ReadLine());

            //for(int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Digite um número: ");
            //    int numero = int.Parse(Console.ReadLine());

            //    if (numero > maior)
            //    {
            //        maior = numero;
            //    }

            //}

            //Console.WriteLine("\nO maior número registrado dessa lista foi: " + maior);
            //Console.ReadKey();

            #endregion

            #region 5° - Exercício

            /*Faça um programa que leia uma lista de números iteiros e exiba a media dos valores 
             lidos*/

            //int media = 0;

            //Console.WriteLine("Digite a quantidade total da sequência: ");
            //int u = int.Parse(Console.ReadLine());
            //Console.Clear();

            //for(int i = 0; i <= u; i++)
            //{
            //    Console.WriteLine("Digite um número: ");
            //    i = int.Parse(Console.ReadLine());
            //    media = media + i;
            //}
            //Console.WriteLine("Média dos números lidos: " + media/u);
            //Console.ReadKey();

            #endregion

            #region 6° - Exercício

            /*Faça um programa que imprima a tela apenas os números ímpares entre 1 a 50*/

            //Console.WriteLine("SEQUÊNCIA DE NÚMEROS ÍMPARES");


            //for (int num = 1; num < 50; num++)
            //{
            //    if (num % 2 != 0)
            //    {
            //        Console.WriteLine(num);
            //    }

            //}

            //Console.ReadKey();

            #endregion

            #region 7° - Exercício 

            /*Faça um programa que solicite ao usuário um número e imprima
             na tela a tabuada desse número de 1 a 10.*/

            //Console.WriteLine("Digite um número para realizarmos a tabuada de 1 a 10 do mesmo: ");
            //int num = int.Parse(Console.ReadLine());
            //Console.Clear();

            //Console.WriteLine("Tabuada do " + num);

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(num + " x "+ i + " = " + num*i);
            //}
            //Console.ReadKey();

            #endregion

            #region 8° - Exercício

            /*Faça um programa que solicite ao usuário um número e imprima na tela a
             soma de todos os números ímpares e esse número.*/

            //int media = 0;

            //Console.WriteLine("Digite um número: ");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= num; i++)
            //{
            //    if(i % 2 != 0)
            //    {
            //        Console.WriteLine(media + " + " + i + " = " + (media = media + i));
            //        //media = media + i;
            //    }
            //}

            //Console.WriteLine("A soma de todos os números ímpares com o seu número " + media);
            //Console.ReadKey();

            #endregion

        }
    }
}
