Console.Write("Введите число: ");

int inputNumber = int.Parse(Console.ReadLine());
int t;
void VariantSimple()

{
    int sumOfNumbers = 0;
    for (int i = 1; i <= inputNumber; i++)
    {
        sumOfNumbers += i;
        // sumOfNumbers=sumOfNumbers+i;
    }
    Console.WriteLine("сумма чисел от 1 до " + inputNumber + " = " + sumOfNumbers);
}

void VariantGauss()
{
    int sumOfNumbers = 0;

    sumOfNumbers = ((1 + inputNumber) * inputNumber) / 2;
    Console.WriteLine("сумма чисел от 1 до " + inputNumber + " = " + sumOfNumbers);
}

t = Environment.TickCount;
VariantGauss();
Console.WriteLine("Gauss time : {0} ms", Environment.TickCount - t);
t = Environment.TickCount;
VariantSimple();
Console.WriteLine("Simple time : {0} ms", Environment.TickCount - t);