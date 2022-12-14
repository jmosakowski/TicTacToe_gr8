using System;

namespace TicTacToe_gr8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create two boards - with starting and with current fields
            char[,] startBoard = {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' }
            };
            char[,] gameBoard = startBoard;

            // Flags
            bool player1Won = false;
            bool player2Won = false;
            bool nextIsPlayer1 = true; // true - player 1 move, false - player 2 move

            ////////////////////////////////////////////////////////////////

            // Loop over rounds
            for (int round = 0; round < gameBoard.Length; round++)
            {
                Console.Clear();
                Draw(gameBoard);

                if (nextIsPlayer1)
                {
                    // TODO: player 1 move
                    nextIsPlayer1 = false;
                }
                else
                {
                    // TODO: player 2 move
                    nextIsPlayer1 = true;
                }

                if (player1Won || player2Won)
                    break;
            }

            ////////////////////////////////////////////////////////////////

            // End the game
            Console.Clear();
            Draw(gameBoard);
            Console.Write("Game ended! ");
            // TODO: print who won
        }

        /******************************************************************/

        static void Draw(char[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                    Console.Write(board[i, j]);
                Console.WriteLine();
            }
        }
    }
}
