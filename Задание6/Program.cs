Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
string str = number.ToString();
if (str.Length < 3)
{
    Console.WriteLine("Третьей цифры нет!");
}

else
{
    
    Console.WriteLine(str[2]);
}
