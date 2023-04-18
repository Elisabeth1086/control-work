string[] newArray = new string[5];

void ArrayInput(string[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        newArray[i] = Console.ReadLine()!;
    }
}


string[] Array(string[] newArray)
{
    int n = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[i].Length <= 3)
        {
            n++;
        }
    }

    string[] Result = new string[n];

    int m = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[i].Length <= 3)
        {
            Result[m] = newArray[i];
            m++;
        }
    }
    return Result;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine("[" + string.Join(", ", array) + "]");
    }

}
ArrayInput(newArray);
System.Console.WriteLine();
PrintArray(Array(newArray));