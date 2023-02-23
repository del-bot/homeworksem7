double [,] CreateArray()
{
    Console.Write("input count of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input count of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("input min possible value: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("input max possible value: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());
    double [,] cratedArray = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            cratedArray[i,j] = Math.Round((new Random().Next(minVal, maxVal+1))+ (new Random().NextDouble()), 2);
        }
    }
    return cratedArray;
}

void ShowArray (double [,] array)
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

double [,] newArraay = CreateArray();
ShowArray(newArraay);
