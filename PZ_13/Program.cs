namespace PZ_13
{
    internal class Program
    {
        static void Main(string[] args)
        { //задание 1
            Console.WriteLine("Задание 1");
            int a1 = -95;
            int d = 5;
            Console.WriteLine("введите значение n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int resault = Progression(a1, d, n);
            Console.WriteLine($"{n}-член арифметической прогресии: {resault}");

            //задание 2
            Console.WriteLine("Задание 2");
            double b1 = 12;
            double q = 0.01;
            Console.WriteLine("введите значение m: ");
            double m = Convert.ToInt32(Console.ReadLine());
            double res = GeoProgression(b1, q, m);
            Console.WriteLine($"{m}-член арифметической прогресии: {res}");

            //задание 3
            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите А:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B:");
            int B = Convert.ToInt32(Console.ReadLine());
            if (A < B)
            {
                Increase(A, B);
            }
            else
            {
                decreasing(A, B);
            }




        }
        static int Progression(int a1, int d, int n) //к первой задаче
        {
            int count = 0;
            if (n == 1)
            {
                return a1;
            }
            else
            {
                a1 += d;
                count++;
            }
            return Progression(a1, d, n - 1);
        }

        static double GeoProgression(double b1, double q, double m) //ко второй задаче
        {

            if (m == 1)
            {
                return b1;
            }
            else
            {
                return q * GeoProgression(b1, q, m - 1);
            }
        }

        static void Increase(int A, int B) //к третьей задаче
        {
            Console.Write(A + " ");

            if (A < B)
            {
                Increase(A + 1, B);
            }
        }

        static void decreasing(int A, int B)
        {
            Console.Write(A + " ");

            if (A > B)
            {
                decreasing(A - 1, B);
            }
        }
    }
}
