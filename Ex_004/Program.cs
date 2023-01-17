// Показать четные числа от 1 до N

Console.Write("Введите любое  положительное число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

while(number <= 0)
{
    Console.WriteLine("Неккоректно введено число.");
    Console.Write("Повторно введите любое число, которое больше 0: ");
    number = int.Parse(Console.ReadLine() ?? "0");
}

if(number == 1)  
{
    Console.Write("Ну единица и единица... А я перечень чётных чисел хотел показать...");
}

else if(number == 2)  
{
    Console.Write("Ну хоть не единица, уже хорошо. Двойка - чётное число!");
}

else
{
    Console.WriteLine("Ниже представлен список чётных чисел в промежутке от 1, до введенного Вами числа (его не учитываем):");

    for(int i = 2; i < number; i++)
    {
        if(i % 2 == 0) Console.Write(i + " ");
    }
}