using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver.Workers
{
    class SudokuFileReader
    {
        public int[,] ReadFile(string filename)
        {
            int[,] sudokuBoard = new int[9, 9];

            try
            {
                // Read all the sudoku lines
                var sudokuBoardLines = File.ReadAllLines(filename);

                // Initiate the row
                int row = 0;

                // Loop through the sudoku lines
                foreach (var sudokuBoardLine in sudokuBoardLines)
                {
                    // Go to each line on the sudoku
                    /* Example: 
                       Original sudoku file: |9| | | |2|3|7|6|8| | 
                       Splitting: "", "9", " ", " ", "2", "3", "7", "6", "8", " ", ""
                       Skip and take array result: ["9", " ", " ", "2", "3", "7", "6", "8", " "]
                        */
                    string[] sudokuBoardLineElements = sudokuBoardLine.Split("|").Skip(1).Take(9).ToArray();

                    // Initiate the column
                    int col = 0;

                    // Loop through the sudokuline array
                    foreach (var sudokuBoardLineElement in sudokuBoardLineElements)
                    {
                        // If a col has a space then put it to 0, otherwise convert the element into a number
                        sudokuBoard[row, col] = sudokuBoardLineElement.Equals(" ") ? 0 : Convert.ToInt16(sudokuBoardLineElement);

                        // Go to next col
                        col++;
                    }
                    // Go to next row
                    row++;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong while reading the file: " + ex.Message);
            }
            return sudokuBoard;
        }
    }
}
