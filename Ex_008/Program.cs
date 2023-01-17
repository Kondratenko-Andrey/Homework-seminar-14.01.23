//Удалить вторую цифру трёхзначного числа

Console.Write("Введите трёхзначное целое число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

while(number > 999 || (number < 100 && number > -100) || number < -999)
{
    Console.WriteLine("Число введено некорректно!");
    Console.Write("Повторно введите трёхзначное целое число: ");
    number = int.Parse(Console.ReadLine() ?? "0");
}

int number2 = (number % 10) + (number / 100) * 10;

Console.Write("При удалении второй цифры из введённого Вами трёхзнычного числа, получаем двухзначное число: " + number2);