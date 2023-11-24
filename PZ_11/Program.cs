namespace PZ_11
{
    internal class Program
    {
            static void Factorial(int k, ref int sum)
            {
                int factorial = 1;
                for (int i = 1; i <= k; i++)                 
                {
                    factorial *= i; //вычисляем факториал k
                }
                sum += factorial; //добавляем факториал k к сумме 
            }
        static void Main(string[] args)
            {
            Console.WriteLine("Введите значение факториала ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
                for (int i = 1; i <= n; i++) 
                {
                    Factorial(i, ref sum);
                }
                Console.WriteLine($"Сумма факториалов от 1 до {n} равна:  {sum}"); 
            }
            
    }
}