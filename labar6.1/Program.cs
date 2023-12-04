class Program
{
    static void Main()
    {
        // Приклад використання класу MathOperations
        int a = 5;
        int b = 3;
        int result = MathOperations.Add(a, b);
        Console.WriteLine($"Addition of {a} and {b}: {result}");

        int[] array1 = { 1, 2, 3 };
        int[] array2 = { 4, 5, 6 };
        int[] arraySum = MathOperations.Add(array1, array2);
        Console.WriteLine("Array addition:");
        Console.WriteLine(string.Join(", ", arraySum));

        int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
        int[,] matrix2 = { { 5, 6 }, { 7, 8 } };
        int[,] matrixSum = MathOperations.Add(matrix1, matrix2);
        Console.WriteLine("Matrix addition:");
        for (int i = 0; i < matrixSum.GetLength(0); i++)
        {
            for (int j = 0; j < matrixSum.GetLength(1); j++)
            {
                Console.Write($"{matrixSum[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}
