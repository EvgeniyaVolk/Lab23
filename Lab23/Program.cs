using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23
{
    class Program
    {
        static void Factorial()
        {
            Console.WriteLine("Метод рачсета факториала начал работу"); 
            int n = 10;
            int factorial = 1;
            for (int i=n; i>=1; i--)
            {
                factorial *= i;
            }
            Console.WriteLine("Факториал числа {0}= {1}", n, factorial);
            Console.WriteLine("Метод расчета факториала закончил работу");
        }
        static void Main(string[] args)
        {
            FactorialAsync();
            Console.WriteLine("Метод Main закончил работу");
            Console.ReadKey();
        }
        static async void FactorialAsync()
        {
            Console.WriteLine("Метод FactorialAsync начал работу");
            await Task.Run(()=>Factorial());
            Console.WriteLine("Метод FactorialAsync закончил работу");
        }
    }
}
