using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixResolver
{
    public class Matrix
    {
        private const int LOWER_LIMIT = -99;
        private const int HIGHER_LIMIT = 99;

        /// <summary>
        /// Matrix type is Jaggged array -> int[RowsCount][ColumnsCount] 
        /// Numbers in matrix cannot be higher than 99 and lower than -99
        /// </summary>
        private readonly int[][] _matrix;
        public int RowsCount { get; init; }
        public int ColumnsCount { get; init; }
        public int[][] MatrixValue
        {
            get => _matrix;
            init
            {
                _ = value ?? throw new Exception("Matrix cannot be null.");
                if (!(value is int[][])) throw new Exception("Matrix must be type int[][]");

                int[][] matrix = new int[RowsCount][];
                for (int y = 0; y < RowsCount; y++)
                {
                    matrix[y] = new int[ColumnsCount];
                    for (int x = 0; x < ColumnsCount; x++)
                    {
                        int number = (value as int[][])[y][x];
                        if (number > HIGHER_LIMIT || number < LOWER_LIMIT)
                        {
                            string message = (number > HIGHER_LIMIT) ? "higher than 99" : "lower than -99";
                            Console.WriteLine($"Number {number} is {message}.");
                            throw new Exception("Numbers in matrix cannot be less than -99 or higher than 99.");
                        }

                        matrix[y][x] = number;
                    }
                }

                _matrix = matrix;
            }
        }

        public Matrix(int[][] matrix)
        {
            _ = matrix ?? throw new Exception("Matrix cannot be null");

            RowsCount = matrix.Length;
            ColumnsCount = matrix[0].Length;
            MatrixValue = matrix;
        }
        public Matrix() : this(null) { }

        public void PrintMatrix()
        {
            const string VERTICAL_LINE = "|",
                         WHITE_SPACE = " ";
            for (int y = 0; y < RowsCount; y++)
            {
                string RepeatWhiteSpaces(int count) => String.Concat(Enumerable.Repeat<string>(WHITE_SPACE, count));

                Console.Write(VERTICAL_LINE + RepeatWhiteSpaces(1));

                for(int x = 0; x < ColumnsCount; x++)
                {
                    string numberString = _matrix[y][x].ToString();
                    string formattedString = RepeatWhiteSpaces(3 - numberString.Length) + _matrix[y][x].ToString();
                    
                    Console.Write($" {formattedString} ");
                }

                Console.WriteLine(RepeatWhiteSpaces(1) + VERTICAL_LINE);
            }
        }
    }
}
