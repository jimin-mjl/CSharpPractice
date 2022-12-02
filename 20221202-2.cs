internal class Program
{
    static void PrintStars(int num)
    {
        for (int i = 1; i <= num; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("--별 찍기--");
        Console.WriteLine();
        Program.PrintStars(10);
    }
}