Console.WriteLine("Введите любое число, не меньше 100");
int number = Convert.ToInt32(Console.ReadLine()); 
if (number < 100)
    Console.WriteLine($"Вы ввели число меньше трехзначного {number} и нет третьей цифры");
else
{
    while (number > 999)
    {
        number = number / 10;
    }
    Console.WriteLine($"число во третьем регистре: {number % 10}");
}