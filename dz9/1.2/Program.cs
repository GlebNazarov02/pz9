Console.WriteLine("Введите 1 натуральное число больше 1:");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2 натуральное число больше 1:");
int number1 = int.Parse(Console.ReadLine());

int SumNumbers(int M, int N)
{   
    if ((M <=0) || (N<=0) || (M>N))  return 0;
    if (M == 0) return (N * (N + 1)) / 2;            
    else if (M == N) return M;                       
    else return N + SumNumbers(M, N - 1); 
}

Console.WriteLine($"{SumNumbers(number, number1)}");