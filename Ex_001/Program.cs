//По двум заданным числам проверять является ли первое квадратом второго

Console.Write("Введите первое число: ");
int num_1 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите второе число: ");
int num_2 = int.Parse(Console.ReadLine() ?? "0");

if(num_1 == num_2 * num_2)
{
    Console.WriteLine("Первое число является квадратом второго!");
}

else
{
    Console.WriteLine("Первое число не является квадратом второго!");
}

