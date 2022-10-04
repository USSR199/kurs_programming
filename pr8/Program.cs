// See https://aka.ms/new-console-template for more information
/*using System;
using System.Collections.Generic;
using System.Linq;
 
class Program
{
    static void Main(string[] args)
    */
        Console.Write("Введите количество чисел: ");
        int n = int.Parse(Console.ReadLine());
       
               for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");
            }
        }
        Console.ReadKey();
    

