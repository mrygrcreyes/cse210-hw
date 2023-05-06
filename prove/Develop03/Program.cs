using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference ("Proverbs", "3", "5", "6");
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding; In all thy ways acknowledge him, and he shall direct thy paths.");

        string userInput = "";

        while (userInput != "quit" && scripture.CheckHiddenWords() == true)
        {
            Console.Clear();

            //Display Scripture
            Console.WriteLine(scripture.DisplayScripture());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or quit to finish");
            userInput = Console.ReadLine();
            scripture.HiddenWords();

        }
         Console.WriteLine("Hopefully you memorized the scripture");

    }
}