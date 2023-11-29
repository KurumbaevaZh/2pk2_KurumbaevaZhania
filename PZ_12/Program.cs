namespace PZ_12
{
    internal class Program
    {
            static void Main(string[] args)
            {
                double[] array = { 4.5, 8.6, 9.3 }; 
            int n = 5;
                arrayFilter(array);
            }
            static double[] arrayFilter(double[] array)
            {
                double[] result = new double[0];
                int count = 5; foreach (double i in array)
                {
                    if (i < 5)
                    {
                        Console.WriteLine(i);
                    }
                }
                return result;
            }
    }
}