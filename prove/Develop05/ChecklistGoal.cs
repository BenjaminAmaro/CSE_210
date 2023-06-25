using System;

public  class ChecklistGoal : Goal
{
    private int _times;
    private int _numbersOfCompletedGoal;
    private int _bonus;

    public ChecklistGoal(string goalType, string GoalName, string description, int points, int times, int bonus) 
        : base(goalType, GoalName, description, points)
    {
        _times = times;

        _bonus = bonus;

        _numbersOfCompletedGoal = 0; 

    }
    public ChecklistGoal(string goalType, string GoalName, string description, int points, int numbersOfCompletedGoal, int times, int bonus) 
    : base(goalType, GoalName, description, points)
    {


        _times = times;

        _bonus = bonus;

        _numbersOfCompletedGoal = numbersOfCompletedGoal;

    }

    public int GetTimes()
    {
        return _times;
    }

    public int GetBonus()
    {
        return _bonus;
    }
    public int GetNumberOfCompletedGoal()
    {
        return _numbersOfCompletedGoal;
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
        if (GetNumberOfCompletedGoal() == GetTimes())
        {
            _isComplete = true;
        }
    }

    public override ChecklistGoal CreateNewGoal()
    {
        return new ChecklistGoal(GetGoalType(),GetGoalName(),GetGoalDescription(),GetGoalpoints(),GetTimes(),GetBonus()); 

        // 
    }


    public override string DisplayGoal(int index)
    {
        return $"{index}. {GetStringGoal()} {GetGoalName()} ({GetGoalDescription()}) -- completed {GetNumberOfCompletedGoal()}/{GetTimes()}";

    }

        public override string SaveGoals()
    {
        return $"{GetGoalType()},{GetGoalName()},{GetGoalDescription()},{GetGoalpoints()},{GetBonus()},{GetTimes()},{GetNumberOfCompletedGoal()}";

    }

    // public override ChecklistGoal LoadGoal(string goalType, string GoalName, string description, int points, bool isComplete)
    // {
    //     return CreateNewGoal();

    // }

    public override void RecordEvent()
    {
        _numbersOfCompletedGoal++;
        SetIsCompleted();
        SetStringGoal();
        
        if (GetIsComplete())
        {
            _points += _bonus;
        }
        
        
    }

}