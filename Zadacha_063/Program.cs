// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


// int EnterNumber(string message)
// {
//     System.Console.WriteLine(message);
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }

// void NumberPlus(int num, int count)
// {
//     if (count <= num)
//     {
//         System.Console.Write(count + ", ");
//         count++;
//         NumberPlus(num, count);
//     }
// }
// int count = 1;
// int number = EnterNumber("Введите число");
// NumberPlus(number, count);




int EnterNumber(string message)
{
    System.Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

string NumberPlus(int n)
{
    if (n == 1) return "1";
    return NumberPlus(n-1) + "::" + n;
}

int number = EnterNumber("Введите натуральное число");
System.Console.WriteLine(NumberPlus(number));