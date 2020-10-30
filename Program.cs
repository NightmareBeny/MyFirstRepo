using System;
using static System.Console;

namespace FirstRepo
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите числа\nx=");
            int x = Convert.ToInt32(ReadLine());
            Write("y=");
            int y = Convert.ToInt32(ReadLine());
            Func<int, int, int> func=Mult;
            func += Sum;
            WriteLine($"Сумма равна: {func(x, y)}");
            func -= Sum;
            WriteLine($"Произведение равно: {func(x, y)}");
            Write("\nВведите число\nn="); x = Convert.ToInt32(ReadLine());
            Action<int> action = F1; action(x);
        }
        static void F1(int n)
        {
            Write(n + ' ');
            if (n > 3)
            {
                F1(n - 1); F1(n / 2);
            }
        }
        static int Sum(int x, int y)
        {
            return x + y;
        }
        static int Mult(int x, int y)
        {
            return x * y;
        }
    }
}
