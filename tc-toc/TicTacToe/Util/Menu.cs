using TicTacToe.Engine;
using TicTacToe.Extension;
using TicTacToe.Helper;
using TicTacToe.Value;

namespace TicTacToe.Util
{
    internal class Menu
    {
        internal static void MenuSelect()
        {
            if (Data.Game)
            {
                Print.WriteLine("1. New game");
                Print.WriteLine("2. About the author");
                Print.WriteLine("3. Exit");

                Print.Write("U> ");

                Select.MenuWrite(Print.ReadKey().KeyChar);

                Run.Continue();
                MenuSelect();
            }
            else
            {
                Run.Start();
            }
        }

        internal static void ContinueMenu()
        {
            Print.Write("[Press Key to return to main menu...]");
            Print.ReadKey();
            Print.Clear();
        }
    }
}