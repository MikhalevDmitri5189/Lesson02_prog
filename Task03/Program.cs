//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите цифру дня недели.");
int num = int.Parse(Console.ReadLine());
if (num <= 7 && num >= 1)
{
    if (num == 6)
    {
        Console.WriteLine("Выходной.");

    }
    if (num == 7)
    {
        Console.WriteLine("Воскресенье Выходной.");

    }
    else
    {
        Console.WriteLine("Рабочий день.");
    }
}
else
{
    Console.WriteLine("ERROR!!!.");
}