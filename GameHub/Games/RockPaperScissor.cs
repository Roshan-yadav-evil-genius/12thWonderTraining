using GameAssetSkeletons;

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
        public RockPaperScissor()
        {
            Name = "Rock Paper Scissor";
            Description = "Rock Paper Scissor Game";
            Version = "1.0.0";
            Creator = "Roshan yadav";
        }
        public override void Start()
        {
            do
            {
                Random random = new Random();
                Options selectedOption = (Options)random.Next(1, 4);
                Console.Write("Enter your choice [ 🧱 : 1,  📄 : 2, ✌ : 3 ]: ");
                string? pos = Console.ReadLine();

                if (String.IsNullOrEmpty(pos))
                {
                    break;
                }
                Options UserSelected = (Options)Convert.ToInt32(pos);
                Console.Write($"\nYou Selected {GetEmoji(UserSelected)} and Computer Selected {GetEmoji(selectedOption)} : ");

                if (UserSelected == selectedOption)
                {
                    Console.WriteLine("Match Draw 👯‍♂️");
                }
                else if (UserSelected == Options.Rock && selectedOption == Options.Scissor)
                {
                    Console.WriteLine("You Win  🥳");
                }
                else if (UserSelected == Options.Paper && selectedOption == Options.Rock)
                {
                    Console.WriteLine("You Win  🥳");
                }
                else if (UserSelected == Options.Scissor && selectedOption == Options.Paper)
                {
                    Console.WriteLine("You Win  🥳");
                }
                else
                {
                    Console.WriteLine("You Lose 👽");
                }
                Console.WriteLine("\n\n");
            } while (true);


        }
        public string GetEmoji(Options option)
        {
            switch (option)
            {
                case Options.Rock:
                    return "🧱";
                case Options.Paper:
                    return "📄";
                case Options.Scissor:
                    return "✌";
                default:
                    return "🤷‍♂️";
            }
        }
        public override void Reset()
        {
            Console.WriteLine("RPS Game");
        }
    }
}