Console.WriteLine("Введите 1 натуральное число больше 1:");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2 натуральное число больше 1:");
int number1 = int.Parse(Console.ReadLine());

void NumberCounter (int number,int number1)
{
    if (number > number1) return;
    if (number % 2 == 0)
    {
        Console.Write($"{number} "); 
        NumberCounter (number + 2,number1);
    }
    else 
    {
        number +=1;
        Console.Write($"{number} "); 
        NumberCounter (number + 2,number1);
    }

}

NumberCounter(number,number1);