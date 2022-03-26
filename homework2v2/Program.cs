// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через перевод в массив и сумму элементов массива.

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}


int number = Prompt("Введите число ");
char[] arr = number.ToString().ToCharArray();

int sum = 0;
for (int i = 0; i < (arr.Length-1); i++)
{
    sum += arr[i];
}

Console.WriteLine(sum); //так не получается, не понимаю почему :(
    