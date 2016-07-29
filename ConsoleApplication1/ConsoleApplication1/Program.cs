using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            int resultado;
            int x = 1;
            int quantasvezes = 0;
            int a = 0;
            Console.WriteLine("Insira qual numero sera tirada a raiz: ");
            try
            {
                a = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Deu erro");
                Console.ReadKey();
                Environment.Exit(0);
            }
            resultado = a;
            // Console.ReadLine();
            if (a > 0)
            {
                resultado -= x;
                quantasvezes++;
               while (resultado > 0)
               {
                    x = x + 2; // 3
                   // Console.WriteLine("o X é " + x);
                    // a=- x + 2; 
                    resultado -= x;
                    quantasvezes++;
               }
               if (resultado != 0) Console.WriteLine("A raiz não é um número inteiro");
               else Console.WriteLine("A raiz do "+a+" é "+ quantasvezes);
               Console.ReadLine();
            }
              if(a == 0)
              { Console.WriteLine("A raiz é 0"); Console.ReadLine(); }
              if(a < 0)
              { Console.WriteLine("Não possui raiz"); Console.ReadLine(); }
          }
        }
    }

