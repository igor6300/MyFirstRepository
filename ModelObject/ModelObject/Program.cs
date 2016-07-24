using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelObject
{
    //Небольшая программа моделирования поведения светофора
    class Program
    {
        static DateTime date = DateTime.Now;
        static DateTime timeTwelve = DateTime.Today;
        static DateTime timeSix = new DateTime(2016, 07, 14, 6, 0, 0);
        static string color;

        static void Main(string[] args)
        {
	    //Проверка "если не ночь"
            if (date.ToLongTimeString().CompareTo(timeTwelve.ToLongTimeString()) < 0 &&
                date.ToLongTimeString().CompareTo(timeSix.ToLongTimeString()) > 0)
            {
                //Смена цветов
                Color(2, 2);
                Color(2, 1);
                Color(2, 0);
                Color(2, 1);
            }
            else
            {
                color = colorArray[1];
                Console.WriteLine(color);
                Console.ReadKey();
            }

            //Вызвал рекурсивно метод чтобы проверить работает ли.
            Main(new String[] { });
        }

        //Вызов цвета светофора
        static void Color(int second, int colorID)
        {
            date = date.AddSeconds(second);
            while (DateTime.Now <= date)
            {
                color = colorArray[colorID];
                Console.WriteLine(color);
                //Console.ReadKey();
            }
        }

        //Массив цветов
        static string[] colorArray = new string[] {"Red", "Yellow", "Green" };

    }
}
