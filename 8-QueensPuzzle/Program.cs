using System;
using System.Collections.Generic;

namespace _8_QueensPuzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            QueenPuzzle(8);
        }

        public static void QueenPuzzle(int size)
        {
            
            char[][] result = new char[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = new char[size];
                for (int j = 0; j < size; j++)
                {
                    result[i][j] = '.';
                }
            }
            BackTrace(result, 0);

        }

        public static void  BackTrace(char[][] result, int row)
        {
            for (int col = 0; col < result.Length; col++)
            {
                if (IsVaild(result, row, col))
                {
                    result[row][col] = 'Q';
                    if (row == result.Length - 1)
                    {
                        PrintResult(result);
                    }
                    else
                    {
                        BackTrace(result, row + 1);
                    }
                    result[row][col] = '.';
                }
            }
        }

        public static bool IsVaild(char[][] result, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                if (result[i][col] == 'Q')
                {
                    return false;
                }
            }

            for (int i = row - 1, j = col - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (result[i][j] == 'Q')
                {
                    return false;
                }
            }

            for (int i = row - 1, j = col + 1; i >= 0 && j < result.Length; i--, j++)
            {
                if (result[i][j] == 'Q')
                {
                    return false;
                }
            }


            return true;

        }

        public static void PrintResult(char[][] result)
        {
            List<String> list = new List<String>();
            Console.WriteLine("-----------------------");
            foreach (char[] value in result)
            {
                list.Add(new string(value));
                Console.WriteLine(value);
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine();
        }
    }
}
