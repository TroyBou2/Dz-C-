int[,] CreateMatrix(int m, int n)                       
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

int Mult(int[,] matrix1, int[,] matrix2, int n, int m)
{
    int sum = 0;
    for (int x = 0; x < matrix1.GetLength(1); x++)
    {
        sum += matrix1[n, x] * matrix2[x, m];
    }
    return sum;
}

int[,] MulMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int x = 0; x < matrix3.GetLength(0); x++)
    {
        for (int y = 0; y < matrix3.GetLength(1); y++)
        {
            matrix3[x, y] = Mult(matrix1, matrix2, x, y);
        }
    }
    return matrix3;
}

void OutputArray(int[,] matrix, string str)
{
    System.Console.WriteLine($"{str}:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

System.Console.Write("Введите количество строк первого массива: ");
int k = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов первого массива: ");
int l = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество строк второго массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов второго массива: ");
int n = Convert.ToInt32(Console.ReadLine());

if (l != m)
{
    System.Console.WriteLine("Матрицы нельзя перемножить");
    return;
}
int[,] matrix1 = CreateMatrix(k, l);
int[,] matrix2 = CreateMatrix(m, n);
int[,] matrix3 = MulMatrix(matrix1, matrix2);
OutputArray(matrix1, "Первая матрица:");
OutputArray(matrix2, "Вторая матрица:");
OutputArray(matrix3, "Результат умножения двух матриц:");