using GameAssetSkeletons;
using ReadWriteOperation;

namespace RockPaperScissorGame
{

    public enum Options
    {
        Rock = 1,
        Paper,
        Scissor
    }

    class RockPaperScissor : GameSkeleton
    {
        static void logMsg(logLevel level, string msg)
        {
            Log.logEvent("RockPaperScissor", level, msg);

        }
        public RockPaperScissor()
        {
            Name = "Rock Paper Scissor";
            Description = "Rock Paper Scissor Game";
            Version = "1.0.0";
            Creator = "Roshan yadav";
        }
        public override void Start()
        {
            logMsg(logLevel.INFO, "Started...");
            do
            {
                Random random = new Random();
                Options selectedOption = (Options)random.Next(1, 4);
                Console.Write("Enter your choice [ Rock : 1,  Paper : 2, Scissor : 3 ]: ");
                string? pos = Console.ReadLine();

                if (String.IsNullOrEmpty(pos))
                {
                    break;
                }
                if (!int.TryParse(pos, out int userInput) || userInput < 1 || userInput > 3)
                {
                    Console.WriteLine("Invalid input. Please enter a valid choice (1-3).");
                    logMsg(logLevel.WARNING, "User try To Pass unnecessary Value");

                    continue;
                }
                Options UserSelected = (Options)Convert.ToInt32(pos);
                Console.Write($"\nYou Selected {UserSelected} and Computer Selected {selectedOption} : ");

                if (UserSelected == selectedOption)
                {
                    Console.WriteLine("-----------Match Draw-----------");
                }
                else if (UserSelected == Options.Rock && selectedOption == Options.Scissor)
                {
                    Console.WriteLine("-----------You Win-----------");
                }
                else if (UserSelected == Options.Paper && selectedOption == Options.Rock)
                {
                    Console.WriteLine("-----------You Win-----------");
                }
                else if (UserSelected == Options.Scissor && selectedOption == Options.Paper)
                {
                    Console.WriteLine("-----------You Win-----------");
                }
                else
                {
                    Console.WriteLine("You Lose Better Luck Next Time");
                }
                Console.WriteLine("\n\n");
            } while (true);
            logMsg(logLevel.INFO, "Closed...");


        }
        public override void Reset()
        {
            logMsg(logLevel.ERROR, "Reseting...");

            Console.WriteLine("RPS Game");
        }
    }
}