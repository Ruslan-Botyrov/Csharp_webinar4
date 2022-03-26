// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int numberA = Prompt("Введите число А ");
int numberB = Prompt("Введите число B ");

int pow = 1;
for (int i =0; i<numberB; i++){
    pow *=numberA;
}
Console.WriteLine($"{numberA}^{numberB} = {pow}");
