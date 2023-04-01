System.Console.WriteLine("Введите перове число");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int n = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int m, int n)
{
    if (m == n)
        return m;
    return m + SumNumbers(m + 1, n);

}
System.Console.WriteLine($"Сумма натуральных чисел в диапозоне от {m} до {n} равна {SumNumbers(m, n)}");