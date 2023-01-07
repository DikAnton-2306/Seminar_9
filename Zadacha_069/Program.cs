// Задача 69: Напишите программу, которая на вход принимает два числа А и В,
// и возводит число А в целую степень В с помощью рекурсии.
// А = 3; В = 5 -> 243
// А = 2; В = 3 -> 8

Console.Clear();

int SumNumbers(int A, int B)
{
    if (B <= 0) return 1;
    return SumNumbers(A, --B)*A;
}

int EnterNumber(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int A = EnterNumber("Введите число А: ");
int B = EnterNumber("Введите число В: ");

int sum = SumNumbers(A, B);
System.Console.WriteLine($"Число {A} в степени {B} равно {sum}");