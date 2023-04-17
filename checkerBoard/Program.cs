using System;

namespace checkerBoard
{
    class Program
    {
        static void Main(string[]args)
        {
            Board board = new Board(4, 4);
            board.Print();
        }
    }   
    class Board
    {
        private int[,] checkers;
        private int rows;
        private int columns;
        public Board(int r, int c)
        {
            rows = r;
            columns = c;
            checkers = new int[rows, columns];
            Setup();
        }
        
        private void Setup()
        {
            bool sqaureValue = true;
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    checkers[r,c] = Convert.ToInt32(sqaureValue);
                    sqaureValue = !sqaureValue;
                }
                sqaureValue = !sqaureValue;
            }
        }
        public void Print()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    Console.Write($"{checkers[r, c]}");
                }
                Console.WriteLine("");
            }
        }
    }
}