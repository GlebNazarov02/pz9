Console.WriteLine("Введите 1 натуральное число больше 1:");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2 натуральное число больше 1:");
int number1 = int.Parse(Console.ReadLine());

int Sum(int num,int num1)
    {
        int first = num;
        if (num1 == 0 ) return 1;
        return Sum(num,num1-1)*num;
    }
Console.WriteLine(Sum(number,number1));