Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 9999 && num < 100000)
{
    string str = num.ToString();
    if (str [0] == str [4] && str[1] == str[3])
        Console.WriteLine("да");
    else
        Console.WriteLine("нет");

}
else 
Console.WriteLine("Число не пятизначное ");