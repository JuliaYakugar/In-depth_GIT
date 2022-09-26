int[,] Matrix()
{
    int[,] array = new int[2,2];
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            array[i, j] = new Random().Next(10);
        }
    }
    return array;
}

void MatrixConsole(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrixA = Matrix();
int[,] matrixB = Matrix();

MatrixConsole(matrixA);
MatrixConsole(matrixB);

int[,] Pro(int[,] arr1, int[,] arr2)
{
    int[,] arrNew = new int[2,2];
    arrNew[0, 0] = (arr1[0,0] * arr2[0,0]) + (arr1[0,1] * arr2[1,0]);
    arrNew[0, 1] = (arr1[0,0] * arr2[0,1]) + (arr1[0,1] * arr2[1,1]);
    arrNew[1, 0] = (arr1[1,0] * arr2[0,0]) + (arr1[1,1] * arr2[1,0]);
    arrNew[1, 1] = (arr1[1,0] * arr2[0,1]) + (arr1[1,1] * arr2[1,1]);
    return arrNew;
}

MatrixConsole(Pro(matrixA, matrixB));