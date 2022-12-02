internal class Program
{
    static void PrintMulTable(int num)
    {
        for (int i = 0; i < 9; i++)
        {
            Console.WriteLine($"{num} * {i + 1} = {num * (i + 1)}");
        }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("--구구단 출력하기--");
        Console.WriteLine();

        for (int i = 0; i < 9; i++)
        {
            Program.PrintMulTable(i + 1);
        }
    }
}