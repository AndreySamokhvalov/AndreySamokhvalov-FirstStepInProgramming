string? inputLkneOne = Console.ReadLine();

if(inputLkneOne != null)
{

    int inputNumber = int.Parse(inputLkneOne);

    int startNumber = (inputNumber * -1);

    string lineOutput = "";

    while (startNumber < inputNumber)
    {
        lineOutput = lineOutput + startNumber+",";
        startNumber++;

    }
     lineOutput = lineOutput + inputNumber;
     Console.WriteLine(lineOutput);


}
