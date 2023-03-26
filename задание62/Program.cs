bool InRange(int[,] array, int stp, int x, int y)
{
    switch (stp)
    {
        case 0:     //вправо
            y++;
            if (y >= array.GetLength(1))
            {
                return false;
            }
            break;
        case 1:     //вниз
            x++;
            if (x >= array.GetLength(0))
            {
                return false;
            }
            break;
        case 2:     //влево
        y--;
            if (y < 0)
            {
                return false;
            }
            break;
        case 3:     //вверх
        x--;
            if (x < 0)
            {
                return false;
            }
            break;
    }
    return array[x, y] == 0;
}
void Step(int stp, ref int x, ref int y)
{
    switch (stp)
    {
        case 0:     //вправо
            y++;
            break;
        case 1:     //вниз
            x++;
            break;
        case 2:     //влево
            y--;
            break;
        case 3:     //вверх
            x--;
            break;
    }
}

void OutputArray(int[,] matrix, string str)
{
    System.Console.WriteLine($"{str}:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:00} ");
        }
        Console.WriteLine();
    }
}

int n = 4;
int m = 4;
int x = 0;
int y = 0;
int stp = 0;
int[,] array = new int[n, m];

for (int i = 0; i < m * n; i++)
{
    array[x, y] = i + 1;
    if (InRange(array, stp, x, y)== false)
    {
        stp++;
        if (stp == 4)
        {
            stp = 0;
        }
    }
    Step(stp, ref x, ref y);
}

OutputArray(array, "result");