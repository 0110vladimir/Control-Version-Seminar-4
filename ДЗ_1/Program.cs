/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (Задачи, решенные через Math.Pow, не будут считаться правильными, так как задача стоит в том, чтобы написать цикл)

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int A = Input("Задайте основание: ");
int B = ValidateInput();
Console.WriteLine($"Число {A} в степени {B} равно {Power(A,B)}");

int Input(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
} 

int ValidateInput() 
{
    int result = -1;
    while (result<0)
    {
        result = Input("Задайте степень: ");
        if(result<0) Console.WriteLine("Показатель степени должен не быть меньше 0"); 
    }
    return result;
}

int Power(int PowerBase, int exponent)
{
    int power = 1;
    for (int i = 0; i < exponent; i++)
    {
        power = power*PowerBase;
    }

    return power;
}


