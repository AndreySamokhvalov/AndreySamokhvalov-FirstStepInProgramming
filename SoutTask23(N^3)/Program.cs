Console.Clear();
Console.WriteLine("N^3"); //Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Welcome!");
Console.WriteLine("Enter your number");
string? inputLineN = Console.ReadLine();

if(inputLineN != null)
{
    int numberN = int.Parse(inputLineN);
    int outNumber = (int)Math.Pow(numberN,2);
    string lineN = "";
    string lineNNN = "";
    int start = 1;

while (start<numberN)
{
   lineN=lineN+start+", ";
   lineNNN=lineNNN+(start*start*start)+", ";
   start++;
}
    Console.WriteLine((lineN) +start );
    Console.WriteLine((lineNNN) + Math.Pow(start,3));
}
