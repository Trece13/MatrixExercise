using System;
using System.Collections.Generic;

namespace Matrix
{
    class Program
    {
        /// <summary>
        /// Title: Matriz exercise
        /// Developer: Juan Carlos Cubillos Granados
        /// </summary>
        /// 

        #region GlobalProperties
        private static int rowsNum = 0;
        private static int colsNum = 0;
        #endregion

        #region MainMethod
        static void Main(string[] args)
        {
            List<List<int>> Matrix = new List<List<int>>();
            List<int> row1 = new List<int>();
            List<int> row2 = new List<int>();
            List<int> row3 = new List<int>();
            //List<int> row4 = new List<int>();

            row1.Add(1);row1.Add(2);row1.Add(3);/*row1.Add(3);*/
            row2.Add(4);row2.Add(5);row2.Add(6);/*row2.Add(7);*/
            row3.Add(8);row3.Add(9);row3.Add(1);/*row3.Add(1);*/
            //row4.Add(5);row4.Add(3);row4.Add(4);row4.Add(1);

            Matrix.Add(row1);
            Matrix.Add(row2);
            Matrix.Add(row3);
            //Matrix.Add(row4);

            Console.WriteLine( " Difference with absolute value: " + DiagonalDifference(Matrix) );
            Console.ReadKey();
        }
        #endregion

        #region Methods
        public static int DiagonalDifference(List<List<int>> Matrix)
        {
            rowsNum = Matrix.Count;
            colsNum = Matrix[0].Count;

            int leftSum = 0;
            int RigthSum = 0;
            int diagonalDifference;
            
            PrintMAtrix(Matrix);
            SumDiagonals(ref leftSum, ref RigthSum,Matrix);
            Console.WriteLine(" Left diagonal: "+ leftSum );
            Console.WriteLine(" Right diagonal: " + RigthSum );

            diagonalDifference = Math.Abs(leftSum - RigthSum);
            return diagonalDifference;
        }
        private static void SumDiagonals(ref int leftSum, ref int RigthSum, List<List<int>> Matrix)
        {
            for (int row = 0, col = colsNum; row < rowsNum && col > 0; row++, col--)
            {
                leftSum += Matrix[row][row];
                RigthSum += Matrix[row][col - 1];
            }
        }
        private static void PrintMAtrix(List<List<int>> Matrix)
        {
            Console.WriteLine(" Matrix "+ rowsNum + "x" + colsNum);
            Console.Write(Environment.NewLine + Environment.NewLine);
            for (int i = 0; i < rowsNum; i++)
            {
                for (int j = 0; j < colsNum; j++)
                {
                    Console.Write(string.Format(" | {0} |", Matrix[i][j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }
        #endregion
    }
}
