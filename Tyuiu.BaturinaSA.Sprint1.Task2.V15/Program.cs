using Tyuiu.BaturinaSA.Sprint1.Task2.V15.Lib;

namespace Tyuiu.BaturinaSA.Sprint1.Task2.V15
{

    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #1 | Выполнила: Батурина С. А. | ИСТНб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                    *");
            Console.WriteLine("* Задание #2                                                             *");
            Console.WriteLine("* Вариант #15                                                            *");
            Console.WriteLine("* Выполнил: Батурина Софья Алексеевна. | ИСТНб-25-1                      *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Variant 15, Известна длина стороны куба. Вычислить объём куба.         *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");


            int x;

            Console.WriteLine("Введите длину стороны куба X:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");


            Console.WriteLine("Объём куба =" + ds.CalculateCubeVolume(x));


            Console.ReadLine();
        }
    }
}