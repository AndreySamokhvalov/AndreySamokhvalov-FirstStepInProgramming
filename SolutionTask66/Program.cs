
// Программа, принимающая на вход два числа
// и выдающая сумму между ними
Console.Clear();
Console.WriteLine("RecSum");
Console.WriteLine("Welcome!");
int sum = 0;
int numM = ReadData("задайте число М: ");
int numN = ReadData("задайте число N: ");
Console.WriteLine();


if (numM < numN)
{
    SumNaturalNumbersPrint(numM, numN);
}
else
{
    SumNaturalNumbersPrint(numN, numM);
}

// метод получения данных от пользователя
int ReadData(string data)
{
    Console.WriteLine();
    Console.WriteLine(data);
    return int.Parse(Console.ReadLine());
}

// метод подсчета суммы
int SumNaturalNumbersPrint(int m, int n)
{
    if (m - 1 == n) return m;
    Console.Write(m + " ");
    sum = sum + m;
    SumNaturalNumbersPrint(m + 1, n);
    return sum;
}

// простой метод для печати
void PrintSum(int recSum)
{
    Console.WriteLine();
    Console.WriteLine("Cумма чисел между " + numM + " и " + numN + " = " + sum);
}

PrintSum(sum);