int A;
int B;
int i = 0;
int C = 1;
double outData;


Console.Clear();
    Console.WriteLine("A^B"); //Программа,  которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


void Read() // Метод для читывания чисел А и В 
{
    
    Console.WriteLine("Welcome!");
    Console.WriteLine("Введите A");
    A = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите B");
    B = int.Parse(Console.ReadLine());
}

double Conculate1() // Метод возвращающий А в степени В
{
    return Math.Pow(A, B);

}

void Print(double outData)
{
    Console.Write("Exp(B*ln(A))= ");
    Console.WriteLine(outData);
}

void Conculate2() // Метод вычисляющий А в степени В с помощью цикла
{
    while (i < B)
    {
        C = C * A;
        i++;
    }
    Console.Write("`А` в степени `В` равно ");
    Console.WriteLine(C);
}

Read();
Conculate1();
Print(Conculate1()); // метод вызывающий метод Conculate1() и передающий его результат в метод Print()
Conculate2();