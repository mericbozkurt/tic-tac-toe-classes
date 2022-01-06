using TicTacToe.Enum;
using TicTacToe.Value;

namespace TicTacToe.Helper
{
    internal class Winner
    {
        internal static ResultType Check
        {
            get
            {
                if (Data.Board[0] == Data.Board[1] && Data.Board[1] == Data.Board[2])
                {
                    return Data.Board[0] == 'X' ? ResultType.X : ResultType.O;
                }
                else if (Data.Board[3] == Data.Board[4] && Data.Board[4] == Data.Board[5])
                {
                    return Data.Board[3] == 'X' ? ResultType.X : ResultType.O;
                }
                else if (Data.Board[6] == Data.Board[7] && Data.Board[7] == Data.Board[8])
                {
                    return Data.Board[6] == 'X' ? ResultType.X : ResultType.O;
                }
                else if (Data.Board[0] == Data.Board[3] && Data.Board[3] == Data.Board[6])
                {
                    return Data.Board[0] == 'X' ? ResultType.X : ResultType.O;
                }
                else if (Data.Board[0] == Data.Board[4] && Data.Board[4] == Data.Board[8])
                {
                    return Data.Board[0] == 'X' ? ResultType.X : ResultType.O;
                }
                else if (Data.Board[1] == Data.Board[4] && Data.Board[4] == Data.Board[7])
                {
                    return Data.Board[1] == 'X' ? ResultType.X : ResultType.O;
                }
                else if (Data.Board[2] == Data.Board[5] && Data.Board[5] == Data.Board[8])
                {
                    return Data.Board[2] == 'X' ? ResultType.X : ResultType.O;
                }
                else if (Data.Board[2] == Data.Board[4] && Data.Board[4] == Data.Board[6])
                {
                    return Data.Board[2] == 'X' ? ResultType.X : ResultType.O;
                }

                if (Data.Board[0] != '1' && Data.Board[1] != '2' && Data.Board[2] != '3' && Data.Board[3] != '4' && Data.Board[4] != '5' && Data.Board[5] != '6' && Data.Board[6] != '7' && Data.Board[7] != '8' && Data.Board[8] != '9')
                {
                    return ResultType.Y;
                }

                return ResultType.Z;
            }
        }
    }
}