using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Goal> goalsList = new List<Goal>();
        int score = 0;


        int choice;
        do
        {
        if (score < 100)
            {
                Console.WriteLine("Level: Begginer (charge Goal.txt to know your update level)");
            }
            else if(score < 200)
            {
                Console.WriteLine("Level: Novice");
            }
            else if(score < 300)
            {
                Console.WriteLine("Level: Intermediate ");
            }
            else if(score > 300)
            {
                Console.WriteLine("Level: Enlightened ");
            }
                Console.WriteLine($"You have {score} Points.");
                Console.WriteLine("");
                Console.WriteLine("Menu Options: ");
                Console.WriteLine("1. Create a New Goal ");
                Console.WriteLine("2. List Goals ");
                Console.WriteLine("3. Save Goals ");
                Console.WriteLine("4. Load Goals ");
                Console.WriteLine("5. Record Event ");
                Console.WriteLine("6. Quit ");
                Console.Write("Select a choice from the menu: ");
                choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {


        case 1:
            Console.Clear();

            int choice1;
            do
            {
                Console.WriteLine("The types of goals are: ");
                Console.WriteLine("1. Simple Goal ");
                Console.WriteLine("2. Eternal Goal ");
                Console.WriteLine("3. Checklist Goal ");
                Console.WriteLine("4. Return to Main Menu ");
                Console.Write("Select a choice from the menu: ");
                choice1 = Convert.ToInt32(Console.ReadLine());
                switch (choice1)
                {
                    case 1:
                        Console.Write("what is the name of your goal? ");
                        string simpleName = Console.ReadLine();
                        Console.Write("What is a short description of it? ");
                        string simpleDescription = Console.ReadLine();
                        Console.Write("What is the amount of points associated with this goal? ");
                        int simplePoints = int.Parse(Console.ReadLine());
                        SimpleGoal simple = new SimpleGoal("SimpleGoal", simpleName, simpleDescription, simplePoints);
                        goalsList.Add(simple);
                        break;

                    case 2:
                        Console.Write("what is the name of your goal? ");
                        string eternalName = Console.ReadLine();
                        Console.Write("What is a short description of it? ");
                        string eternalDescription = Console.ReadLine();
                        Console.Write("What is the amount of points associated with this goal? ");
                        int eternalPoints = int.Parse(Console.ReadLine());
                        EternalGoal eternal = new EternalGoal("EternalGoal", eternalName, eternalDescription, eternalPoints);
                        goalsList.Add(eternal);
                        break;
                    case 3:


                        Console.Write("what is the name of your goal? ");
                        string checklistName = Console.ReadLine();
                        Console.Write("What is a short description of it? ");
                        string checklistDescription = Console.ReadLine();
                        Console.Write("What is the amount of points associated with this goal? ");
                        int checklistPoints = int.Parse(Console.ReadLine());
                        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                        int checklistTimes = int.Parse(Console.ReadLine());
                        Console.Write("What is the bonus for accomplishing it that many times? ");
                        int bonus = int.Parse(Console.ReadLine());
                        ChecklistGoal checklist = new ChecklistGoal("ChecklistGoal", checklistName, checklistDescription, checklistPoints, checklistTimes, bonus);
                        goalsList.Add(checklist);     
                        
                        break;
                    case 4:
                        
                        break;
                    }
                }while (choice1 != 4);

                break;



            case 2:
                Console.Clear();
                Console.WriteLine("The Goals are:");
                int indexDisplay = 1;
                foreach (var goal in goalsList)
                {   
                    Console.WriteLine(goal.DisplayGoal(indexDisplay));
                    indexDisplay ++;
                }
                break;



            case 3:
                Console.Write("What is the name of the file: ");
                string fileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    // score = goalsList[0].GetScore();
                    outputFile.WriteLine(score);
                    foreach (var goal in goalsList)
                    {   
                        outputFile.WriteLine(goal.SaveGoals());
                    }
                }

                break;



            case 4:
                goalsList.Clear();
                Console.Write("What is the name of the file: ");
                string loadFile = Console.ReadLine();
                List<string> lines = File.ReadAllLines(loadFile).Skip(1).ToList();
                string lineScore = File.ReadLines(loadFile).First();
                score = int.Parse(lineScore);
                foreach (string line in lines)
                {               
                    string[] parts = line.Split(",");

                    string goalType = parts[0];
                    if(goalType == "SimpleGoal")
                    {   

                        string type = parts[0];
                        string Name = parts[1];
                        string description = parts[2];
                        int points = int.Parse(parts[3]);
                        bool isComplete = bool.Parse(parts[4]);
                        SimpleGoal simpleLoad = new SimpleGoal(type, Name, description, points, isComplete);
                        goalsList.Add(simpleLoad);
                    }

                    else if(goalType == "EternalGoal")
                    {   

                        string type = parts[0];
                        string Name = parts[1];
                        string description = parts[2];
                        int points = int.Parse(parts[3]);
                        EternalGoal eternalLoad = new EternalGoal(type, Name, description, points);
                        goalsList.Add(eternalLoad);
                    }

                    else
                    {   
                        string type = parts[0];
                        string Name = parts[1];
                        string description = parts[2];
                        int points = int.Parse(parts[3]);
                        int bonus = int.Parse(parts[4]);
                        int times = int.Parse(parts[5]);
                        int numbersOfCompletedGoal =int.Parse(parts[6]);
                        ChecklistGoal CheckilstLoad = new ChecklistGoal(type, Name, description, points,numbersOfCompletedGoal,times, bonus);
                        goalsList.Add(CheckilstLoad);
                    }
                }
                break;            

            case 5:
                Console.Clear();
                Console.WriteLine("The Goals are:");
                int indexRecord = 1;
                foreach (var goal in goalsList)
                {   
                    Console.WriteLine(goal.DisplayGoal(indexRecord));
                    indexRecord ++;
                }
                Console.Write("Which goal did you accomplished? ");
                int choiceRecord = int.Parse(Console.ReadLine());
                var goalRecord = goalsList[choiceRecord-1];
                goalRecord.RecordEvent();

                // if(goalRecord.GetGoalType() == "SimpleGoal" || goalRecord.GetGoalType() == "EternalGoal")
                // {
                    score += goalRecord.GetGoalpoints();
                
                // else
                // {
                //     var t = new ChecklistGoal(goalRecord.GetGoalType,goalRecord.GetGoalName,goalRecord.GetGoalDescription,goalRecord.GetGoalpoints,goalRecord.)
                //     if (goalRecord.GetIsComplete())
                //     {
                //         score = score + goalRecord.GetGoalpoints() + goalRecord.GetBonus();
                //     }
                //     else
                //     {
                //         score += goalRecord.GetGoalpoints();
                //     }
                // }
                

                break;

                
            case 6:

                Console.WriteLine("Nicely done bye! ");
                break;
                
            default:
                Console.WriteLine("Invalid Choice ");
                break;
                }
        }while (choice!= 6);
    }
}