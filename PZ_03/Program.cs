namespace PZ_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму покупки без скидки");
            double sum = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите день недели");
            string day = Console.ReadLine();
            double discount;
            switch (day)
            {
                case "Суббота":
                    discount = 0.1;
                    break;
                case "Воскресенье":
                    discount = 0.1;
                    break;
                default:
                    discount = 0.05;
                    break;
            }
            double discount1 = sum * discount;
            double result = sum - discount1;
            Console.WriteLine($"Скидка в этот день: {discount1 * 100}");
            Console.WriteLine($"Сумма со скидкой: {result}");
            Console.ReadLine();
        }
    }
}