// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int a = number/10;
// int b = a%10;

// Console.WriteLine("Вторая цифра трехзначного числа: "+b);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int N = number;

int index = 0;
while (N != 0)
{
        N = N/10;
        index++;
}

if (index >= 3)
{
    int a = (number/Convert.ToInt32(Math.Pow(10, (index - 3))))%10;
    Console.WriteLine(a);
}
else
{
    Console.WriteLine("третьей цифры нет");
}