Double x1, x2, y1, y2, z1, z2, distance;

Console.WriteLine("Введите Координаты точки А (x,y,z): ");

x1 = Convert.ToDouble(Console.ReadLine());
y1 = Convert.ToDouble(Console.ReadLine());
z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Координаты точки В (x,y,z): ");

x2 = Convert.ToDouble(Console.ReadLine());
y2 = Convert.ToDouble(Console.ReadLine());
z2 = Convert.ToDouble(Console.ReadLine());

distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine($"{distance:f2}");