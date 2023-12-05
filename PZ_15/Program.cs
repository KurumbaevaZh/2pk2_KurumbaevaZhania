namespace PZ_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите полный путь к каталогу:");
            string directoryPath = Console.ReadLine();
            string DirectoryPath1 = Path.Combine(directoryPath, "full");
            string DirectoryPath2 = Path.Combine(directoryPath, "empty");
            if (Directory.Exists(DirectoryPath1) && Directory.Exists(DirectoryPath2))
            {
                string[] files = Directory.GetFiles(DirectoryPath1);
                int fileCount = files.Length;
                int filesMoved = 0;
                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    string FilePath = Path.Combine(DirectoryPath2, fileName);
                    File.Copy(file, FilePath, true);
                    filesMoved++;
                    Console.WriteLine($"Файл {filesMoved} из перенесен.");
                }
                Console.WriteLine("Перенос файлов завершен.");
            }
            else
            {
                Console.WriteLine("Каталог 'full' или 'empty' не существует.");
            }
            Console.ReadKey();
        }
    }
}