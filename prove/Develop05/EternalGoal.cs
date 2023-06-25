using System;

public class EternalGoal : Goal
{
    public EternalGoal(string goalType, string GoalName, string description, int points) 
        : base(goalType, GoalName, description, points)
    {
        
    }
    
    public override EternalGoal CreateNewGoal()
    {
        return new EternalGoal(GetGoalType(),GetGoalName(),GetGoalDescription(),GetGoalpoints()); 
    }

    public override string DisplayGoal(int index)
    {
        return $"{index}. {GetStringGoal()} {GetGoalName()} ({GetGoalDescription()})";
    }

        public override string SaveGoals()
    {
        return $"{GetGoalType()},{GetGoalName()},{GetGoalDescription()},{GetGoalpoints()}";
    }

    public override void RecordEvent()
    {
        
    }

    
}