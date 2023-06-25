using System;

public abstract class Goal
{
    private string _goalType;
    private string _goalName;
    private string _description;
    protected int _points;
    protected bool _isComplete;
    protected string _stringGoal;

    public Goal (string goalType, string goalName, string description, int points)
    {
        _goalType = goalType;
        _goalName= goalName;
        _description = description;
        _points = points;
        _isComplete = false;
        _stringGoal = "[ ]";
        
    }

    public string GetStringGoal()
    {
        return _stringGoal;
    }
    public string GetGoalType()
    {
        return _goalType;
    }

    public bool GetIsComplete()
    {
        return _isComplete;
    }

    public string GetGoalName()
    {
        return _goalName;
    }
    public string GetGoalDescription()
    {
        return _description;
    }
    public int GetGoalpoints()
    {
        return _points;
    }

    public abstract Goal CreateNewGoal();

    public abstract string DisplayGoal(int index);

    public abstract string SaveGoals();
    
    public abstract void RecordEvent();

}