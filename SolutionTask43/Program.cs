int k1;
int k2;
int b1;
int b2;
float X;
float Y;

Console.Clear();
Console.WriteLine("ЕwoStraightLines"); //Программа,, которая найдёт точку пересечения двух прямых, заданных уравнениями
Console.WriteLine("Welcome!");
Console.WriteLine("Для уравнений вида Y = kX + b ");

void Read() // метод для ввода значенй коэффициентов 
{
    Console.WriteLine("Введите k1:");
    k1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите b1:");
    b1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите k2:");
    k2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите b2:");
    b2 = int.Parse(Console.ReadLine());
}

void Calc() // метод, вычисляющий координаты точки пересечения
{

    X = (float)((float)(b2 - b1) / (float)(k1 - k2));
    Y = (float)(k1 * X) + (float)b1;
}

void Print() // метод выводящий координаты на экран
{
    Console.WriteLine("Координаты точки пересечения прямых: " + "( " + X + "; " + Y + " )");
}

Read();
Calc();
Print();
