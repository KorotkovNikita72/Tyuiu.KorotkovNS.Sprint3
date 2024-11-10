using Tyuiu.KorotkovNS.Sprint3.Task7.V1.Lib;
namespace Tyuiu.KorotkovNS.Sprint3.Task7.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Коротков Н. С. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3 *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту *");
            Console.WriteLine("* Задание #7 *");
            Console.WriteLine("* Вариант #1 *");
            Console.WriteLine("* Выполнил: Коротков Никита Сергеевич | ИСТНб-24-1 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функций *");
            Console.WriteLine("* и печатает результат на экране. *");
            Console.WriteLine("* *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length; //Размер массива

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ: *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("| X | f(x) |");
            Console.WriteLine("+----------+----------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d} | {1,6:f2} |", startValue, valueArray[i]);
                startValue++;

            }
            Console.WriteLine("+----------+----------+");
            Console.ReadKey();
        }
    }
}
