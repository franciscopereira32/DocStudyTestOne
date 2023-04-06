using System;

namespace DotnetBot
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string message = "";
            if (args.Length < 1)
            {
                message = "Welcome to .NET Core!";
                Console.WriteLine(message);
            }
            else
            {
                foreach (var item in args)
                {
                    message += item;
                }
            }
        }
    }
}

