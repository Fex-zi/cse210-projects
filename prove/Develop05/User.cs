using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EternalQuest
{
    public class User
    {
        private int score;
        private List<Goal> goals;
        private readonly string saveFile = "goals.txt";

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public List<Goal> Goals
        {
            get { return goals; }
            set { goals = value; }
        }

        public User()
        {
            Goals = new List<Goal>();
        }

        public void AddGoal(string goalType)
    {
    switch (goalType)
        {
            case "Simple":
                SimpleGoal simpleGoal = new SimpleGoal();
                Console.WriteLine("Enter goal name: ");
                simpleGoal.Name = Console.ReadLine();
                Console.WriteLine("Enter target amount: ");
                simpleGoal.TargetAmount = int.Parse(Console.ReadLine());
                goals.Add(simpleGoal);
                break;
            case "Eternal":
                EternalGoal eternalGoal = new EternalGoal();
                Console.WriteLine("Enter goal name: ");
                eternalGoal.Name = Console.ReadLine();
                Console.WriteLine("Enter bonus value: ");
                eternalGoal.BonusValue = int.Parse(Console.ReadLine());
                goals.Add(eternalGoal);
                break;
            case "Checklist":
                ChecklistGoal checklistGoal = new ChecklistGoal();
                Console.WriteLine("Enter goal name: ");
                checklistGoal.Name = Console.ReadLine();
                Console.WriteLine("Enter value of each item: ");
                checklistGoal.Value = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number of items: ");
                checklistGoal.Items = int.Parse(Console.ReadLine());
                goals.Add(checklistGoal);
                break;
        }
    }
    public void RecordEvent(string goalName)
    {
            foreach (Goal goal in Goals)
            {
                if (goal.Name == goalName)
                {
                    if (goal is SimpleGoal || goal is EternalGoal)
                    {
                        goal.IsComplete = true;
                        Score += goal.Value;
                        break;
                    }
                    else if (goal is ChecklistGoal)
                    {
                        goal.TimesCompleted++;
                        Score += goal.Value;
                        if (goal.TimesCompleted == goal.TargetAmount)
                        {
                            goal.IsComplete = true;
                            Score += goal.BonusValue;
                        }
                        break;
                    }
                }
            }
    }

    public void ShowGoals()
    {
            Console.WriteLine("Goals:");
            foreach (Goal goal in Goals)
            {
                if (goal is SimpleGoal)
                {
                    if (goal.IsComplete)
                    {
                        Console.WriteLine("[X] {0}", goal.Name);
                    }
                    else
                    {
                        Console.WriteLine("[ ] {0}", goal.Name);
                    }
                }
                else if (goal is EternalGoal)
                {
                    Console.WriteLine("[E] {0} ({1} completed)", goal.Name, goal.TimesCompleted);
                }
                else if (goal is ChecklistGoal)
                {
                    Console.WriteLine("[C] {0} ({1}/{2})", goal.Name, goal.TimesCompleted, goal.TargetAmount);
                }
            }
    }
        // Save goals to a text file
    public void SaveGoals()
    {
            using (StreamWriter writer = new StreamWriter("goals.txt"))
            {
                foreach (Goal goal in goals)
                {
                    writer.WriteLine(goal.ToString());
                }
            }
    }

        // Load goals from a text file
    private void LoadGoals()
        {
            // Open the file for reading
            using (StreamReader reader = new StreamReader(saveFile))
            {
                // Read the file line by line
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(',');

                    // Create a new goal based on the first part of the line
                    switch (parts[0])
                    {
                        case "Simple":
                            SimpleGoal simpleGoal = new SimpleGoal();
                            simpleGoal.Name = parts[1];
                            simpleGoal.Value = int.Parse(parts[2]);
                            simpleGoal.IsComplete = bool.Parse(parts[3]);
                            goals.Add(simpleGoal);
                            break;
                        case "Eternal":
                            EternalGoal eternalGoal = new EternalGoal();
                            eternalGoal.Name = parts[1];
                            eternalGoal.Value = int.Parse(parts[2]);
                            goals.Add(eternalGoal);
                            break;
                        case "Checklist":
                            ChecklistGoal checklistGoal = new ChecklistGoal();
                            checklistGoal.Name = parts[1];
                            checklistGoal.Value = int.Parse(parts[2]);
                            checklistGoal.TargetAmount = int.Parse(parts[3]);
                            checklistGoal.BonusValue = int.Parse(parts[4]);
                            checklistGoal.TimesCompleted = int.Parse(parts[5]);
                            goals.Add(checklistGoal);
                            break;
                    }
                }
            }
    }
    }
}