using System.Text.RegularExpressions;

namespace PZ_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь к файлу: ");
            string filePath=Console.ReadLine();
            string text = File.ReadAllText(filePath); //чтение текста из файла
            string normalizedText = NormalizeText(text); //нормализация текста
            Console.WriteLine(NormalizeText);
        }
        static string NormalizeText(string text)
        {
            text = Regex.Replace(text, @"s+", " "); //замена всех пробелов на один пробел
            text = Regex.Replace(text, @"(?<=[.!?])s*bw", m => m.Value.ToUpper()); //первая буква текста заглавная
            return text;
        }
    }
}