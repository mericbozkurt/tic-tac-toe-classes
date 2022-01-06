using System;
using TicTacToe.Engine;
using TicTacToe.Enum;
using TicTacToe.Extension;
using TicTacToe.Value;

namespace TicTacToe.Helper
{
    internal class Select
    {
        internal static void MenuWrite(char Char)
        {
            _ = int.TryParse($"{Char}", out int Value);

            switch ((MenuType)Value - 1)
            {
                //Menu Content
                case MenuType.Game:
                    Data.Game = false;
                    Run.Start();
                    break;

                case MenuType.About:
                    Print.Clear();
                    Print.WriteLine("Hello, I am Meriç BOZKURT, CO-Founder of Soferity LLC.");
                    Print.WriteLine("You can visit our projects and use our integrations!");
                    Print.WriteLine("https://github.com/Soferity");
                    Print.WriteLine();
                    break;

                case MenuType.Exit:
                    Print.WriteLine();
                    Print.WriteLine("Are you sure you want to quit? [y/n]");

                    Print.Write("U> ");

                    if ($"{Print.ReadKey().KeyChar}".ToLowerInvariant() == "y")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Print.WriteLine();
                    }
                    break;

                default:
                    Run.Wrong();
                    break;
            }
        }
    }
}