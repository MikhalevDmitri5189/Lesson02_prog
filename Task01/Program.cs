// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Main();

void Main()
{
    bool Work = true;
    while (Work)
    {
        System.Console.WriteLine("Решаем задачу? Введите y/n.");
        string a = Console.ReadLine();
        switch (a)
        {
            case "y": Osn(); break;
            case "n": Work = false; break;
        }
    }
}

void Osn()
{
    Console.WriteLine("Введите трехзначное число");
    int.TryParse(Console.ReadLine(), out int a);
    // Вводим трехзначное число если число будет больше 999 или меньше 100 появится сообщение "Не трехзначное число"
    // Если тпехзначное то производится действия.
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