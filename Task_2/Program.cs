using System;
// Используя циклы и метод: Console.Write("*"), Console.Write(" "), Console.Write("\n").
// Выведите на экран: прямоугольник; прямоугольный треугольник;
// равносторонний треугольник; ромб.

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Прямоугольник


            // Инициализация переменных "Высота" и "Ширина".
            // Ввод высоты и ширишы прямоугольника пользователем.   
            Console.WriteLine("Прямоугольник: \nВведите высоту прямоугольника");
            int heightRectangle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ширину прямоугольника");
            int widthRectangle = Convert.ToInt32(Console.ReadLine());

            // Цикл со счетчиком for (Инициализация счетчика итераций;
            // Условие; Изменение счетчика) {Тело цикла}.
            // Колличество строк (высота прямоугольника).
            for (int i = 0; i < heightRectangle; i++)
            {

                // Колличество "*" в строке (ширина прямоугольника).
                for (int j = 0; j < widthRectangle; j++)
                {
                    // Вывод символа "*".
                    Console.Write("*");
                }
                // Переход на новую строку.
                Console.WriteLine();
            }

            #endregion
            #region Прямоугольный треугольник
            {
                Console.WriteLine("Прямоугольный треугольник:\nВведите длину катета прямоугольного треугольника");
                int rightTriangle = Convert.ToInt32(Console.ReadLine());
                // Цикл со счетчиком for (Инициализация счетчика итераций;
                // Условие; Изменение счетчика) {Тело цикла}.
                // Колличество строк (высоты трейгольника).
                for (int i = 0; i < rightTriangle; i++)
                {

                    //Колличество "*" в строке.
                    for (int j = 0; j < i; j++)
                    {
                        // Вывод символа "*".
                        Console.Write("*");
                    }
                    // Переход на новую строку.
                    Console.WriteLine();
                }
                #endregion
            #region Равносторонний треугольник
                {
                    // Ввод высоты и ширишы прямоугольника пользователем.   

                    Console.WriteLine("Равносторонний треугольник:\nВведите длинну стороны треугольника");
                    // Инициализация переменной "Длина стороны треугольника".
                    int equilateralTriangle = Convert.ToInt32(Console.ReadLine());

                    // Цикл со счетчиком for (Инициализация счетчика итераций;
                    // Условие; Изменение счетчика) {Тело цикла}.
                    // Колличество строк.
                    for (int i = 0; i < equilateralTriangle; i++)
                    {
                        // Колличество символов " " в строке.

                        for (int j = 0; j < equilateralTriangle - i; j++)
                        {
                            // Вывод символа "+".
                            Console.Write("+");
                        }

                        // Колличество "*" в строке.
                        for (int k = 0; k < i * 2 + 1; k++)
                        {
                            // Вывод символа "*".
                            Console.Write("*");
                        }

                        // Колличество символов "+" в строке.
                        for (int l = i; l < equilateralTriangle; l++)
                        {
                            // Вывод символа " ".
                            Console.Write("+");
                        }

                        // Переход на новую строку.
                        Console.WriteLine();
                    }

                    #endregion
            #region Ромб
                    {
                        // Инициализация переменной "Длина стороны ромба".
                        Console.WriteLine("Ромб:\nВведите длинну стороны ромба");

                        int sideRomb = Convert.ToInt32(Console.ReadLine());

                        // Цикл со счетчиком for (Инициализация счетчика итераций;
                        // Условие; Изменение счетчика) {Тело цикла}.
                        // Колличество строк (высота трейгольника).
                        for (int i = 0; i < sideRomb; i++)
                        {
                            // Колличество символов " " в строке.

                            for (int j = 0; j < sideRomb - i; j++)
                            {
                                // Вывод символа "+".
                                Console.Write("+");
                            }

                            // Колличество "*" в строке.
                            for (int k = 0; k <= i * 2; k++)
                            {
                                // Вывод символа "*".
                                Console.Write("*");
                            }

                            // Колличество символов "+" в строке.
                            for (int l = i; l < sideRomb; l++)
                            {
                                // Вывод символа " ".
                                Console.Write("+");
                            }

                            // Переход на новую строку.
                            Console.WriteLine();
                        }
                        int romb = sideRomb;
                        for (int m = 0; m <= romb; m++)
                        {
                            // Вывод символа "+".
                            for (int c = 0; c < m; c++)
                            {
                                // Колличество "*" в столбце.
                                Console.Write("+");
                            }
                            // Колличество "*" в строке.
                            for (int h = romb * 2; h >= m * 2; h--)
                            {
                                // Вывод символа "*".
                                Console.Write("*");
                            }
                            for (int s = 1; s <= m; s++)
                            {
                                // Вывод символа "+".
                                Console.Write("+");
                            }

                            // Переход на новую строку.
                            Console.WriteLine();
                        }

                        #endregion
                    }
                    Console.ReadKey();
                }
            }
        }
    }
}
