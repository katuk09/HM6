// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
/*
int InputNumber(int amount)
{
    int count = 0;
    for (int i = 0; i < amount; i++)
        {
            Console.WriteLine($"Please inpunt {amount - i} numbers:");
            double num = Convert.ToInt32(Console.ReadLine());
            if (num > 0) positive = positive + 1;
        }
        return positive;
}

Console.Write("How many numbers will you input? ");
int howmany = Convert.ToInt32(Console.ReadLine());
Console.Write($"You have input {InputNumber(howmany)} positive numbers.");
*/
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
void Coordinates(double[] kb)
{
    double x = (-kb[1] + kb[3]) / (kb[0] - kb[2]);
    Console.WriteLine($"     {-kb[1]} + {kb[3]}");
    Console.WriteLine($"x = ----------------");
    Console.WriteLine($"     {kb[0]} - {kb[2]}");
    double y = kb[0] * x + kb[1];
    Console.WriteLine($"y = {kb[0]} * x + {kb[1]}");
    Console.WriteLine();    
    Console.Write($"The coordinates of X and Y are ({x};  {y}) respectively.");
}

Console.Write("Please find coordinates of X and Y (y = k1 * x + b1, y = k2 * x + b2):");
Console.WriteLine();
double[] arrayKB = new double[4];
Console.Write("Please input k1:");
arrayKB[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input b1:");
arrayKB[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input k2:");
arrayKB[2] = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input b2:");
arrayKB[3] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Coordinates(arrayKB);

*/