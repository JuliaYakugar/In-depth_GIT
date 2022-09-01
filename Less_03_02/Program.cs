int[] A = { 3, 6, 8 };
int[] B = { 2, 1, -7 };
// int[] A = { 7, -5, 0 };
// int[] B = { 1, -1, 9 };

double Distance(int[] a, int[] b)
{
    return Math.Sqrt(Math.Pow((a[0] - b[0]), 2) + Math.Pow((a[1] - b[1]), 2) + Math.Pow((a[2] - b[2]), 2));
}
Console.Write(Distance(A, B));