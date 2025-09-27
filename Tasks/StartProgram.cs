class Start
{
    public static void Main(string[] args)
    {
        Tasks task = new Tasks();
        int[] nums = { 10, 2, 3, 4, 5, 6, 9, 10, -51, 0 };

        task.IsSorted(nums);
    }
}