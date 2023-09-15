using System.ComponentModel.Design;

namespace PZ_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите действительное число");
            double k = double.Parse(Console.ReadLine());
            double x, y, t;
            if (k > 0)
            {
                x = Math.Sin(a + (Math.Sqrt(a + k) / 1.5));
            }
            else
                x = Math.Cos(a * k) + 2.5 * a;
            if (x <= 1) 
            {
                y = k + 5 * Math.Cos(Math.Abs(a) * x) + x;
            }
            else
                y = 2 * a * x * x - 3 * k * x;
            t = 1.3 * x * x + 1.7 * a * a - 3.1 * y * y;
            Console.WriteLine("Результат" + t);
        }
    }
}