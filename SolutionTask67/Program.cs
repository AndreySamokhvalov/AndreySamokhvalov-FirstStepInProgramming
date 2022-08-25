Console.Clear();
int num = ReadData("Задайте число: ");

Console.WriteLine(Sum(num));

//метод считывания данных от пользователя
int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine());
}

// медот для нахождения суммы цифр в числе
int Sum(int number)
{
    if(number>0)
    {
        return number%10+Sum(number/10);
    }
    else
    {
        return 0;
    }
}