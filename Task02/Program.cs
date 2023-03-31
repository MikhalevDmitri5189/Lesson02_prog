// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645-> 5
// 78->третьей цифры нет
// 32679Main();



Console.WriteLine("Напишите число;");
int a = 0;
if (int.TryParse(Console.ReadLine(), out a))
{
    int ThirdDigit(int a)
    {
        while (a > 999)
        {
            a /= 10;
        }
        return a % 10;
    }
    bool Numb(int a)
    {
        if (a < 100)
        {
            Console.WriteLine("Третьей цыфры нет");
            return false;
        }
        return true;
    }
    if (Numb(a))
    {
        Console.WriteLine(ThirdDigit(a));
    }
}
else
{
    Console.WriteLine("Это не цифра.");
}
























