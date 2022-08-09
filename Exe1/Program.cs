Console.WriteLine("Введите трехзначное число");
int numberThreeRegister = Convert.ToInt32(Console.ReadLine());
if ((numberThreeRegister > 99) && (numberThreeRegister < 1000))
{
    int secondNumberOf = Convert.ToInt32((numberThreeRegister % 100) / 10);
    Console.WriteLine($"Вы ввели трехзначное число: {numberThreeRegister}, число во втором регистре: {secondNumberOf}");
}
else
    Console.WriteLine($"Вы ввели неверное число {numberThreeRegister}");