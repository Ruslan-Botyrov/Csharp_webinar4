// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через while и "математику"

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int number = Prompt("Введите число ");
int sum = 0;
while (number > 0)
{
    sum += number % 10;
    number /= 10;
}
Console.WriteLine($"сумма цифр в числе = {sum}");

