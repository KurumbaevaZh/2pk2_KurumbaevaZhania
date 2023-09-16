using System.ComponentModel.Design;

namespace PZ_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");//вводим данные
            double a = double.Parse(Console.ReadLine());//объявляем переменные
            Console.WriteLine("Введите действительное число");//вводим данные
            double k = double.Parse(Console.ReadLine());//объявляем переменные
            double x, y, t;//объявляем переменные 
            if (k > 0)//начало условия
            {
                x = Math.Sin(a + (Math.Sqrt(a + k) / 1.5));//действие, если выполняется условие
            }
            else
                x = Math.Cos(a * k) + 2.5 * a;//действие, если условие не выполняется
            if (x <= 1)//второе условие
            {
                y = k + 5 * Math.Cos(Math.Abs(a) * x) + x;//действие, если условие выполняется
            }
            else
                y = 2 * a * x * x - 3 * k * x;//дйствие,если условие не выполняется
            t = 1.3 * x * x + 1.7 * a * a - 3.1 * y * y;//вычисляем рузультат
            Console.WriteLine("Результат" + t);
        }
    }
}