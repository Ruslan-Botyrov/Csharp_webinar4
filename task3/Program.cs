// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int number = Prompt("Введите число ");
int mult = 1;
int counter = 1;
while (counter < number)
{
    {
        mult = mult * (counter + 1);

    }
    counter++;
}
Console.WriteLine(mult);


