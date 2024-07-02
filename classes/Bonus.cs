using Godot;
using System;

public partial class Bonus
{
    public Ability.Type type;
    public int bonus;
    public bool show;

    public Bonus(Ability.Type type, int bonus, bool show = true)
    {
        this.type = type;
        this.bonus = bonus;
        this.show = show;
    }
}
