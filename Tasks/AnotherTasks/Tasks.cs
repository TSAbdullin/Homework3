using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Tasks
{
    /* Задача №1
    Дана последовательность из 10 чисел. Определить, является ли эта последовательность
    упорядоченной по возрастанию. В случае отрицательного ответа определить
    порядковый номер первого числа, которое нарушает данную последовательность.
    Использовать break.
     */
    public void IsSorted(int[] nums) // метод, который проверяет сортированный массив или нет
    {
        bool isSorted = true;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] >= nums[i + 1])
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
}
