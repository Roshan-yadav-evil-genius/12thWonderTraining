using GameAssetSkeletons;
using ReadWriteOperation;


namespace TicTacToeGame
{


    class TickTacToe : GameSkeleton
    {
        static void logMsg(logLevel level, string msg)
        {
            Log.logEvent("TickTacToe", level, msg);

        }
        private enum Situation
        {
            Win,
            Draw,
            Continue
        }

        private static string[] BoardSchema = {
            "1", "2", "3",
            "4", "5", "6",
            "7", "8", "9"
        };

        private string[] Board = {
            "1", "2", "3",
            "4", "5", "6",
            "7", "8", "9"
        };
        public TickTacToe()
        {
            Name = "Tic Tac Toe";
            Description = @"Tic Tac Toe is a classic game played on a 3x3 grid. Two players take turns placing their marks, usually  X and O on the grid to create a line of three of their own marks in a horizontal, vertical, or diagonal direction. The first player to achieve this goal wins the game. If all cells are filled without a winner, the game ends in a draw. Strategic thinking and planning are key to winning this simple yet engaging game.";
            Version = "1.0.0";
            Creator = "Roshan Yadav";
        }

        public override void Start()
        {
            logMsg(logLevel.INFO, "Starting");
            string? pos = "";
            string symbol = "X";
            bool AnyOnewin = false;
            bool Draw = false;

            do
            {
                if (!String.IsNullOrEmpty(pos))
                {
                    bool status = UpdateBoard(Convert.ToInt32(pos), symbol);
                    switch (status)
                    {
                        case true:
                            Console.WriteLine($"[+] {symbol} Placed At {pos}");
                            var match = CheckSituation();
                            if (match == Situation.Win)
                            {
                                Console.Clear();
                                AnyOnewin = true;
                            }
                            else if (match == Situation.Draw)
                            {
                                Console.Clear();
                                Draw = true;
                            }
                            else
                            {
                                symbol = (symbol == "X") ? "O" : "X";
                                Console.Clear();
                            }
                            break;
                        case false:
                            Console.Clear();
                            logMsg(logLevel.WARNING, "User try To fill Captured Place");

                            Console.WriteLine("[!] That Space Already Taken Pass diffrent position\n");
                            break;
                    }
                }
                ShowBoard();
                if (!AnyOnewin && !Draw)
                {
                    Console.Write($"[+] Enter Position For Placing {symbol} : ");
                    pos = Console.ReadLine();

                }
                else if (Draw)
                {
                    Console.WriteLine("[+] Match Draw No One Win");
                }
                else
                {
                    Console.WriteLine($"Congratulation The Winner is : {symbol}");
                }
            } while (!String.IsNullOrEmpty(pos) && !AnyOnewin && !Draw);
        }

        public override void Reset()
        {
            Array.Copy(BoardSchema, Board, BoardSchema.Length);
        }

        private Situation CheckSituation()
        {
            if (SomeOneWin())
            {
                return Situation.Win;
            }
            else if (IsBoardFull())
            {
                return Situation.Draw;
            }
            else
            {
                return Situation.Continue;
            }
        }
        public bool IsBoardFull()
        {
            foreach (string cell in Board)
            {
                if (cell != "X" && cell != "O")
                {
                    return false;
                }
            }
            return true;
        }

        private void ShowBoard()
        {

            Console.WriteLine($" {Board[0]} | {Board[1]} | {Board[2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {Board[3]} | {Board[4]} | {Board[5]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {Board[6]} | {Board[7]} | {Board[8]} \n\n");
        }

        private bool UpdateBoard(int pos, string Symbol)
        {
            if (pos < 1 || pos > 9)
            {
                return false;
            }
            else if (Board[pos - 1] == $"{pos}")
            {
                Board[pos - 1] = Symbol;
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool SomeOneWin()
        {
            for (int row = 0; row < 3; row++)
            {
                if (Board[row * 3] == Board[row * 3 + 1] && Board[row * 3 + 1] == Board[row * 3 + 2])
                {
                    return true;
                }
            }
            for (int col = 0; col < 3; col++)
            {
                if (Board[col] == Board[col + 3] && Board[col + 3] == Board[col + 6])
                {
                    return true;
                }
            }
            if ((Board[0] == Board[4] && Board[4] == Board[8]) || (Board[2] == Board[4] && Board[4] == Board[6]))
            {
                return true;
            }

            return false;
        }
    }

}