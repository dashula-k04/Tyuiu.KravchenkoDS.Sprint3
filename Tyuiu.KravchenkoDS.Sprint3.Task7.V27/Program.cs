using Tyuiu.KravchenkoDS.Sprint3.Task7.V27.Lib;


namespace Tyuiu.KravchenkoDS.Sprint3.Task7.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Кравченко Д. С. | ИСТНБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнила: Кравченко Дарья Сергеевна | ИСТНБ-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу,которая выводит таблицу значений функии по формуле." +
                "(произвести табулирование) f(x) на заданном диапазоне [-5; 5] с шагом 1. " +
                "Произвести проверку деления на ноль.При делении на ноль вернуть значение 0." +
                "Значения округлить до двух знаков после запятой.*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага =" + startValue);
            Console.WriteLine("Конец шага =" + stopValue);
            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                  *");
            Console.WriteLine("***************************************************************");

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   f(x)   |");
            Console.WriteLine("+----------+----------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}     | {1,8:f2} |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadKey();


        }
    }
}
