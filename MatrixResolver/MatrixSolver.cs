using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixResolver
{
    public static class MatrixSolver
    {
        public static Matrix Multiply(this Matrix matrix, in Matrix targetMatrix)
        {
            if(matrix.ColumnsCount != targetMatrix.RowsCount)
            {
                throw new Exception("Amount of first matrix' columns is not equal to amount of second matrix' rows");
            }

            int[][] jaggedArray = new int[targetMatrix.RowsCount][];

            for (int matrixY = 0; matrixY < matrix.RowsCount; matrixY++)
            {
                int[] newArray = new int[targetMatrix.ColumnsCount];

                for (int targetX = 0; targetX < targetMatrix.ColumnsCount; targetX++)
                {
                    int number = 0;

                    for (int x = 0; x < matrix.ColumnsCount; x++)
                    {
                        number += matrix.MatrixValue[matrixY][x] * targetMatrix.MatrixValue[x][targetX];
                    }

                    newArray[targetX] = number;
                }

                jaggedArray[matrixY] = newArray;
            }

            return new Matrix(jaggedArray);
        }
    }
}
