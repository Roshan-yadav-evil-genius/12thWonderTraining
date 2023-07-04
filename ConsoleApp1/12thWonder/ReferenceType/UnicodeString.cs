namespace UnicodeTypes
{

    class BaseClass
    {
        public void Execute(string[] args)
        {
            // Unicode is a computing industry standard for the consistent encoding, representation, and handling of text expressed in most of the world's writing systems.
            Console.WriteLine("Hello, 你好, नमस्ते, مرحبا, Peoples 👨🧡💛💚💙💜🤎🖤🤍!");
            // Console.OutputEncoding = System.Text.Encoding.UTF7; Ensecure encoading
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Hello, 你好, नमस्ते, مرحبا, Peoples 👨🧡💛💚💙💜🤎🖤🤍!");
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Hello, 你好, नमस्ते, مرحبا, Peoples 👨🧡💛💚💙💜🤎🖤🤍!");
            Console.OutputEncoding = System.Text.Encoding.ASCII;
            Console.WriteLine("Hello, 你好, नमस्ते, مرحبا, Peoples 👨🧡💛💚💙💜🤎🖤🤍!");


        }
    }
}