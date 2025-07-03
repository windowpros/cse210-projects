using System;
using System.Collections.Generic;
using System.IO;

// class GoalsssManager
// {
//     List<Goal> _goalsList;
//     String _fileName;
//     int _totalScore;




// }





public class GoalManager
{
    private List<Goal> _goalsList = new List<Goal>();
    private int _totalScore = 0;

    public void AddGoal(Goal goal)
    {
        _goalsList.Add(goal);
    }

    public void RecordEvent(int index)
    {
        int pointsEarned = _goalsList[index].RecordEvent();
        _totalScore += pointsEarned;
        Console.WriteLine($"Event recorded! You earned {pointsEarned} points.");
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Your Goals:");
        for (int i = 0; i < _goalsList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goalsList[i].GetDisplayString()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Your Total Score: {_totalScore}");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_totalScore); // Save score first

            foreach (Goal goal in _goalsList)
            {
                if (goal is SimpleGoal)
                {
                    writer.WriteLine($"SimpleGoal#{goal.GetName()}#{goal.GetDescription()}#{goal.GetPoints()}#{goal.GetStatus()}");
                }
                else if (goal is EternalGoal)
                {
                    writer.WriteLine($"EternalGoal#{goal.GetName()}#{goal.GetDescription()}#{goal.GetPoints()}#{goal.GetStatus()}");
                }
                else if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine($"ChecklistGoal#{checklistGoal.GetName()}#{checklistGoal.GetDescription()}#{checklistGoal.GetPoints()}#{checklistGoal.GetStatus()}#{checklistGoal.GetTimesCompleted()}#{checklistGoal.GetTargetCount()}#{checklistGoal.GetBonusPoints()}");
                }
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);

            _goalsList.Clear();

            if (lines.Length > 0)
            {
                _totalScore = int.Parse(lines[0]);

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split('#');

                    string type = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    bool status = bool.Parse(parts[4]);

                    if (type == "SimpleGoal")
                    {
                        SimpleGoal sg = new SimpleGoal(name, description, points);
                        sg.SetStatus(status);
                        _goalsList.Add(sg);
                    }
                    else if (type == "EternalGoal")
                    {
                        EternalGoal eg = new EternalGoal(name, description, points);
                        _goalsList.Add(eg);
                    }
                    else if (type == "ChecklistGoal")
                    {
                        int timesCompleted = int.Parse(parts[5]);
                        int targetCount = int.Parse(parts[6]);
                        int bonusPoints = int.Parse(parts[7]);

                        ChecklistGoal cg = new ChecklistGoal(name, description, points, targetCount, bonusPoints);
                        cg.SetStatus(status);
                        cg.SetTimesCompleted(timesCompleted);

                        _goalsList.Add(cg);
                    }
                }

                Console.WriteLine("Goals loaded successfully.");
            }
            else
            {
                Console.WriteLine("File is empty.");
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
