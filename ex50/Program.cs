int [,] CreateArray()
{
    Console.Write("input count of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input count of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("input min possible value: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("input max possible value: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());
    int [,] cratedArray = new int[rows, columns];
    Console.WriteLine("input number of search rows: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input number of search columns: ");
    int m = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            cratedArray[i,j] = new Random().Next(minVal,maxVal+1);
        }
    }
    if (n-1 > rows || m-1 > columns)
    {
        Console.WriteLine("not find");
    }
    else Console.WriteLine(cratedArray[n-1,m-1]);

    return cratedArray;
}

void ShowArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int [,] newArraay = CreateArray();
ShowArray(newArraay);
