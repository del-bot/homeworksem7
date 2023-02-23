double [,] CreateArray(int rows, int columns, int minV, int maxV)
{
    double [,] cratedArray = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            cratedArray[i,j] = new Random().Next(minV,maxV+1);
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

double [,]  FindAverage(double [,] array)
{
    //double SumCol = 0;
    //double findAv = 0;
    for (int j =0; j < array.GetLength(1); j++)
    {
        double SumCol = 0;
        double findAv = 0;
        for(int i =0; i < array.GetLength(0); i++)
        {
            SumCol = SumCol + array[i,j];
            //findAv = Math.Round(SumCol / array.GetLength(0), 2);
            
        }
        findAv = Math.Round(SumCol / array.GetLength(0), 2);
        Console.WriteLine(findAv);
    }
    
    return array;
} 

Console.Write("input count of rows: ");
int Urows = Convert.ToInt32(Console.ReadLine());
Console.Write("input count of columns: ");
int Ucolumns = Convert.ToInt32(Console.ReadLine());
Console.Write("input min possible value: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write("input max possible value: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

double [,] newArraay = CreateArray(Urows, Ucolumns, minVal, maxVal);
ShowArray(newArraay);
FindAverage(newArraay);

