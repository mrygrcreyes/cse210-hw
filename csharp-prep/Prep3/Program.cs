using System;

class Program
{
    static void Main(string[] args)
    {
       //Console.Write("What is the magic number? ");
       //int magicNumber = int.Parse(Console.ReadLine());

       Random randomGenerator = new Random();
       int magicNumber = randomGenerator.Next(1, 100);

       int guessNumber = -1; 
       int guessCount = 0;
       //string play = "yes";

       while (guessNumber != magicNumber)
       {
         Console.Write("What is your guess? ");
         guessNumber = int.Parse(Console.ReadLine());
         guessCount = guessCount + 1;

         if (magicNumber > guessNumber)
         {
            Console.WriteLine ("Higher");
         }
         else if (magicNumber < guessNumber)
         {
            Console.WriteLine("Lower");
         }
         else
         {
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {guessCount} guesses");

           /* if (play == "yes")
            {
               Console.Write("Would you like to play again (yes/no)?");
               play = Console.ReadLine();
            } 
            else 
            {
               //Console.WriteLine("Thank you for playing. Goodbye!");
               }
            */
                
            
         } 

       }

    }
}