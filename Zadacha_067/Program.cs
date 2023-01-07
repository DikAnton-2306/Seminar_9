// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Задача 69: Напишите программу, которая на вход принимает два числа А и В,
// и возводит число А в целую степень В с помощью рекурсии.
// А = 3; В = 5 -> 243
// А = 2; В = 3 -> 8

int EnterNumber(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SumNumbers (int number, int sum)
{
    if(number > 0)
    {
        sum += number%10;
        SumNumbers(number/10, sum);
    }
    else System.Console.WriteLine(sum);
    return sum;
}

int sum = 0;
int number = EnterNumber("Введите число");
sum = SumNumbers(number, sum);