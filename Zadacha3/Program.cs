using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] board = new string[8, 8];
            bool[,] redcolor = new bool[8, 8];
            int row = -1;
            int col = -1;

            //default value
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = "■";
                }
            }
            //input
            for (int i = 0; i < 3; i++)
            {
                string input = Console.ReadLine().ToLower();
                string[] arr = input.Split();
                

                //find col
                switch (arr[0])
                {
                    case "a": col = 0; break;
                    case "b": col = 1; break;
                    case "c": col = 2; break;
                    case "d": col = 3; break;
                    case "e": col = 4; break;
                    case "f": col = 5; break;
                    case "g": col = 6; break;
                    case "h": col = 7; break;
                    default: Console.WriteLine("Not existing column!"); break;
                }

                //find row
                if (Convert.ToInt32(arr[1]) > 0 && Convert.ToInt32(arr[1]) <= 8)
                {
                    row = Convert.ToInt32(arr[1]) - 1;
                }
                if (row >= 0 && col >= 0)
                {
                    board[row, col] = "R";
                }

                for (int x = 0; x < board.GetLength(0); x++)
                {
                    for (int y = 0; y < board.GetLength(1); y++)
                    {
                        if (board[x,y] == "■")
                        {
                            if (x == row || y == col)
                            {
                                redcolor[x, y] = true;
                            }
                        }
                    }
                }
            }

            Console.Clear();

            //print

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i,j] == "■")
                    {
                        if (redcolor[i,j] == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                    }
                    else if (board[i, j] == "R")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }



                    Console.Write(board[i, j]);
                    Console.Write(" ");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }

            int safe = 0;
            int notsafe = 0;
            for (int i = 0; i < redcolor.GetLength(0); i++)
            {
                for (int j = 0; j < redcolor.GetLength(1); j++)
                {
                    if (board[i,j] == "■")
                    {
                        if (redcolor[i, j] == true)
                        {
                            notsafe++;
                        }
                        else
                        {
                            safe++;
                        }
                    }
                }
            }

            Console.WriteLine($"\nSafe squares: {safe}");
            Console.WriteLine($"Not safe squares: {notsafe}\n");
        }
    }
}
