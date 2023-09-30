namespace PZ_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd=new Random();
            double[,] m = new double[8, 6];
            for (int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    m[i,j]= rnd.NextDouble()*20-10;
                }
            }
            Console.WriteLine("Матрица m: ");
            for (int i = 0; i < 8; i++)
            {
                for (int j =  0; j < 6; j++)
                {
                    Console.Write("{0,8:F2}", m[i, j]);
                }
                Console.WriteLine();
            }
            double min = m[0,0];
            for (int i = 0; i<8; i++)
            {
                for (int j=0; j<6; j++)
                {
                    if (m[i,j] < min)
                    {
                        min = m[i, j];
                    }
                }
            }
            double sum = 0;
            for (int i = 0; i<8; i++)
            {
                for (int j=0; j<6; j++)
                {
                    if (m[i,j] > 0)
                    {
                        sum += m[i, j];
                    }
                }
            }
            double result = min * sum;
            Console.WriteLine("Произдедение минимального элемента матрицы на сумму её положительных элементов: " + result);
        }
    }
}