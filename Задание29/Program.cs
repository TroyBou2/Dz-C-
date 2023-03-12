string [] arr = new string[8];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(99).ToString();
}
Console.WriteLine("[{0}]", string.Join(", ", arr));