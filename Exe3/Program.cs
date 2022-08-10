Console.Clear();
int saturday = 6;
int sunday = 7;
Console.WriteLine($"Введите номер дня недели: ");
int dayWeek = Convert.ToInt32(Console.ReadLine());
if (dayWeek == saturday || dayWeek == sunday)
    Console.WriteLine("Выходной!");
else Console.WriteLine("Будни...");