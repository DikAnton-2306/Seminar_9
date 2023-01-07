// Задача 69: Напишите программу, которая на вход принимает два числа А и В,
// и возводит число А в целую степень В с помощью рекурсии.
// А = 3; В = 5 -> 243
// А = 2; В = 3 -> 8

int SumNumbers (int A, int B, int sum)
{
    for (int i = 2; i <= B; i++)
    {
        sum *= A;
    }
    return sum;
}

// 1. Метод спрашивает пользователя ввести число
int EnterNumber(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

// 1. Пользователь вводит число
int A = EnterNumber("Введите число А: ");
int B = EnterNumber("Введите число В: ");

int sum = A;
sum = SumNumbers(A, B, sum);
System.Console.WriteLine($"Число {A} в степени {B} равно {sum}");