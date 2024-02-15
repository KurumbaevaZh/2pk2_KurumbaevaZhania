namespace PZ_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Abonent a1 = new Abonent("Иванов Иван Иванович", Tariff.Max);
            a1.Call(150);
            a1.Data(20);
            Abonent.AbonentCount();
        }
    }
}