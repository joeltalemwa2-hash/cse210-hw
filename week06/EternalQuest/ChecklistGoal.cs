public class ChecklistGoal : Goal
{
    private int _count;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string desc, int points, int target, int bonus)
        : base(name, desc, points)
    {
        _target = target;
        _bonus = bonus;
        _count = 0;
    }

    public override int RecordEvent()
    {
        _count++;
        int points = GetPoints();

        if (_count == _target)
        {
            points += _bonus;
        }

        return points;
    }

    public override bool IsComplete()
    {
        return _count >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{(IsComplete() ? "[X]" : "[ ]")} {GetName()} ({GetDescription()}) -- {_count}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetName()},{GetDescription()},{GetPoints()},{_count},{_target},{_bonus}";
    }
}