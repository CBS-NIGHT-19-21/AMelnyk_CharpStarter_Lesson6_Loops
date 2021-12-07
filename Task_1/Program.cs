using System;
// Дано два числа A и B (A<B) необходимо вывести на экран суму всех чисел расположенных между A и B.
// Дано два числа A и B (A<B) необходимо вывести на экран все нечетные числа расположеные между A и B.

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Инициализация переменных и ввод чисел пользоветелем.
            Console.WriteLine("Введите первое число");
            int numberFirst = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число больше первого");
            int numberSecond = Convert.ToInt32(Console.ReadLine());
            // Инициализация переменных.
            int sum = 0;

            #region Сумма чисел расположенных между A и B
            // for (Инициализация счетчика итераций; Условие; Изменение счетчика). 
            for (int i = numberFirst + 1; i < numberSecond; i++)
            {
                sum += i;

            }
            Console.WriteLine($"Cумма всех целочисленных числел расположеных между " +
                                $"{numberFirst} и {numberSecond} = {sum}");
            #endregion
            #region Все нечетные числа расположеные между A и B
            int parityNumber = 0;
            bool checkParity;
            // for (Инициализация счетчика итераций; Условие; Изменение счетчика). 
            for (int i = numberFirst + 1; i < numberSecond; i++)
            {
                parityNumber = i;

                // Условная конструкция - if (с одной ветвью).
                if (checkParity = Convert.ToBoolean(parityNumber % 2))
                {

                    Console.Write($"{parityNumber};");
                }
            }

            #endregion

            Console.ReadKey();
        }
    }
}
