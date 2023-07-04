namespace GameAssetSkeletons
{

    abstract class GameSkeleton
    {
        private string? name;
        private string? description;
        private string? version;
        private string? creator;

        public string Name
        {
            get { return name ?? throw new InvalidOperationException("Name is not initialized."); }
            set { name = value; }
        }

        public string Description
        {
            get { return description ?? throw new InvalidOperationException("Description is not initialized."); }
            set { description = value; }
        }

        public string Version
        {
            get { return version ?? throw new InvalidOperationException("Version is not initialized."); }
            set { version = value; }
        }

        public string Creator
        {
            get { return creator ?? throw new InvalidOperationException("Creator is not initialized."); }
            set { creator = value; }
        }
        public void SimulateLoading(string Suffix)
        {
            for (int i = 0; i < 5; i++)
            { 
                // "🕑🕒🕓🕔🕕🕖🕗🕘🕙🕚🕛"
                // Console.Write($"\r[+] {Suffix} {Name} | ");
                // Thread.Sleep(200);
                // Console.Write($"\r[+] {Suffix} {Name} / ");
                // Thread.Sleep(200);
                // Console.Write($"\r[+] {Suffix} {Name} - ");
                // Thread.Sleep(200);
                // Console.Write($"\r[+] {Suffix} {Name} \\ ");
                // Thread.Sleep(200);
                Console.Write($"\r[+] {Suffix} {Name} 🕑 ");
                Thread.Sleep(200);
                Console.Write($"\r[+] {Suffix} {Name} 🕒 ");
                Thread.Sleep(200);
                Console.Write($"\r[+] {Suffix} {Name} 🕓 ");
                Thread.Sleep(200);
                Console.Write($"\r[+] {Suffix} {Name} 🕔 ");
                Thread.Sleep(200);
                Console.Write($"\r[+] {Suffix} {Name} 🕕 ");
                Thread.Sleep(200);
                Console.Write($"\r[+] {Suffix} {Name} 🕖 ");
                Thread.Sleep(200);
                Console.Write($"\r[+] {Suffix} {Name} 🕗 ");
                Thread.Sleep(200);
                Console.Write($"\r[+] {Suffix} {Name} 🕘 ");
                Thread.Sleep(200);
                Console.Write($"\r[+] {Suffix} {Name} 🕙 ");
                Thread.Sleep(200);
                Console.Write($"\r[+] {Suffix} {Name} 🕚 ");
                Thread.Sleep(200);
                Console.Write($"\r[+] {Suffix} {Name} 🕛 ");
                Thread.Sleep(200);
            }
            Console.WriteLine();
            Console.Clear();

        }

        public void Run()
        {
            Console.Clear();
            Console.WriteLine("\n\t\t\tWelcome To GameHub (Play Like You Never Win Before))");
            Console.Clear();
            Console.WriteLine("Name " + Name);
            Console.WriteLine("Version : " + Version);
            Console.WriteLine("Created By : " + Creator);
            Console.WriteLine("\nDescription : " + Description);
            Console.WriteLine("\n\n");
            SimulateLoading("Starting");
            string? response = "c";
            while (response == "c")
            {
                Console.Clear();
                Start();
                Console.Write("[+] Quit(q), Continue(c), Restart(r) : ");
                response = Console.ReadLine();
                if (String.IsNullOrEmpty(response))
                {
                    break;
                }
                else if (response == "r")
                {
                    Reset();
                    response = "c";
                }
            }
            // SimulateLoading("Closing");
            Console.Clear();
            Console.WriteLine("\n\t\t\t 🙏 Thanku For Visiting GameHub  ( Play 🎮 Like You Never Win 🎉 Before))");
        }
        public abstract void Start();
        public abstract void Reset();
    }

    abstract class PlayerSkeleton
    {

        protected string Name; // CS8618
        protected int win, lose;

        public PlayerSkeleton(string name)
        {
            Name = name;
        }


    }
}