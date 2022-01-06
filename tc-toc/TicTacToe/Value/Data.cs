using System;

namespace TicTacToe.Value
{
    internal class Data
    {
        internal static readonly char[] Board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        internal static bool Player = true;
        internal static bool Game = true;

        internal const ConsoleColor Back = ConsoleColor.Black;
        internal const ConsoleColor Color = ConsoleColor.DarkGreen;
    }
}