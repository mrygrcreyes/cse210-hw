using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breatheActivity = new BreathingActivity("Breathing");
        ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection");
        ListingActivity listingActivity = new ListingActivity("Listing");

        void Menu()
        {
           string choice;
           do{
           Console.Clear();
           Console.Write("Please choose from the following Activities:\n   1. Breathing Activity\n   2. Reflecting Activity\n   3. Listing Activity\n   4. Quit\n> "); 
           choice = Console.ReadLine();
           if(choice == "1")
           {
            breatheActivity.DisplayIntro();
            breatheActivity.DoBreath();
            breatheActivity.DisplayOutro();
           }
           else if(choice == "2")
           {
            reflectionActivity.DisplayIntro();
            reflectionActivity.DoReflect();
            reflectionActivity.DisplayOutro();
           }
           else if(choice == "3")
           {
            listingActivity.DisplayIntro();
            listingActivity.DoListing();
            listingActivity.DisplayOutro();
           }
           }while(choice != "4");
        }

        
        Menu();
        
        //To show creativity, you cant get a repeated prompt or question in the reflection and listing activities until you have gone through them all.
    }
}