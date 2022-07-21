int coordXPointA;
int coordYPointA;
int coordZPointA;
int coordXPointB;
int coordYPointB;
int coordZPointB;
double lengthAB;

// считывает координы точек А и В
void readDataOfPoint()
{
    Console.Clear();
    Console.WriteLine("Leght3D"); //Программа,  которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
    Console.WriteLine("Welcome!");
    Console.WriteLine("Введи координату х точки А");
    coordXPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введи координату y точки А");
    coordYPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введи координату z точки А");
    coordZPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введи координату х точки B");
    coordXPointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введи координату y точки B");
    coordYPointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введи координату z точки B");
    coordZPointB = int.Parse(Console.ReadLine());
}

// вычисляет расстояние между двумя точками А и В
void conculateLengthAB()
{
    lengthAB = Math.Sqrt(Math.Pow((coordXPointA - coordXPointB), 2) + Math.Pow((coordYPointA - coordYPointB), 2) + Math.Pow((coordZPointA - coordZPointB), 2));
}

readDataOfPoint();

conculateLengthAB();

Console.WriteLine(lengthAB);


