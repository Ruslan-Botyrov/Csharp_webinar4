// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 

//Console.WriteLine("введите число");
//string strValue = Console.ReadLine();

//int strLen = strValue.Length;
//Console.WriteLine(strLen);


int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int number = Prompt("Введите число ");
//пока число больше 1 делим его на 10 и к счетчику прибавляем 1
int counter = 0;
while (number >= 1)
{
    number = number / 10;
    counter++;

}
Console.WriteLine(counter);