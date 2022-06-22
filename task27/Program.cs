// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите целое положительное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int modulo = n % 10;

while (n > 0)
{
    sum = sum + modulo;
    n = n / 10;
    modulo = n % 10;
}

Console.WriteLine("сумма цифр в числе = " + sum);