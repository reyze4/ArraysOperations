int[,] MyArray =
{
    { 4, 5 ,6 },
    { 7, 8 ,9 },
    { 10 ,11 ,12 }
   
};

int height = MyArray.GetLength(0);
int width  = MyArray.GetLength(1);

for (int x = 0; x < height; x++)
{
    for (int y = 0; y < width; y++)
    {
        Console.Write(MyArray[x ,y] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();

int[,] MyArray2 = new int[10, 6];

Random random = new Random();

for (int i = 0; i < MyArray2.GetLength(0); i++)
{
    for (int j = 0; j < MyArray2.GetLength(1); j++)
    {
        MyArray2[i,j] = random.Next(10,100);
    }
}

for (int x = 0; x < MyArray2.GetLength(0); x++)
{
    for (int y = 0; y < MyArray2.GetLength(1); y++)
    {
        Console.Write(MyArray2[x, y] + "\t");
    }
    Console.WriteLine();
}
