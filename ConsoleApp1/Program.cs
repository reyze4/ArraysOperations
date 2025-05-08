int[] MyArray = { 1, 2, 45, 32, 89, 34, 90};

//Console.WriteLine(MyArray[^1]);

//int[] MyArray2 = MyArray[1..4];

//int[] MyArray2 = MyArray[..4];

//int[] MyArray2 = MyArray[3..];

//Index MyIndex = new Index(3, true); //^3

//Console.WriteLine(MyArray[MyIndex]);

//Console.WriteLine($"value {MyIndex.Value} isFromEnd {MyIndex.IsFromEnd}");

//Range MyRange =new Range(1,4); //1..4 

//Range MyRange2 = ^4..^1;

//int[] MyArray2 = MyArray[MyRange2];

//string src = "hello pidr";

//Console.WriteLine(src[^4..]);

foreach (int item in MyArray[..4])
    Console.Write($"{item} ");

Console.WriteLine("\n");

foreach (var item in MyArray[^4..])
    Console.Write($"{item} ");

Console.WriteLine("\n");

foreach (var item in MyArray[^4..^1])
    Console.Write($"{item} ");

Console.ReadLine();
