// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int number = Prompt("Введите число  ");

int sumNumber(int A)
{
    int res = 0;
    while (A > 0)
    {
        res += A % 10;
        A = A / 10;
    }
    return res;
}

int result = sumNumber(number);
System.Console.WriteLine($"Сумма цифр числа {number} равна {result}");