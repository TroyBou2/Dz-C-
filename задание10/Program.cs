Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write(1);
for (int i = 2; i <= num; i++)
{
    double pow3 = Math.Pow(i, 3);
    Console.Write($", {pow3:f0}");
}
