using System;
using System.Collections.Generic;

namespace _2laboop
{
    public class MatrixHelper
    {
        public int[,] Matrix { get; private set; }
        private int rows, cols;

        public MatrixHelper(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            Matrix = new int[rows, cols];
        }

        public void FillRandom(int min, int max)
        {
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    Matrix[i, j] = rand.Next(min, max + 1);
        }

        public int SumRowsWithNegative()
        {
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                bool hasNegative = false;
                for (int j = 0; j < cols; j++)
                {
                    if (Matrix[i, j] < 0)
                    {
                        hasNegative = true;
                        break;
                    }
                }

                if (hasNegative)
                {
                    for (int j = 0; j < cols; j++)
                        sum += Matrix[i, j];
                }
            }
            return sum;
        }

        public List<(int row, int col)> GetSaddlePoints()
        {
            var result = new List<(int row, int col)>();

            for (int i = 0; i < rows; i++)
            {
                int minInRow = Matrix[i, 0];
                int colIndex = 0;
                for (int j = 1; j < cols; j++)
                {
                    if (Matrix[i, j] < minInRow)
                    {
                        minInRow = Matrix[i, j];
                        colIndex = j;
                    }
                }

                bool isSaddle = true;
                for (int k = 0; k < rows; k++)
                {
                    if (Matrix[k, colIndex] > minInRow)
                    {
                        isSaddle = false;
                        break;
                    }
                }

                if (isSaddle)
                    result.Add((i, colIndex));
            }

            return result;
        }
    }
}

