// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.Write("Введите целое число от 10 до 99 включительно: ");
int number =int.Parse(Console.ReadLine() ?? "0");

while(number > 99 || number < 10)
{
    Console.WriteLine("Число введено некорректно!");
    Console.Write("Повторно введите целое число от 10 до 99 включительно: ");
    number = int.Parse(Console.ReadLine() ?? "0");
}

int firstNum = number / 10;
int secondNum = number % 10;

if(firstNum > secondNum) Console.Write("Наибольшая цифра введённого Вами числа: " + firstNum);
else if(firstNum < secondNum) Console.Write("Наибольшая цифра введённого Вами числа: " + secondNum);
else Console.Write("Введённое Вами число состоит из двух одинаковых цифр: " + firstNum);

