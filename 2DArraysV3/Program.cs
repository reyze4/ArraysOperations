string[,] MyArray = new string[2, 3];

for (int i = 0; i < MyArray.GetLength(0); i++)
{
    for (int j = 0; j < MyArray.GetLength(1); j++)
    {
        Console.WriteLine("x: " + i + ", " + "y: " + j);
        MyArray[i, j] = Console.ReadLine();
    }
}

Console.WriteLine();

for (int x = 0; x < MyArray.GetLength(0); x++)
{
    for (int y = 0; y < MyArray.GetLength(1); y++)
    {
        Console.Write(MyArray[x, y] + "\t");
    }
    Console.WriteLine();
}

Console.ReadLine();