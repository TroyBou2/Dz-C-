int m = 3;
int n = 4;
double[,] CreateOutputArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Random rnd = new Random();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-9, 10) + rnd.NextDouble();

            Console.Write($"{array[i, j]:f1}\t");
        }
        Console.WriteLine();
    }

    return array;
}
System.Console.WriteLine($" m = {m} ; n = {n}");
CreateOutputArray(m, n);