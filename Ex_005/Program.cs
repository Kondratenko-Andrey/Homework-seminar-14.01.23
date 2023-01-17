// Показать последнюю цифру трёхзначного числа

Console.Write("Введите трёхзначное целое число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

while(number > 999 || (number < 100 && number > -100) || number < -999)
{
    Console.WriteLine("Число введено некорректно!");
    Console.Write("Повторно введите трёхзначное целое число: ");
    number = int.Parse(Console.ReadLine() ?? "0");
}

int endOfNum = number % 10;

if(endOfNum < 0) endOfNum = -endOfNum;

Console.Write("Последняя цифра введённого Вами трёхзначного числа равна " + endOfNum);

