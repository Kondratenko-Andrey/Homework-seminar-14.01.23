//Найти третью цифру числа или сообщить, что её нет

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if(number < 100 && number > -100)
{
    Console.Write("У введённого Вами числа менее трёх цифр.");
}
else 
{
    if(number < 0) number = -number;
    
    while(number > 999)
    {
        number = number / 10;
    }

    Console.Write("Третья цифра введённого Вами числа равна: " + (number % 10));

}

