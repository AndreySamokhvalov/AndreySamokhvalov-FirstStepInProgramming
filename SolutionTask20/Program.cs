int coordXPointA;
int coordYPointA;
int coordXPointB;
int coordYPointB;
double lengthAB;

// считывает координы точек А и В
void readDataOfPoint()
{
    Console.WriteLine("Введи координату х точки А");
    coordXPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введи координату y точки А");
    coordYPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введи координату х точки B");
    coordXPointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введи координату y точки B");
    coordYPointB = int.Parse(Console.ReadLine());
}

// вычисляет расстояние между двумя точками А и В
void conculateLengthAB()
{
    lengthAB = Math.Sqrt(Math.Pow((coordXPointA - coordXPointB), 2) + Math.Pow((coordYPointA - coordYPointB), 2));
}

readDataOfPoint();

conculateLengthAB();

Console.WriteLine(lengthAB);