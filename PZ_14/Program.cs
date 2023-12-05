using System.Text.RegularExpressions;

namespace PZ_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь к файлу: ");
            string filePath=Console.ReadLine();
            string text = File.ReadAllText(filePath);
            string normalizedText = NormalizeText(text);
            Console.WriteLine(NormalizeText);
        }
        static string NormalizeText(string text)
        {
            text = Regex.Replace(text, @"s+", " ");
            text = Regex.Replace(text, @"(?<=[.!?])s*bw", m => m.Value.ToUpper()); 
            return text;
        }
    }
}