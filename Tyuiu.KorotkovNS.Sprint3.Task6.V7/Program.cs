using Tyuiu.KorotkovNS.Sprint3.Task6.V7.Lib;
namespace Tyuiu.KorotkovNS.Sprint3.Task6.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Коротков Н. С. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3 *");
            Console.WriteLine("* Тема: Базовые навыки работы в С# *");
            Console.WriteLine("* Задание #6 *");
            Console.WriteLine("* Вариант #7 *");
            Console.WriteLine("* Выполнил: Коротков Никита Сергеевич | ИСТНб-24-1 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 10 / (6 + 3) *");
            Console.WriteLine("* и печатает результат на экране. *");
            Console.WriteLine("* *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: *");
            Console.WriteLine("***************************************************************************");
            int startValue = 17;
            int stopValue = 26;
            Console.WriteLine("Начало = " + startValue);
            Console.WriteLine("Конец = " + stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ: *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма = " + ds.GetSumTheDivisors(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
