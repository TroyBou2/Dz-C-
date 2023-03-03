Console.Write("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int n3 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2 && n1 > n3)
{
    Console.WriteLine($"Большее число: {n1}");
}
else if (n2 > n1 && n2 > n3)
{
    Console.WriteLine($"Большее число: {n2}");
} 
else if (n3 > n1 && n3 > n2)
{
    Console.WriteLine($"Большее число: {n3}");
}
else
{
    Console.WriteLine("Числа равны");
}