using Godot;
using System;

public partial class Bonus
{
    public Masterable.Type type;
    public int bonus;
    public bool show;

    public Bonus(Masterable.Type type, int bonus, bool show = true)
    {
        this.type = type;
        this.bonus = bonus;
        this.show = show;
    }
}
