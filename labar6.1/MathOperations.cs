using System;

class MathOperations
{
    // Перевантажений метод додавання для чисел
    public static int Add(int a, int b)
    {
        return a + b;
    }

    // Перевантажений метод додавання для масивів чисел
    public static int[] Add(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
        {
            throw new ArgumentException("Arrays must have the same length");
        }

        int[] result = new int[array1.Length];
        for (int i = 0; i < array1.Length; i++)
        {
            result[i] = array1[i] + array2[i];
        }

        return result;
    }

    // Перевантажений метод додавання для матриць
    public static int[,] Add(int[,] matrix1, int[,] matrix2)
    {
        if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
        {
            throw new ArgumentException("Matrices must have the same dimensions");
        }

        int rows = matrix1.GetLength(0);
        int columns = matrix1.GetLength(1);

        int[,] result = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }

    // Перевантажений метод віднімання для чисел
    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    // Перевантажений метод віднімання для масивів чисел
    public static int[] Subtract(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
        {
            throw new ArgumentException("Arrays must have the same length");
        }

        int[] result = new int[array1.Length];
        for (int i = 0; i < array1.Length; i++)
        {
            result[i] = array1[i] - array2[i];
        }

        return result;
    }

    // Перевантажений метод віднімання для матриць
    public static int[,] Subtract(int[,] matrix1, int[,] matrix2)
    {
        if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
        {
            throw new ArgumentException("Matrices must have the same dimensions");
        }

        int rows = matrix1.GetLength(0);
        int columns = matrix1.GetLength(1);

        int[,] result = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }

        return result;
    }

    // Перевантажений метод множення для чисел
    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    // Перевантажений метод множення для масивів чисел
    public static int[] Multiply(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
        {
            throw new ArgumentException("Arrays must have the same length");
        }

        int[] result = new int[array1.Length];
        for (int i = 0; i < array1.Length; i++)
        {
            result[i] = array1[i] * array2[i];
        }

        return result;
    }

    // Перевантажений метод множення для матриць
    public static int[,] Multiply(int[,] matrix1, int[,] matrix2)
    {
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
        {
            throw new ArgumentException("Number of columns in the first matrix must be equal to the number of rows in the second matrix");
        }

        int rows = matrix1.GetLength(0);
        int columns = matrix2.GetLength(1);
        int commonLength = matrix1.GetLength(1);

        int[,] result = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                int sum = 0;
                for (int k = 0; k < commonLength; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                result[i, j] = sum;
            }
        }

        return result;
    }
}