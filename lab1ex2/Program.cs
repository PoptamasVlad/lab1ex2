using System;

namespace lab1ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Scrieti un program care va calcula media aritmetica a trei numere citite de la
            tastatura*/

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int mediaAritmetica = (num1 + num2 + num3) / 3;
            Console.WriteLine(mediaAritmetica);
        }
    }
}
