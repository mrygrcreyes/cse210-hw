using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int currentPoints = 0;


        void AddGoal()
        {
            string name;
            string choice;
            int pointValue;
            int timesToComplete;
            do{
            Console.Write("What kind of goal would you like to add?\n1. Simple Goal\n2. Eternal Goal \n3. Checklist Goal \n4. Quit\n> ");
            choice = Console.ReadLine();
            if(choice == "1")
            {
                Console.Write("What is the name of your new goal?\n> ");
                name = Console.ReadLine();
                Console.Write("How many points is this goal worth?\n> ");
                pointValue = int.Parse(Console.ReadLine());
                goals.Add(new SimpleGoal(pointValue, false, name, "Simple"));
                Console.WriteLine("Goal Added!");
                Console.ReadLine();
            }
            else if(choice == "2")
            {
                Console.Write("What is the name of your new goal?\n> ");
                name = Console.ReadLine();
                Console.Write("How many points is this goal worth?\n> ");
                pointValue = int.Parse(Console.ReadLine());
                goals.Add(new EternalGoal(name, pointValue, "Eternal", false));
                Console.WriteLine("Goal Added!");
                Console.ReadLine();
                
            }
            else if(choice == "3")
            {

                Console.Write("What is the name of your new goal?\n> ");
                name = Console.ReadLine();
                Console.Write("How many points is this goal worth?\n> ");
                pointValue = int.Parse(Console.ReadLine());
                Console.Write("How many times do you want to do this goal?\n> ");
                timesToComplete = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(false, name, pointValue, "Checklist", timesToComplete));
                Console.WriteLine("Goal Added!");
                Console.ReadLine();
            }
            }while(choice != "4");
        }

        void CompleteGoal()
        {
            Console.WriteLine("Which goal would you like to complete?");
            int index = 1;
            foreach(Goal goal in goals)
            {
                Console.Write($"{index}: ");
                goal.DisplayGoal();
                index ++;
            }
            Console.Write("> ");
            int choice = int.Parse(Console.ReadLine());
            choice --;
            int points = goals[choice].CompleteGoal();
            Console.WriteLine($"You completed the goal and got {points} points!");
            currentPoints += points;
        }

        string GetLevel()
        {
            if(currentPoints < 100)
            {
                return "Level: 1";
            }
            else if(currentPoints >= 100 && currentPoints < 200)
            {
                return "Level: 2";
            }
            else if(currentPoints >= 200 && currentPoints < 300)
            {
                return "Level: 3";
            }
            else if(currentPoints >= 300 && currentPoints < 400)
            {
                return "Level: 4";
            }
            else
            {
                return "Level: 5";
            }
        }

        void DisplayStatus()
        {
            string level = GetLevel();
            Console.WriteLine($"{level}\nPoints: {currentPoints}");
        }

        void DisplayGoals()
        {
            foreach(Goal goal in goals)
            {
                goal.DisplayGoal();
            }
        }

        void SortGoals()
        {
            List<Goal> sortedList = new List<Goal>();
            foreach(Goal goal in goals)
            {
                if(goal.GetType() == "Simple")
                {
                    sortedList.Add(goal);
                }
            }
            foreach(Goal goal in goals)
            {
                if(goal.GetType() == "Checklist")
                {
                    sortedList.Add(goal);
                }
            }
            foreach(Goal goal in goals)
            {
                if(goal.GetType() == "Eternal")
                {
                    sortedList.Add(goal);
                }
            }
            goals = sortedList;
        }

        void Menu()
        {
            string choice;
            do
            {
                Console.Clear();
                DisplayStatus();
                Console.WriteLine();
                Console.Write("What would you like to do?\n1. Create Goal\n2. Complete Goal\n3. See Goals\n4. Quit\n> ");
                choice = Console.ReadLine();
                if(choice == "1")
                {
                    Console.Clear();
                    AddGoal();
                }
                else if(choice == "2")
                {
                    Console.Clear();
                    CompleteGoal();
                }
                else if(choice =="3")
                {
                    Console.Clear();
                    SortGoals();
                    DisplayGoals();
                    Console.ReadLine();
                }

            }while(choice != "4");
        }

        Menu();
    }
}
//To show creativity I added a level up system and organized the goals every time I display them. 