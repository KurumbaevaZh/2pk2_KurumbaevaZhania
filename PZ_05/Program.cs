namespace PZ_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N: ");
            int N = int.Parse(Console.ReadLine());
            double doubleFactorial = 1;
            if (N % 2 == 0)
            {
                int n = N;
                do
                {
                    doubleFactorial *= n;
                    n -= 2;
                } while (n >= 2);
            }
            else
            {
                int n = N;
                do
                {
                    doubleFactorial *= n;
                    n -= 2;
                } while (n >= 1);
            }
            Console.WriteLine("Двойной факториал числа N: " + doubleFactorial);
        }
    }
}