using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string number()
        {
            Console.Write("\nWhat would you like to do? (Plese Enter a number)\n1.Write a new entry\n2.Display the journal\n3.Save the journal to a file\n4.Load the journal from a file\n5.Exit\n> ");
            string choice = Console.ReadLine();
            return choice;
        }
        void Menu()
        {
            string choice = "0";
            do{
                choice = number();
                if (choice == "1")
                {
                    journal.CreateEntry();
                }
                else if (choice == "2")
                {
                    journal.DisplayJournal();
                }
                else if(choice == "3")
                {
                    journal.SaveJournal();
                }
                else if(choice == "4")
                {
                    journal.LoadJournal();
                }
                else if (choice == "5")
                {
                    Console.WriteLine("Thank you! Remember to comeback and write your journal.");
                }
                else if(choice != "5")
                {
                    Console.WriteLine("Invalid choice, try again.");
                }
            }while(choice != "5"); 
        }
        Menu();
    }
}

//Journal.txt is provided to store the journal entries but the user are freely to create the new filename to instore the entries. 