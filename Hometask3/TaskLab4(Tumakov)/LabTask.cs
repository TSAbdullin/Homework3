using Hometask3.TaskLab4.Classes;
using System;

namespace Hometask3.TaskLab4
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

    class LabTask
        {
            public void NumInDate() // Упражнение 4.1, определяем какому дню соотвествует число от 1 до 365
            {
                Console.Write("Введите год: ");

                bool isCorrectYear = int.TryParse(Console.ReadLine(), out int year);

                if (!isCorrectYear) // мини-проверка на корректность введенного года
                {
                    Console.WriteLine("Вы ввели некорректный год!");
                    return;
                }

                int februaryDays = IsLeapYear(year) ? 29 : 28; // переменная февраль хранит значение 29, если год високосный и 28, если нет
                int maxDays = februaryDays == 28 ? 365 : 366; // переменная, отвечающая за количество дней, 365, либо 366, зависит от года 

                List<Month> months = new List<Month>  // список где будут храниться месяцы
                {
                    new Month("Январь", 31),
                    new Month("Февраль", februaryDays),
                    new Month("Март", 31),
                    new Month("Апрель", 30),
                    new Month("Май", 31),
                    new Month("Июнь", 30),
                    new Month("Июль", 31),
                    new Month("Август", 31),
                    new Month("Сентябрь", 30),
                    new Month("Октябрь", 31),
                    new Month("Ноябрь", 30),
                    new Month("Декабрь", 31)
                };


                Console.Write($"Введите число от 1 до {maxDays}: ");
                bool isParsed = int.TryParse(Console.ReadLine(), out var num);

                if (!isParsed || num < 1 || num > maxDays) // проверка на то, является ли то, что ввел пользователем типом int + проверка на диапазон [1; maxDays]
                {
                    Console.WriteLine("Преобразование выполнить не удалось!\nВозможные причины:\n1. Число выходит за рамки [1; 365]!\n2. Вы ввели не число");
                    return;
                }
                PrintMonthAndDay(months, num);

            }

            public bool IsLeapYear(int year) // метод, который определит високосный год или нет
            {
                bool result = false;
            
                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)) 
                {
                    result = true; 
                }

                return result;
            }

            public void PrintMonthAndDay(List<Month> months, int num) // метод, который напечает месяц и день по числу, которое ведет пользователь
            {
                foreach (Month month in months)
                {
                    if (num <= month.GetDays())
                    {
                        Console.WriteLine($"Месяц: {month.GetName()}\nДень: {num}");
                        break;
                    }
                    else
                    {
                        num -= month.GetDays();
                    }
                }
            } 
        }
}
