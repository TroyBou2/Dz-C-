Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine($"{num} Чётное");
}
else 
{
    Console.WriteLine($"{num} Нечётное");
}
