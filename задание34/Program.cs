System.Console.WriteLine("Введите разер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int count = 0;
int[] arr = new int[size];
string[] str = new string[size];

for (int i = 0; i < size; i++)
{
    arr[i] = new Random().Next(100, 1000);
    str[i] = arr[i].ToString();
}
    System.Console.WriteLine($"[{string.Join(", ", str)}]");

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {

        count++;
    }

}
System.Console.WriteLine($"Количество чётных чисел {count}");