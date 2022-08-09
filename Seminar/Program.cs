int number1 = new Random().Next(10, 100);
Console.WriteLine(number1);
int num1 = number1 / 10;
Console.WriteLine(num1);
int num2 = number1 % 10;
Console.WriteLine(num2);
if (num1 > num2)
    Console.WriteLine(num1);
    else
    Console.WriteLine(num2);