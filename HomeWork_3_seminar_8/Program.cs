Random rnd = new Random();

int m = rnd.Next(4, 6);

int[,] matrix1 = new int[m, m];

System.Console.WriteLine("\nMатрица № 1");
System.Console.WriteLine();

for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        matrix1[i, j] = rnd.Next(1, 99);
        System.Console.Write(String.Format("{0,3}", matrix1[i, j]) + " ");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine("\nMатрица № 2");
System.Console.WriteLine();

int[,] matrix2 = new int[m, m];

for (int i = 0; i < matrix2.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        matrix2[i, j] = rnd.Next(1, 99);
        System.Console.Write(String.Format("{0,3}", matrix2[i, j]) + " ");
    }
    System.Console.WriteLine();
}

int[,] matrix3 = new int[m, m];

System.Console.WriteLine("\nРезультирующая матрица:");
System.Console.WriteLine();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrix1[i, j] = matrix1[i, j] * matrix2[i, j];
        matrix3[i, j] = matrix1[i, j];


    }
}
WriteArray(matrix3);

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,5}", array[i, j]) + " ");
        }
        Console.WriteLine();
    }
}


