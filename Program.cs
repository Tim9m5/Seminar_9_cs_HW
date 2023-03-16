// Задача 64.
/*
Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

string PrintNumbers (int start, int end)
{
    if (start == end) return start.ToString();
    return (start + "," + PrintNumbers(start + 1, end));
}
Console.WriteLine(PrintNumbers(M, N));
*/

// Задача 66.
/*
Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int GetSum(int start, int end)
{
    if (start == end) return start;

    return (start + GetSum(start + 1, end));
}
Console.WriteLine(GetSum(M, N));
*/

// Задача 68.
/*
Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int FunctionAkk(int M, int N)
{
    if (M == 0) return N +1;
    if (M != 0 && N==0) return FunctionAkk(M-1,1);
    if (M > 0 && N > 0) return FunctionAkk(M-1, FunctionAkk(M,N-1));

    return FunctionAkk(M,N);
}
Console.WriteLine($"Результат: {FunctionAkk(M, N)}");
*/