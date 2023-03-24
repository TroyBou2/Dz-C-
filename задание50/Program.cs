int m = 4;
int n = 4;

int[,] CreateOutputArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);

            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}


void SearchElementArray(int[,] initArray, int x, int y)
{


    if (x >= 0 && x < initArray.GetLength(0) && y >= 0 && y < initArray.GetLength(1))
    {
        System.Console.WriteLine(initArray[x, y]);
    }
    else
        System.Console.WriteLine("Такого значения нет");

}


System.Console.WriteLine("Введите позицию строки массива:");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите позицию столбца массива:");
int y = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateOutputArray(m, n);
SearchElementArray(array, x, y);