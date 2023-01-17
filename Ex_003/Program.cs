// Выяснить является ли число чётным

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

if(number % 2 == 0) Console.Write("Введенное Вами число является чётным!");
else Console.Write("Введенное Вами число не является чётным!");
