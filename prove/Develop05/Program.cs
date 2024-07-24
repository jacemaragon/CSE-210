using System;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            GoalManager manager = new GoalManager();

            manager.CreateGoal(new SimpleGoal("Run Marathon", "Complete a marathon", 1000));
            manager.CreateGoal(new EternalGoal("Read Scriptures", "Read scriptures daily", 100));
            manager.CreateGoal(new ChecklistGoal("Attend Temple", "Attend the temple 10 times", 50, 10, 500));

            manager.Start();
        }
    }
}