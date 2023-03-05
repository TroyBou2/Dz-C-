Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int sum = number.ToString().Length;
if (sum > 3 || sum < 3)
    {
        Console.WriteLine("Вы ввели не трехзначное число! ");
    }
else 
    {int result = ((number / 10) % 10);
Console.WriteLine(result);
    }