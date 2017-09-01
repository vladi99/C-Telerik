namespace Matrix
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            // First Matrix 
            int row = 5, col = 5;
            var matrixOne = new Matrix<int>(row, col);
            int i = 0, j = 0;
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    matrixOne[r, c] = i++;
                }
            }

            Console.WriteLine("Matrix One:");
            Console.WriteLine(matrixOne.ToString());

            // Second Matrix
            row = 5; col = 5;
            var matrixTwo = new Matrix<int>(row, col);
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    matrixTwo[r, c] = j;
                    j += 2;
                }
            }
        }
    }
}
