using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixResolver
{
    /// <summary>
    /// Class for generating matrices
    /// </summary>
    public static class MatrixGenerator
    {
        /// <summary>
        /// Generates a matrix with jagged array of random numbers
        /// </summary>
        /// <param name="matrix">Matrix</param>
        /// <param name="rows">Rows count. Must be more than 0.</param>
        /// <param name="columns">Rows count. Must be more than 0.</param>
        public static void GenerateRandomMatrix(in int rows, in int columns, out Matrix matrix)
        {
            if (rows <= 0 || columns <= 0)
            {
                throw new Exception("Rows' and Columns' count must be positive and more than zero");
            }
            int[][] jaggedArray;
            GenerateRandomJaggedArray(rows, columns, out jaggedArray);

            matrix = new(jaggedArray);
        }
        /// <summary>
        /// Generates jagged Array with type int[columns][rows]
        /// </summary>
        /// <param name="rows">Amount of rows in array</param>
        /// <param name="columns">Amount of columns in array</param>
        /// <param name="jaggedArray">Array with a similar amount of elements in rows</param>
        public static void GenerateRandomJaggedArray(int rows, int columns, out int[][] jaggedArray)
        {
            Random rand = new Random();
            jaggedArray = new int[rows][];

            for (int y = 0; y < rows; y++)
            {
                jaggedArray[y] = new int[columns];
                for (int x = 0; x < columns; x++)
                {
                    jaggedArray[y][x] = rand.Next(-99, 99);
                }
            }
        }
    }
}
