System.Console.WriteLine("Введите перове число");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int n = Convert.ToInt32(Console.ReadLine());

int Ack(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (n == 0)
        return Ack(m - 1, 1);
    return Ack(m - 1, Ack(m, n - 1));


}

System.Console.WriteLine(Ack(m,n));
