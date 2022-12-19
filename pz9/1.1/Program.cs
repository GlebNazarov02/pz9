Console.WriteLine("Введите 1 натуральное число больше 1:");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2 натуральное число больше 1:");
int number1 = int.Parse(Console.ReadLine());

void NumberCounter (int number,int number1)
{
    if (number1 + 1 < number) Console.Write("нет");
    if (number == number1+1) return;
    Console.Write($"{number} "); 
    NumberCounter (number + 1,number1);
}

NumberCounter(number,number1);