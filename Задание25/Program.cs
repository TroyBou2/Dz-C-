Console.WriteLine("Введите число: ");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
double b = Convert.ToInt32(Console.ReadLine());
double result = Math.Pow(a , b);
Console.WriteLine($"Число {a} в степени {b} будет равным {result}");