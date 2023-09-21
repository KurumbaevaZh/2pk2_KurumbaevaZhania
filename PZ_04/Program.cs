namespace PZ_04
{
    internal class Program
    {
        static void Main(string[] args)
        { //задание 1
            Console.WriteLine("Задание 1");
            for (int i = -100; i <= 50; i += 5)
                Console.WriteLine(i);

            //задание 2
            Console.WriteLine("Задание 2");
            char startChar = 'N';
            for (int i = 0; i <6; i++)
            {
                Console.Write(startChar);
                startChar++;
            }
            Console.WriteLine();

            //задание3
            Console.WriteLine("Задание 3");
            for (int i =0; i<4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            //Задание 4
            Console.WriteLine("Задание 4");
            int count = 0;
            for ( int i = -200; i<=200; i++)
                if (i %5 ==0 )
                {
                    Console.Write(i + "");
                    count++;
                }
            Console.WriteLine("\nКоличество кратных чисел: " + count);

            //Задание 5
            Console.WriteLine("Задание 5");
            {
                int i = 4;
                int j = 50;
                while (Math.Abs(i - j) >= 22)
                {
                    Console.WriteLine($"i ={i}, j ={j}");
                    i++;
                    j--;
                }
                Console.WriteLine($"i ={i}, j ={j}");
            }


        }
    }
}