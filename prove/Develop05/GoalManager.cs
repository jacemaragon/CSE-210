using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    public class GoalManager
    {
        private List<Goal> _goals;
        private int _score;

        public GoalManager()
        {
            _goals = new List<Goal>();
            _score = 0;
        }

        public void Start()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Eternal Quest Menu:");
                Console.WriteLine("1. Display Goals");
                Console.WriteLine("2. Record Event");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");
                string option = Console.ReadLine();
                
                switch (option)
                {
                    case "1":
                        DisplayPlayerInfo();
                        break;
                    case "2":
                        Console.Write("Enter goal name to record event: ");
                        string name = Console.ReadLine();
                        RecordEvent(name);
                        break;
                    case "3":
                        Console.Write("Enter filename to save: ");
                        string saveFile = Console.ReadLine();
                        SaveGoals(saveFile);
                        break;
                    case "4":
                        Console.Write("Enter filename to load: ");
                        string loadFile = Console.ReadLine();
                        LoadGoals(loadFile);
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"Score: {_score}");
            ListGoalDetails();
        }

        public void ListGoalNames()
        {
            foreach (var goal in _goals)
            {
                Console.WriteLine(goal.GetDetailsString());
            }
        }

        public void ListGoalDetails()
        {
            foreach (var goal in _goals)
            {
                Console.WriteLine(goal.GetDetailsString());
            }
        }

        public void CreateGoal(Goal goal)
        {
            _goals.Add(goal);
        }

        public void RecordEvent(string goalName)
        {
            var goal = _goals.Find(g => g.GetDetailsString().Contains(goalName));
            if (goal != null)
            {
                goal.RecordEvent();
                if (!goal.IsComplete())
                {
                    _score += goal.Points;
                }
            }
            else
            {
                Console.WriteLine("Goal not found.");
            }
        }

        public void SaveGoals(string filename)
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (var goal in _goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }
        }

        public void LoadGoals(string filename)
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split(':');
                string type = parts[0];
                string[] details = parts[1].Split(',');

                string name = details[0];
                string description = details[1];
                int points = int.Parse(details[2]);

                if (type == "SimpleGoal")
                {
                    bool isComplete = bool.Parse(details[3]);
                    var goal = new SimpleGoal(name, description, points);
                    if (isComplete) goal.RecordEvent();
                    _goals.Add(goal);
                }
                else if (type == "EternalGoal")
                {
                    var goal = new EternalGoal(name, description, points);
                    _goals.Add(goal);
                }
                else if (type == "ChecklistGoal")
                {
                    int amountCompleted = int.Parse(details[3]);
                    int target = int.Parse(details[4]);
                    int bonus = int.Parse(details[5]);
                    bool isComplete = bool.Parse(details[6]);

                    var goal = new ChecklistGoal(name, description, points, target, bonus);
                    for (int i = 0; i < amountCompleted; i++) goal.RecordEvent();
                    _goals.Add(goal);
                }
            }
        }
    }
}