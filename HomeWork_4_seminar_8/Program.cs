int[,,] array3d = new int[3, 3, 3];

FillRandom(array3d, new Random());
System.Console.WriteLine();
WriteArray(array3d);

void FillRandom(int[,,] array2d, Random random)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            for (int k = 0; k < array2d.GetLength(2); k++)
            {
                {
                    int randNumber = random.Next(10, 100);

                    while (Array2dContains(array2d, randNumber))
                    {
                        randNumber = random.Next(10, 100);
                    }

                    array2d[i, j, k] = randNumber;

                }
            }
        }

    }

}

void WriteArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]} ({j},{k},{i}) ");
            }
            Console.WriteLine();
        }

    }
}
System.Console.WriteLine();

bool Array2dContains(int[,,] array2d, int randNumber)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            for (int k = 0; k < array2d.GetLength(2); k++)
            {
                if (array2d[i, j, k] == randNumber)
                    return true;
            }
        }
    }

    return false;
}

