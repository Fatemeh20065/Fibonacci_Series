using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifth_question
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.Write("Enter a number (position in Fibonacci series): ");
              int n = int.Parse(Console.ReadLine());

              Console.WriteLine("Fibonacci series up to position {0}:",n);

              for (int i = 1; i <= n; i++)
              {
                  Console.Write(Fibonacci(i) + " ");
              }
              Console.ReadKey();
        }

        // متد بازگشتی برای محاسبه جمله‌ی nام فیبوناچی
        static int Fibonacci(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
