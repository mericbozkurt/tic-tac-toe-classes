using TicTacToe.Util;
using TicTacToe.Value;

namespace TicTacToe.Extension
{
    internal class Factory
    {
        internal static void Reset()
        {
            Data.Board[0] = '1';
            Data.Board[1] = '2';
            Data.Board[2] = '3';
            Data.Board[3] = '4';
            Data.Board[4] = '5';
            Data.Board[5] = '6';
            Data.Board[6] = '7';
            Data.Board[7] = '8';
            Data.Board[8] = '9';
            Data.Player = true;
            Data.Game = true;
            Menu.ContinueMenu();
        }
    }
}