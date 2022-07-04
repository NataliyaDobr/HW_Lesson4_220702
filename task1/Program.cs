// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int numberA = Prompt("Введите число A ");
int numberB = Prompt("Введите число B ");

int degreeNumb(int A, int B)
{ int dNum = 1;
    for (int i = 1; i <= B; i++)
    {
        dNum = dNum * A;
    }
    return dNum;
}

int result = degreeNumb(numberA,numberB);
System.Console.WriteLine(result);