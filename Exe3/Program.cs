Console.Clear();
int Saturday = 6;
int Sunday = 7;
Console.WriteLine($"Введите номер дня недели: ");
int dayWeek = Convert.ToInt32(Console.ReadLine());
if (dayWeek == Saturday || dayWeek == Sunday)
    Console.WriteLine("Выходной!");
else Console.WriteLine("Будни...");