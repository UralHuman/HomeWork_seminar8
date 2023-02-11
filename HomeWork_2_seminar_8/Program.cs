Random rnd = new Random();
int m = rnd.Next(5, 7);
int n = rnd.Next(3, 4);

int[,] array = new int[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rnd.Next(-99, 99);
        System.Console.Write(String.Format("{0,3}", array[i, j]) + " ");
    }
    System.Console.WriteLine();
}

int sum = int.MaxValue;

int index = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    int temp = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        temp += array[i, j];
    }
    if (temp < sum)
    {
        sum = temp;
        index = i;
    }
}

Console.WriteLine("Строка с индексем: " + index + " Сумма: " + sum);
Console.WriteLine();

