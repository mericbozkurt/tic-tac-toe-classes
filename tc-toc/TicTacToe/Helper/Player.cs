using System;
using TicTacToe.Engine;
using TicTacToe.Enum;
using TicTacToe.Extension;
using TicTacToe.Value;

namespace TicTacToe.Helper
{
    internal class Player
    {
        internal static void Draw()
        {
            switch (Winner.Check)
            {
                case ResultType.X:
                    Print.WriteLine("X Won!");
                    Factory.Reset();
                    break;

                case ResultType.O:
                    Print.WriteLine("O Won!");
                    Factory.Reset();
                    break;

                case ResultType.Y:
                    Print.WriteLine();
                    Print.WriteLine("Game Over!");
                    Factory.Reset();
                    break;

                default:
                    Print.Write("{0}’s Move > ", Data.Player ? "X" : "O");

                    char Move = Print.ReadKey().KeyChar;

                    if (char.IsNumber(Move))
                    {
                        int Number = Convert.ToInt32(Move.ToString());

                        if (Number > 0 && Number < 10)
                        {
                            if (Data.Board[Number - 1] != 'X' && Data.Board[Number - 1] != 'O')
                            {
                                Data.Board[Number - 1] = Data.Player ? 'X' : 'O';

                                Data.Player = !Data.Player;
                            }
                            else
                            {
                                Run.WrongPlay();
                                Run.Continue();
                            }
                        }
                        else
                        {
                            Run.WrongPlay();
                            Run.Continue();
                        }
                    }
                    else
                    {
                        Run.WrongPlay();
                        Run.Continue();
                    }
                    break;
            }
        }
    }
}