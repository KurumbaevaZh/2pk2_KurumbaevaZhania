namespace PZ_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            trolleybus tr1=new trolleybus("троллейбус", 30, 20);
            bus b1 = new bus("Bus", 20, 30);
            ferryboat f1 = new ferryboat("Ferry", 50, 100);

            Console.WriteLine(tr1 > b1);
            Console.WriteLine(b1 == f1);
            Console.WriteLine(tr1 != f1);
            Console.WriteLine(b1 < f1);
        }
    }
}