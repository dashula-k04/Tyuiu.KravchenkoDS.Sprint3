using Tyuiu.KravchenkoDS.Sprint3.Task3.V6.Lib;

namespace Tyuiu.KravchenkoDS.Sprint3.Task3.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Кравченко Д. С. | ИСТНБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла  foreach                                           *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #6                                                             *");
            Console.WriteLine("* Выполнила: Кравченко Дарья Сергеевна | ИСТНБ-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Используя цикл foreach заменить цифры на букву t в строке: 12able 1o s4gh.*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string str = "12able 1o s4gh";
            char chr = 't';

            Console.WriteLine("Строка: " + str);
            Console.WriteLine("Символ для замены: " + chr);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.ReplaceNumOnChar(str, chr);

            Console.WriteLine("Результат: " + res);
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();


        }
    }
}
