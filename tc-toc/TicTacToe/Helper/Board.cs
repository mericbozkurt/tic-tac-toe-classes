using TicTacToe.Extension;
using TicTacToe.Value;

namespace TicTacToe.Helper
{
    internal class Board
    {
        internal static void Draw()
        {
            Print.WriteLine("Welcome to Tic-Tac-Toe!");
            Print.WriteLine();
            Print.WriteLine($" {Data.Board[0]} | {Data.Board[1]} | {Data.Board[2]} ");
            Print.WriteLine($"---+---+---");
            Print.WriteLine($" {Data.Board[3]} | {Data.Board[4]} | {Data.Board[5]} ");
            Print.WriteLine($"---+---+---");
            Print.WriteLine($" {Data.Board[6]} | {Data.Board[7]} | {Data.Board[8]} ");
            Print.WriteLine();
        }
    }
}