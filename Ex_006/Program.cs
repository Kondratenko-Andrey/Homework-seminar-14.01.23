// Показать вторую цифру трёхзначного числа

Console.Write("Введите трёхзначное целое число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

while(number > 999 || (number < 100 && number > -100) || number < -999)
{
    Console.WriteLine("Число введено некорректно!");
    Console.Write("Повторно введите трёхзначное целое число: ");
    number = int.Parse(Console.ReadLine() ?? "0");
}

int secNum = (number / 10) % 10;

if(secNum < 0) secNum = -secNum;

Console.Write("Вторая цифра введённого Вами трёхзначного числа равна " + secNum);
