namespace PZ_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd=new Random();
            char[][] array = new char[10][];
            //генерация ступенчатого массива и заполнеие рандомными значениями
            for (int i =0; i<array.Length; i++)
            {
                int length = rnd.Next(3, 51);
                array[i]=new char[length];
                for (int j=0; j < array[i].Length; j++)
                {
                    array[i][j]=(char)rnd.Next(1,1001); //генерация случайного символа
                }
            }
            //вывод сгенированного массива
            Console.WriteLine("Исходный массив:");
            for (int i =0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.WriteLine(string.Join("", array[i]));
                }
            }
            char[] lastElements = new char[array.Length];
            //запись последних элементов каждой строки в новый одномерный массив
            for (int i =0; i< array.Length; i++)
            {
                lastElements[i] = array[i][array[i].Length-1];
            }
            //вывод нового массива с последними элементами 
            Console.WriteLine("\nМассив с последними элементами: ");
            Console.WriteLine(string.Join(" ", lastElements));
            int[] maxElements = new int[array.Length];
            //поиск маскимального элемента в каждой строке ступенчатого массива
            for (int i =0; i <array.Length; i++)
            {
                int maxElement = int.MinValue;
                for (int j=0; j < array[i].Length; j++)
                {
                    if (array[i][j] > maxElement)
                    {
                        maxElement = array[i][j];
                    }
                }
                maxElements[i] = maxElement;
            }
            //вывод массива с максимальными элементами
            Console.WriteLine("\nМассив с максимальными элементами:");
            Console.WriteLine(string.Join("", maxElements));
            //обмен первого элемента и максимального в каждой строке
            for (int i=0; i<array.Length; i++)
            {
                char temp = array[i][0];
                array[i][0] = (char)maxElements[i];
                maxElements[i] = temp;
            }
            //вывод обновленного массива
            Console.WriteLine("\nОбновленный массив:");
            for (int i =0; i < array.Length; i++)
            {
                Console.WriteLine(string.Join("", array[i]));
            }
            //реверс каждой строки ступенчатого массива
            for (int i =0; i < array.Length; i++)
            {
                Array.Reverse(array[i]);
            }
            //вывод массива с реверсированными строками
            Console.WriteLine("\nМассив с реверсированными строками:");
            for (int i=0; i <array.Length; i++)
            {
                Console.WriteLine(string.Join("", array[i]));
            }
            //подсчёт наиболее встречающихся символов в каждой строке ступенчатого массива
            Console.WriteLine("\nНаиболее встречающиеся символы в каждой строке:");
            for (int i = 0; i < array.Length; i++)
            {
                int[] charCount = new int[26];
                for (int j =0; j < array[i].Length; j++)
                {
                    charCount[array[i][j] - 97]++;
                }
                int maxCount = 0;
                char mostFrequentChar =' ';
                for (int j=0;j<charCount.Length; j++)
                {
                    if (charCount[j] > maxCount)
                    {
                        maxCount = charCount[j];
                        mostFrequentChar = (char)(j + 97);
                    }
                }
                Console.WriteLine($"Строка {i + 1}:{mostFrequentChar}");
            }
        }
    }
}