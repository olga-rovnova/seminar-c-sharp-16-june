//Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

//Console.WriteLine("Введите целое число A: ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите целое положительное число B: ");
//int b = Convert.ToInt32(Console.ReadLine());

int Input(string output) 
{ 
    Console.Write(output);     
    return Convert.ToInt32(Console.ReadLine());
}

int a = Input("Введите целое число A: ");
int b = Input("Введите целое положительное число B: ");
int result = 1;

for (int i = 0; i < b; i++)
{
    result = result * a;
}
Console.WriteLine($"результат = {result}");
