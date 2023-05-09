using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver.Workers
{
    class SudokuBoardDisplayer
    {
        public void Display(string title, int[,] sudokuBoard) 
        {
            if (!title.Equals(string.Empty)) Console.WriteLine("{0} {1}", title, Environment.NewLine);

            // Loop through the first dimension of the 2d array
            for (int row = 0; row < sudokuBoard.GetLength(0); row++)
            {
                // Add a pipeline
                Console.Write("|");

                // Loop through the second dimension of the 2d array
                for (int col = 0; col < sudokuBoard.GetLength(1); col++)
                {
                    // Print the element and the pipeline
                    Console.Write("{0} {1}", sudokuBoard[row, col], "|");
                }
                // Break line
                Console.WriteLine();
            }
            // Break line
            Console.WriteLine();
        }
    }
}
