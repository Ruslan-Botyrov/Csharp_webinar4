// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через перевод в массив и сумму элементов массива.

string Prompt(string message)
{
    Console.Write(message);
    string Value = Console.ReadLine();
    return Value;
}

int[] NumberArray(string numbers)
{
    int[] array = new int[numbers.Length];
    for (int i = 0; i < numbers.Length; i++)
    {
        array[i] = int.Parse(numbers[i].ToString());
    }
    return array;
}


string number = Prompt("Введите число:");
int[] digits = NumberArray(number);
int sumDigits = 0;
for (int i = 0; i < digits.Length; i++)
{
    sumDigits += digits[i];
}
Console.WriteLine(sumDigits);