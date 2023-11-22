namespace PZ_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] sentences = text.Split('.'); // Разделяем текст на предложения
            Array.Sort(sentences, (s1, s2) => s2.Split(' ').Length.CompareTo(s1.Split(' ').Length)); // Сортитурум предложения по убыванию количества слов в них
            Console.WriteLine("Отсортированные предложения:"); // Вывод отсортированных предложений
            foreach (string sentence in sentences)
            {
                Console.WriteLine(sentence.Trim() + ".");
            }
            Console.ReadKey();
        }
    }
}