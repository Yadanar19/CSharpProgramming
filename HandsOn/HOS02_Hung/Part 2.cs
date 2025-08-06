using System;

namespace _2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 3;
            int columns = 3;

            int[,] table = new int[rows, columns];//Create a 2D array that is 3x3 (3 rows and 3 columns)
            table[0, 0] = 1; //assign value to each array elements, no specific value is provided, by default it's 0
            table[0, 1] = 2;
            table[0, 2] = 3;
           
            //Challenge to create 2D array 2nd table with a 5 in the middle of 2nd row
            table[1, 0] = 0; //assign value to each array elements, no specific value is provided, by default it's 0
            table[1, 1] = 5;
            table[1, 2] = 0;

            //Challenge to create 2D array 3rd table with an 8 in the middle of 2nd row
            table[2, 0] = 0; //assign value to each array elements,no specific value is provided, by default it's 0
            table[2, 1] = 8;
            table[2, 2] = 0;

            //loop through and print the whole 2D array
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    Console.Write(table[x,y] + " "); //Print values on the same line
                }
                Console.WriteLine(); //a new line is created after each row is iterated
            }
        }
    }
}
