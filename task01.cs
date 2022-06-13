// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число ");
string numberString1 = Console.ReadLine();
Console.Write("Введите второе число ");
string numberString2 = Console.ReadLine();
int numberInt1 = int.Parse(numberString1);
int numberInt2 = int.Parse(numberString2);
int max = 0, min = 0;

if (numberInt1 > numberInt2) {
    max = numberInt1;
    min = numberInt2;
    Console.WriteLine("Первое число больше второго");
}

if (numberInt1 < numberInt2) {
    max = numberInt2;
    min = numberInt1;
    Console.WriteLine("Первое число меньше второго");
}

if (numberInt1 == numberInt2) {
    
    Console.WriteLine("Первое число равно второму");
}
