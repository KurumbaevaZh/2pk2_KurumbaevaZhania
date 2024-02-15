using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_18
{
    public enum Tariff { Max, Standard, Econom };


    public class Abonent
    {
        public string Name { get; set; }
        public Tariff Tariff { get; set; }
        public int Minutes { get; set; }
        public int GB { get; set; }

        private static int max;
        private static int standard;
        private static int econom;

        public Abonent(string Name, Tariff tariff)
        {
            int nameLength = Name.Length;
            if (nameLength > 0) //имя не должно быть пустым  
            { }
            else
            {
                Console.WriteLine("ФИО абонента не должно быть пустым");
            }
            Name = Name;
            Tariff = tariff;

            switch (Tariff) //типы тарифов
            {
                case Tariff.Max:
                    Minutes = 1000;
                    GB = 50;
                    max++;
                    break;

                case Tariff.Standard:
                    Minutes = 500;
                    GB = 30;
                    standard++;
                    break;

                case Tariff.Econom:
                    Minutes = 300;
                    GB = 10;
                    econom++;
                    break;

                default:
                    Console.WriteLine("Неизвестный тариф");
                    break;

            }
        }

        public void Call(int duration)//имитация звонка
        {
            if (duration < Minutes)
            {
                Minutes -= duration; //остаток минут
                Console.WriteLine($"Абонент {Name} совершил звонок продолжительностью {duration} мин, остаток минут: {Minutes}");
            }
            else
            {
                Console.WriteLine("Недостаточно минут для звонка");
            }
        }

        public void Data(int data)//имитация передачи данных
        {
            if (data < GB)
            {
                GB -= data;
                Console.WriteLine($"Абонент {Name} передал информацию в объеме {data} ГБ, остаток трафика: {GB} Гб");
            }
            else
            {
                Console.WriteLine("Недостаточно трафика для передачи данных");
            }
        }

        public static void AbonentCount()//метод, выводящий количество абонентов в каждом тарифе
        {
            Console.WriteLine($"Количество абонентов на тарифе Макси: {max}");
            Console.WriteLine($"Количество абонентов на тарифе Стандарт: {standard}");
            Console.WriteLine($"Количество абонентов на тарифе Эконом: {econom}");
            Console.ReadKey();
        }
    }
}
