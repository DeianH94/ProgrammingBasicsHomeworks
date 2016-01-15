using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MatrixOfPalindromes
{
    static void Main()
    {
        Console.Write("Input number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Input number of colums: ");
        int colums = int.Parse(Console.ReadLine());
        string[,] matrix = new string[rows, colums];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = " " + (char)(97 + i) + (char)(97 + j + i) + (char)(97 + i);
            }
        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}