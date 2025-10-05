using Tyuiu.BaturinaSA.Sprint1.Task3.V7.Lib;

namespace Tyuiu.BaturinaSA.Sprint1.Task3.V7
{

    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #1 | Выполнила: Батурина С. А. | ИСТНб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                *");
            Console.WriteLine("* Задание #3                                                             *");
            Console.WriteLine("* Вариант #7                                                             *");
            Console.WriteLine("* Выполнил: Батурина Софья Алексеевна. | ИСТНб-25-1                      *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу пересчета расстояния из верст в километры           *");
            Console.WriteLine("* (1 верста — это 1066,8 м). Ответ округлите до 3 знаков после запятой.  *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            double x;

            Console.WriteLine("Укажите расстояние в верстах:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("****************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                   *");
            Console.WriteLine("****************************************************************************************************************");


            Console.WriteLine(ds.VerstsToKilometers(x));

            Console.ReadLine();


        }
    }
}