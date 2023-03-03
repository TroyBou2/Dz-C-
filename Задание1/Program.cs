Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"Большее число: {a}");
    Console.WriteLine($"Меньшее число: {b}");
}
else if (a < b)
{
    Console.WriteLine($"Большее число: {b}");
    Console.WriteLine($"Меньшее число: {a}");
    
} else 
{
    Console.WriteLine("Числа равны");
}
