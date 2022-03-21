using System;

namespace MatrixResolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 3;
            int columns = 3;
            Matrix matrix;
            MatrixGenerator.GenerateRandomMatrix(rows, columns, out matrix);

            matrix.PrintMatrix();
        }
    }
}
