// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// нет  -> 8, 9

Console.WriteLine("Ведите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2)
{
    Console.WriteLine("Первое число является квадратом второго.");
}
else if (number2 == number1 * number1)
{
    Console.WriteLine("Второе число является квадратом первого.");
}
//if (input1*input1 == input2 || input2*input2 == input1) можно короче
else
{
    Console.WriteLine("Одно число не является квадратом другого.");
}
