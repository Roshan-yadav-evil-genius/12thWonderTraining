using TicTacToeGame;
using RockPaperScissorGame;
using ReadWriteOperation;
using AuthenticationSystem;

class GameHub
{

    public static void PlaceAtCenter(string text)
    {
        int width = Console.WindowWidth;
        int x = (width / 2) - (text.Length / 2);
        Console.SetCursorPosition(x, Console.CursorTop);
        Console.WriteLine(text);
    }

    static void logMsg(logLevel level, string msg)
    {
        Log.logEvent("GameHub", level, msg);

    }

    static void Main(string[] args) //IDE0060
    {
        Console.Clear();

        logMsg(logLevel.DEBUG, "Main Script Starting");

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        PlaceAtCenter("🎮  Welcome to GameHub  🎪");

        bool isValidUser = false;

        while (!isValidUser)
        {

            Console.Write("Enter Your GameHub Username : ");
            string? username = Console.ReadLine();
            Console.Write("Enter Your GameHub Pswd : ");
            string? pswd = Console.ReadLine();
            Authenticate User = new Authenticate(username, pswd);
            if (User.isAuthenticated())
            {
                isValidUser = true;
            }
            else
            {
                Console.WriteLine("Invalid username or pswd");
            }
        }




        // List all Available Games
        Console.WriteLine("[+] Available Games:");
        Console.WriteLine("\n\t1. Tic Tac Toe ");
        Console.WriteLine("\n\t2. Rock Paper Scissors");

        // Get User Input
        Console.Write("\n[+] Enter the Game Id which you Want to play: ");
        string? gameId = Console.ReadLine();

        if (int.TryParse(gameId, out int UserSelectedGameId))
        {

            switch (UserSelectedGameId)
            {
                case 1:
                    var tgame = new TickTacToe();
                    tgame.Run();
                    break;
                case 2:
                    var rgame = new RockPaperScissor();
                    rgame.Run();
                    Console.WriteLine("Rock Paper Scissors Game Starting....");
                    break;
                default:
                    Console.WriteLine("[-] Invalid Game Id Please Enter a Valid Game Id");
                    break;
            }
        }
        else
        {
            logMsg(logLevel.ERROR, "User try to select a game which not exist");
            Console.WriteLine("[-] Id you Entered is not a Number Please Enter a Valid Game Id");
        }

        logMsg(logLevel.DEBUG, "Closing MainScript");

    }
}