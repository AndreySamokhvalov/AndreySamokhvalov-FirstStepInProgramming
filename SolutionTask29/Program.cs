System.Random numberSintezator = new Random();

void VariantNaive()
{
int i = 0; 
Console.Write("[");
while(i<8-1)
{
    Console.Write(numberSintezator.Next(-100,101)+",");
    i++;
}
Console.Write(numberSintezator.Next(-100,101));
Console.Write("]");
}

VariantNaive();
