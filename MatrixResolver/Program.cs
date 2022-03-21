using System;

namespace MatrixResolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 3;
            int columns = 3;
            int[][] array;
            MatrixGenerator.GenerateRandomJaggedArray(rows, columns, out array);

            Matrix matrix = new Matrix(array);
            matrix.PrintMatrix();
        }
    }
}
