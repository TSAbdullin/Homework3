using System;
using System.ComponentModel.DataAnnotations;

namespace Hometask3.TaskLab4_Tumakov_
{

    /*
    Упражнение 4.1 Написать программу, которая читает с экрана число от 1 до 365 (номер дня
    в году), переводит этот число в месяц и день месяца.Например, число 40 соответствует 9
    февраля (високосный год не учитывать).

    Упражнение 4.2 Добавить к задаче из предыдущего упражнения проверку числа введенного
    пользователем.Если число меньше 1 или больше 365, программа должна вырабатывать
    исключение, и выдавать на экран сообщение.

    Домашнее задание 4.1 Изменить программу из упражнений 4.1 и 4.2 так, чтобы она
    учитывала год (високосный или нет). Год вводится с экрана. (Год високосный, если он
    делится на четыре без остатка, но если он делится на 100 без остатка, это не високосный
    год. Однако, если он делится без остатка на 400, это високосный год.)
     */

    // Лучшая реализая на мой взгляд, конечно, лучше было бы все описать в одном методе NumInDate, но в рамках заданий я поделю его на 3 части и напишу в разных
    class AnotherRealization
    {

        public void NumInDateFirst() // Задача 4.1
        {
            Print("Упражнение 4.1 Написать программу, которая читает с экрана число от 1 до 365 (номер дня\r\n    в году), переводит этот число в месяц и день месяца.Например, число 40 соответствует 9\r\n    февраля (високосный год не учитывать).\n\n");

            Print("Введите число от 1 до 365: ");

            int num = Convert.ToInt32(Console.ReadLine());

            DateTime date = new DateTime(2025, 1, 1); // Создал экземляр класса DateTime
            Print(date.AddDays(num - 1).ToString());

            Console.ReadKey();
        }

        public void NumInDateSecond() // Задача 4.2
        {
            Print("Упражнение 4.2 Добавить к задаче из предыдущего упражнения проверку числа введенного\r\n    пользователем.Если число меньше 1 или больше 365, программа должна вырабатывать\r\n    исключение, и выдавать на экран сообщение.\n\n");

            Print("Введите число от 1 до 365: ");

            try
            {
                if (!int.TryParse(Console.ReadLine(), out int num))
                {
                    throw new FormatException("Введенное значение не является числом!");
                }

                if (num < 1 || num > 365)
                {
                    throw new IndexOutOfRangeException("Число не входит в промежуток 1 <= num <= 365");
                }

                DateTime date = new DateTime(2025, 1, 1); // Создал экземляр класса DateTime
                Print(date.AddDays(num - 1).ToString());


            }
            catch (Exception e)
            {
                Print(e.Message);
            }

            Console.ReadKey();
        }

        public void NumInDate() 
        {

            Print("Домашнее задание 4.1 Изменить программу из упражнений 4.1 и 4.2 так, чтобы она\r\n    учитывала год (високосный или нет). Год вводится с экрана. (Год високосный, если он\r\n    делится на четыре без остатка, но если он делится на 100 без остатка, это не високосный\r\n    год. Однако, если он делится без остатка на 400, это високосный год.)\n\n");

            Print("Введите год: ");

            try
            {

                if (!int.TryParse(Console.ReadLine(), out int year)) 
                {
                    throw new FormatException("Введенное значение не число!");
                }

                int maxDays = DateTime.IsLeapYear(year) ? 366 : 365;

                Print($"Введите число от 1 до {maxDays}: ");

                if (!int.TryParse(Console.ReadLine(), out int num))
                {
                    throw new FormatException("Введенное значение не является числом!");
                }

                if (num < 1 || num > maxDays)
                {
                    throw new IndexOutOfRangeException($"Число не входит в промежуток 1 <= num <= {maxDays}");
                }

                DateTime date = new DateTime(year, 1, 1); // Создал экземляр класса DateTime

                Print(date.AddDays(num - 1).ToString());

            } catch (Exception e)
            {
                Print(e.Message);
            }

            Console.ReadKey();

        }


        public void Print(string text) // метод чисто для вывода текста
        {
            Console.Write(text);
        }
    }
}
