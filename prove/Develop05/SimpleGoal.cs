using System;

public class SimpleGoal : Goal
{

    public SimpleGoal(string goalType, string GoalName, string description, int points) 
        : base(goalType, GoalName, description, points)
    {

    }

    public SimpleGoal(string goalType, string GoalName, string description, int points, bool isComplete) 
        : base(goalType, GoalName, description, points)
    {
        _isComplete = isComplete;
    }
        private void SetStringGoal()
    {
        if (GetIsComplete())
        {
            _stringGoal = "[X]";
        }
    }

    private void SetIsCompleted()
    {
        _isComplete = true;
    }
    public override SimpleGoal CreateNewGoal()
    {
        return new SimpleGoal(GetGoalType(),GetGoalName(),GetGoalDescription(),GetGoalpoints()); 
    }

    public override string DisplayGoal(int index)
    {
        return $"{index}. {GetStringGoal()} {GetGoalName()} ({GetGoalDescription()})";
    }
    public override string SaveGoals()
    {
        return $"{GetGoalType()},{GetGoalName()},{GetGoalDescription()},{GetGoalpoints()},{GetIsComplete()}";
    }

    // public override SimpleGoal LoadGoal(string goalType, string GoalName, string description, int points, bool isComplete)
    // {
    //     return new SimpleGoal(goalType,GoalName,description,points,isComplete); 
    // }
    public override void RecordEvent()
    {
        SetIsCompleted();
        SetStringGoal();
        
    }



}