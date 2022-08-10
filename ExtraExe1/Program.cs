Console.Clear();
Console.WriteLine("Введите диапазон чисел от n1");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число до n2");
int n2 = Convert.ToInt32(Console.ReadLine());
int temp = 0;
if (n1 < n2)
{
    for (; n1 <= n2; n1++)
    {
        if (n1 % 2 != 0)
            temp = n1 + temp;
    }
    Console.WriteLine($"Сейчас: {temp}");
}
else
    Console.WriteLine("Вы ввели неверный диапазон");