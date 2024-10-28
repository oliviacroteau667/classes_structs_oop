using System;

public class Adventurer
{
    public string name;
    public int exp = 0;

    public Adventurer()
    {
        name = "Not assigned";
        Reset();
    }

    public Adventurer(string name)
    {
        this.name = name;
    }

    public virtual void PrintStatsInfo()
    {
        Console.WriteLine($"Adventurer: {this.name} - {this.exp} EXP");
    }
    private void Reset()
    {
        this.name = "Not assigned";
        this.exp = 0;
    }
}
