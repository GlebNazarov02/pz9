Console.WriteLine("Введите 1 натуральное число больше 1:");
int number = int.Parse(Console.ReadLine());

int Sum(int num)
    {
        if (num < 10) return num;
        else return num % 10 + Sum(num / 10);
    }
Console.WriteLine(Sum(number));