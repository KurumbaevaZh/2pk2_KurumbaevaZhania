namespace PZ_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива:"); //ввод размера массива
            int N = int.Parse(Console.ReadLine());
            int[] n = new int[N]; //создание массива
            Console.WriteLine("Введите элементы массива:"); //ввод элементов массива
            for (int i = 0; i< N; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                n[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Четные числа в порядке убывания:"); //поиск четных чисел в порядке убывания
            int num = 0;
            for (int i = N - 1; i >= 0; i--)
            {
                if (n[i] % 2 == 0)
                {
                    Console.WriteLine(n[i]);
                    num++;
                }
            }
            Console.WriteLine($"Количество четных чисел: {num}"); //вывод количества четных чисел
            Console.ReadLine();
        }
    }
}