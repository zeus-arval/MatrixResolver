using System;

namespace MatrixResolver
{
    class Program
    {
        static void Main(string[] args)
        {
            const int rows = 3;
            const int columns = 3;
            //Matrix matrix;
            //MatrixGenerator.GenerateRandomMatrix(rows, columns, out matrix);

            Matrix matrix = new(new int[3][]{
                new int[]{ 5, 8, -4},
                new int[]{ 6, 9, -5},
                new int[]{ 4, 7, -3}
            });

            Matrix target = new(new int[3][]{
                new int[]{ 3, 2, 5},
                new int[]{ 4, -1, 3},
                new int[]{ 9, 6, 5}
            });

            //Matrix matrix = new(new int[rows][]{
            //    new int[]{ 5, 8, -4 },
            //    new int[]{ 6, 9, -5 },
            //    new int[]{ 4, 7, -3 }
            //});

            //Matrix target = new(new int[columns][]{
            //    new int[]{ 2 },
            //    new int[]{ -3 },
            //    new int[]{ 1 },
            //});

            matrix.PrintMatrix();
            Console.WriteLine();
            target.PrintMatrix();
            Console.WriteLine();

            Matrix result = MatrixSolver.Multiply(matrix, target);

            result.PrintMatrix();
        }
    }
}
