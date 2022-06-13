// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число ");
string numberString1 = Console.ReadLine();
Console.Write("Введите второе число ");
string numberString2 = Console.ReadLine();
Console.Write("Введите третье число ");
string numberString3 = Console.ReadLine();
int numberInt1 = int.Parse(numberString1);
int numberInt2 = int.Parse(numberString2);
int numberInt3 = int.Parse(numberString3);
int max = numberInt1;

if (max < numberInt2) 
{
    max = numberInt2;
}

if (max < numberInt3) 
{
    max = numberInt3;
}

Console.WriteLine("максимальное число " + max);

