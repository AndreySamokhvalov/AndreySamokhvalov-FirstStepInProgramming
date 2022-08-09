int a;
int inputData;
int b = 0;

Console.Clear();
Console.WriteLine("abc=a+b+c"); //Программа,  которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите A");
inputData = int.Parse(Console.ReadLine());
a = inputData;

int Conculate()  // метод вычисляющий сумму цифр в числе
{
    while (a > 0)
    {
        b = b + a % 10;
        a = a / 10;
    }
    return b;
}

void Print(int b) // метод выводящий значение на экран
{
    Console.Write("Cумма цифр в числе " + inputData + " = ");
    Console.WriteLine(b);
}

Conculate();
Print(Conculate()); //метод вызывающий метод Conculate() и передающий его результат в метод Print()