//Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.Write("Введите первое число для проверки кратно ли оно второму: ");
int num_1 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите второе число для проверки кратности ему первого: ");
int num_2 = int.Parse(Console.ReadLine() ?? "0");

if(num_1 % num_2 == 0) Console.Write("Ур!! Первое число кратно второму!");
else Console.Write("К сожалению первое число не кратно второму, остаток при делении равен: " + (num_1 % num_2));


