// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int a = 0;
if (int.TryParse(Console.ReadLine(), out a))
{
    if (a > 999 || a < 100)
    {
        Console.WriteLine("Не трехзначное число");
        return;
    }
    int GetSecond(int a)
    {
        a /= 10; int d = a % 10;
        return d;
    }
    Console.WriteLine(GetSecond(a));
}
else
{
    Console.WriteLine("Это не цифра.");
}