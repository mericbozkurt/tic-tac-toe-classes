using TicTacToe.Extension;
using TicTacToe.Helper;
using TicTacToe.Util;

namespace TicTacToe.Engine
{
    internal class Run
    {
        internal static void Main()
        {
            Print.SetColor();
            Menu.MenuSelect();
        }

        internal static void Start()
        {
            Print.Clear();
            Board.Draw();
            Player.Draw();
            Menu.MenuSelect();
        }

        internal static void Continue()
        {
            Print.Write("Press a key to continue.");
            Print.ReadKey();
            Print.Clear();
        }

        internal static void Wrong()
        {
            Print.WriteLine();
            Print.WriteLine("Wrong Choice!");
        }

        internal static void WrongPlay()
        {
            Print.WriteLine();
            Print.WriteLine("Illegal Move! Try Again.");
        }
    }
}