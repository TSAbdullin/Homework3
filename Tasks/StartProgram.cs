class Start
{
    public static void Main(string[] args)
    {
        Tasks task = new Tasks();
        int[] nums = { 10, 2, 3, 4, 5, 6, 9, 10, -51, 0 };
        string[] arr = { "hello kitty", "doll", "HeLlo Kitty", "Barbie doll", "awfawf", "gsgfbxvs", "BARBie DoLL" };


        //task.IsSorted(nums); // Задача 1
        //task.DefineValueOfCard(); // Задача 2
        //task.PrintMatchingValue(); // Задача 3
        //task.PrintDayOfWeek(); // Задача 4
        Console.WriteLine($"Кукол в сумке: {task.HowManyDollsInBag(arr)}"); // Задача 5
    }
}