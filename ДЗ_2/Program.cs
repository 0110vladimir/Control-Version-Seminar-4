/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

int number = Input("Введите число: ");
Console.WriteLine($"Сумма всех цифр числа {number} равна: {SumAllDigits(number)}");


int Input(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
} 

int SumAllDigits(int number)
{
    int result = 0;
    while(number>0)
    {
        result = result+number%10;
        number=number/10;
    }
    return result;
}