//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
//вторую цифру этого числа.
//456 -> 5

int ReadInt (string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32 (Console.ReadLine());
    return value;
}
bool Validate3sing (int number)
{
    if (number >= 100 && number < 1000)
    {
        return true;
    }

    System.Console.WriteLine("число не трёхзначное");
    return  false;
}

int num  = ReadInt("Введите число >> ");
if (Validate3sing(num))
{
    int secondNum = (num / 10) % 10;
    System.Console.WriteLine($"Второй цифрой числа {num} является {secondNum}");
}