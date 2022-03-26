// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Решение без цикла)))

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int numberA = Prompt("Введите число А ");
int numberB = Prompt("Введите число B ");

//double result = Math.Pow(numberA, numberB);  не очень понял, почему если задаю переменную и вывожу ее через математическую функцию Math.Pow, то почему тип должен быть double

//Console.WriteLine(result);

Console.WriteLine($"{numberA}^{numberB} = " + Math.Pow(numberA, numberB)); //при этом если сразу выводить в консоль, то можно оставить тип int...непонятно, но получилось и так и так.