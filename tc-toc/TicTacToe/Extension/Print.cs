using System;
using TicTacToe.Value;

namespace TicTacToe.Extension
{
    internal class Print
    {
        internal static void Clear()
        {
            Console.Clear();
        }

        internal static void Write(string Text = null)
        {
            Console.Write(Text);
        }

        internal static void Write(string Text, object Arg = null)
        {
            Console.Write(Text, Arg);
        }

        internal static void WriteLine(string Text = null)
        {
            Console.WriteLine(Text);
        }

        internal static void WriteLine(string Text, object Arg = null)
        {
            Console.WriteLine(Text, Arg);
        }

        internal static ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }

        internal static void SetColor()
        {
            Console.BackgroundColor = Data.Back;
            Console.ForegroundColor = Data.Color;
        }
    }
}