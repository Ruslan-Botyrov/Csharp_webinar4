// Задача 3: Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. 
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next();
        index++;
    }

}


void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($" {col[position]}");
        position++;
    }
}

int[] array = new int[8];
FillArray(array);
PrintArray(array);
