Console.WriteLine("Введите трехзначное число");
int numberThreeRegisters = Convert.ToInt32(Console.ReadLine());
if ((numberThreeRegisters > 99) && (numberThreeRegisters < 1000))
{
    int secondNumberOf = Convert.ToInt32((numberThreeRegisters % 100) / 10);
    Console.WriteLine($"Вы ввели трехзначное число: {numberThreeRegisters}, число во втором регистре: {secondNumberOf}");
}
else
    Console.WriteLine($"Вы ввели неверное число {numberThreeRegisters}");