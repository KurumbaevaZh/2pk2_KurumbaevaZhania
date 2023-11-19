namespace PZ_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            // Разделение строки на слова по пробелам
            string[] words = text.Split(' ');
            int count = 0;
            foreach (string word in words)
            {
                // Приведение слова к нижнему регистру и проверка первой буквы
                if (word.ToLower().StartsWith("с"))
                {
                    count++;
                }
            }
            // Вывод результата
            Console.WriteLine("Количество слов на букву 'C': " + count);

        }
    }
}