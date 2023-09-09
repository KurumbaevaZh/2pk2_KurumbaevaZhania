namespace PZ_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решение линейной задачи");
            //вводим данные
            double a = 1;
            double b = Math.PI / 4;
            double c = 1;
            //разделим выражение на 3 части
            double part1 = Math.Pow(Math.Abs(a * Math.Pow(c, 2) - Math.Pow(b, 3)), 1 / 5) + Math.Log(3 * c);
            double part2 = ((Math.Pow(Math.E, 3 * c)) + Math.Pow(c, 2)) / (Math.Sin(2 * c));
            double part3 = Math.Pow(10, -3) * Math.Sqrt(2157 * a);
            //подсчитываем результат 
            double result = part1 - part2 - part3;
            //выводим результат
            Console.WriteLine("Ответ: " + result);
        }
    }
}