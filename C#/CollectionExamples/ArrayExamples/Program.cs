namespace ArrayExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-D Array!");
            int[] numbers = new int[5] { 10, 20, 30, 40, 50 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]}\t");
            }
            Console.WriteLine("\n\n2-D Array!");
            int[,] rowsCols = new int[2, 2] { { 10, 20 }, { 30, 40 } };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{rowsCols[i, j]}\t");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\nJagged Array!");
            int[][] marks = new int[3][];
            marks[0] = new int[] { 10, 30, 40 };
            marks[1] = new int[] { 10, 30, 40, 70, 89 };
            marks[2] = new int[] { 10, 30, 40, 70, 89, 76, 45 };

            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($"In Row - {i}");
                for (int j = 0; j < marks[i].Length; j++)
                {
                    Console.Write($"\t {marks[i][j]}");
                }
                Console.WriteLine("");
            }
        }
    }
}
