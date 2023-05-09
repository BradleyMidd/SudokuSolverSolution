using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver.Workers
{
    class SudokuBoardStateManager
    {
        public string GenerateState(int[,] sudokuBoard) 
        { 
            StringBuilder key = new StringBuilder();

            // Loop through the first dimension of the 2d array
            for (int row = 0; row < sudokuBoard.GetLength(0); row++)
            {

                // Loop through the second dimension of the 2d array
                for (int col = 0; col < sudokuBoard.GetLength(1); col++)
                {
                    key.Append(sudokuBoard[row, col]);
                }

            }

            return key.ToString();
        }

        public bool IsSolved(int[,] sudokuBoard) 
        {
            // Loop through the first dimension of the 2d array
            for (int row = 0; row < sudokuBoard.GetLength(0); row++)
            {

                // Loop through the second dimension of the 2d array
                for (int col = 0; col < sudokuBoard.GetLength(1); col++)
                {
                    if (sudokuBoard[row, col] == 0 || sudokuBoard[row, col].ToString().Length > 1)
                    {
                        return false;
                    }
                }

            }
            return true;
        }
    }
}
