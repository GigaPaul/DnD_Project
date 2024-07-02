using Godot;
using System;
using System.Collections.Generic;

public partial class Masterable
{
    public string name;
    public Type? parent;
    public Type type;
    public static Dictionary<Type, Masterable> all = new();

    public enum Type
    {
        strength,
        dexterity,
        constitution,
        intelligence,
        wisdom,
        charisma,
        acrobatics,
        animalHandling,
        arcana,
        athletics,
        deception,
        history,
        insight,
        intimidation,
        investigation,
        medicine,
        nature,
        perception,
        performance,
        persuasion,
        religion,
        sleightOfHand,
        stealth,
        survival
    }

    #nullable enable
    public Masterable(string name, Type type, Type? parent = null)
    {
        this.name = name;
        this.type = type;
        this.parent = parent;
        all.Add(type, this);
    }
    #nullable disable

    public bool IsSkill()
    {
        return parent != null;
    }

    public static Masterable Get(Type type)
    {
        GD.Print(type);
        return all[type];
    }
}
