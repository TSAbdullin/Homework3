using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Task
{
    /* Задача 1
    Дана последовательность из 10 чисел. Определить, является ли эта последовательность
    упорядоченной по возрастанию. В случае отрицательного ответа определить
    порядковый номер первого числа, которое нарушает данную последовательность.
    Использовать break.
     */
    public void IsSorted(int[] nums) // метод, который проверяет сортированный массив или нет
    {
        Console.WriteLine("Задача 1\r\n    Дана последовательность из 10 чисел. Определить, является ли эта последовательность\r\n    упорядоченной по возрастанию. В случае отрицательного ответа определить\r\n    порядковый номер первого числа, которое нарушает данную последовательность.\r\n    Использовать break.\n");

        bool isSorted = true; // переменная, которая будет хранить булевое значение, является ли массив сортированным или нет

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] > nums[i + 1])
            {
                Console.WriteLine($"Порядковый номер первого числа, который нарушает последовательность: {i + 1}");
                isSorted = false;
                break;
            }
        }

        if (isSorted)
        {
            Console.WriteLine("Отсортирован!");
        }
    }


    /* Задача 2
    Игральным картам условно присвоены следующие порядковые номера в зависимости от
    их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.
    Порядковые номера остальных карт соответствуют их названиям («шестерка»,
    «девятка» и т. п.). По заданному номеру карты k (6 <=k <= 14) определить достоинство
    соответствующей карты. Использовать try-catch-finally.
     */
    public void DefineValueOfCard()
    {
        Console.WriteLine("Задача 2\r\n    Игральным картам условно присвоены следующие порядковые номера в зависимости от\r\n    их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.\r\n    Порядковые номера остальных карт соответствуют их названиям («шестерка»,\r\n    «девятка» и т. п.). По заданному номеру карты k (6 <=k <= 14) определить достоинство\r\n    соответствующей карты. Использовать try-catch-finally.\n");

        Dictionary<int, string> cards = new Dictionary<int, string> // словарь для хранения значений 
            {
                { 6, "шестерка" },
                { 7, "семерка" },
                { 8, "восьмерка"},
                { 9, "девятка" },
                { 10, "десятка" },
                { 11, "валет" },
                { 12, "дама" },
                { 13, "король" },
                { 14, "туз" }
            };

        Console.Write($"Введите число k: ");

        try
        {
            if (!int.TryParse(Console.ReadLine(), out int k))
            {
                throw new FormatException("Введите правильный формат числа!"); 
            }

            if (k < 6 || k > 14)
            {
                throw new IndexOutOfRangeException("Число k должно быть в рамках 6 <= k <= 14");
            }

            if (cards.TryGetValue(k, out string finalCard))
            {
                Console.WriteLine($"Достоинство карты {k}: {finalCard}");
            }

        } catch (Exception e)
        {
            Console.WriteLine(e.Message);
        } finally 
        { 
            Console.WriteLine("Все проверки завершены"); 
        }
    }

    /* Задача 3
    Напишите программу, которая принимает на входе строку и производит выходные
    данные в соответствии с таблицей
     */
    public void PrintMatchingValue()
    {
        Console.WriteLine("Задача 3\r\n    Напишите программу, которая принимает на входе строку и производит выходные\r\n    данные в соответствии с таблицей\n");

        Console.Write("Введите строку: ");
        string text = Console.ReadLine();

        switch (text.ToLower())
        {
            case "jabroni":
                Console.WriteLine("Patron Tequlla");
                break;
            case "school counselor":
                Console.WriteLine("Anything with Alcohol");
                break;
            case "programmer":
                Console.WriteLine("Hipster Craft Beer");
                break;
            case "bike gang member":
                Console.WriteLine("Moonshine");
                break;
            case "politician":
                Console.WriteLine("Your tax dollars");
                break;
            case "rapper":
                Console.WriteLine("Cristal");
                break;
            default:
                Console.WriteLine("Beer");
                break;
        }
    }

    /* Задача 4
     Составить программу, которая в зависимости от порядкового номера дня недели (1, 2,...,7) 
    выводит на экран его название (понедельник, вторник, ..., воскресенье).
    Использовать enum.
     */
    
    public void PrintDayOfWeek()
    {
        Console.WriteLine("Задача 4\r\n     Составить программу, которая в зависимости от порядкового номера дня недели (1, 2,...,7) \r\n    выводит на экран его название (понедельник, вторник, ..., воскресенье).\r\n    Использовать enum.\n");

        Console.Write("Введите число(от 1 до 7): ");
        
        try
        {
            if (!int.TryParse(Console.ReadLine(), out int num))
            {
                throw new FormatException("Неверный формат ввода!");
            }

            if (num < 1 || num > 7)
            {
                throw new IndexOutOfRangeException("Число не входит в промежуток 1 <= num <= 7");
            } 
            Console.WriteLine((Tasks.AnotherTasks.Enums.DayOfWeek)(num - 1));

        } catch (Exception e)
        {
            Console.WriteLine($"Ошибка: {e.Message}");
        }
    }

    /* Задача 5
    Создать массив строк. При помощи foreach обойти весь массив. При встрече элемента
    "Hello Kitty" или "Barbie doll" необходимо положить их в “сумку”, т.е. прибавить к
    результату. Вывести на экран сколько кукол в “сумке”.
     */
    public int HowManyDollsInBag(string[] arrStrings)
    {
        Console.WriteLine("Задача 5\r\n    Создать массив строк. При помощи foreach обойти весь массив. При встрече элемента\r\n    \"Hello Kitty\" или \"Barbie doll\" необходимо положить их в “сумку”, т.е. прибавить к\r\n    результату. Вывести на экран сколько кукол в “сумке”\n");

        int count = 0; // переменная счетчик
        
        foreach (var str in arrStrings)
        {
            if (str.Equals("Hello Kitty", StringComparison.CurrentCultureIgnoreCase) || str.Equals("Barbie doll", StringComparison.CurrentCultureIgnoreCase))
            {
                count++;
            }
        }

        return count;
    }

}
