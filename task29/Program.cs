//Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран. Вывод сделать отдельным методом.

int[] array = new int[8];

FillPrintArray(array);

void FillPrintArray (int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index<length)
    {
        collection[index]=new Random().Next(0,100);
        Console.Write($"{collection[index]} ");
        index++;
    }
}