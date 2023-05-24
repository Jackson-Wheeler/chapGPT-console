using System;

namespace console_app;

internal class Program
{
    private const string QUIT_KEYWORD = "quit";

    // Main Method
    static async Task Main(string[] args)
    {
        consoleIntro();
        ChatGPT chat = chatGPTConnect();        
     
        // Main loop - Ask question, read user inputted question, and submit to ChatGPT
        while (true)
        {
            Console.Write("\nWrite Your Question: ");
            string? prompt = Console.ReadLine();
            if (prompt == null) continue;
            if (prompt == QUIT_KEYWORD) break; // logic to exit loop
            // Ask question through ChatGPT api & print result
            await chat.askQuestion(prompt);
        }

        finish(0);
    }

    // Print intro information to console for user
    public static void consoleIntro()
    {
        Console.WriteLine("Hello there!");
        Console.WriteLine("Welcome to a Console version of ChatGPT! Ask away!");
        Console.WriteLine($"Type '{QUIT_KEYWORD}' and press Enter to quit program");
        Console.WriteLine();
    }

    // Attempts to connect to chatGPT, exits if error
    public static ChatGPT chatGPTConnect()
    {
        ChatGPT chat = null;
        try
        {
            chat = new ChatGPT();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            finish(1);
        }
        return chat;
    }

    // Terminates program with given status after user presses a key
    public static void finish(int status)
    {
        Console.WriteLine();
        Console.Write($"{Environment.NewLine}Press any key to exit...");
        Console.ReadKey(true);
        System.Environment.Exit(status);
    }

    // Code to test console output
    public static void askName()
    {
        Console.Write("Enter your name: ");
        string? name = Console.ReadLine();
        DateTime currentDate = DateTime.Now;
        Console.WriteLine($"{Environment.NewLine}Hello, {name}. I hope you are doing well today {currentDate:d} at {currentDate:t}");
    }

}
