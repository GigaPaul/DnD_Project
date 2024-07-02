using Godot;
using System;
using System.Collections.Generic;

public partial class Ability
{
    public enum Type
    {
        strength,
        dexterity,
        constitution,
        intelligence,
        wisdom,
        charisma
    }

    private static Dictionary<Type, string> names;

    static Ability()
    {
        names = new()
        {
            { Type.strength, "Force" },
            { Type.dexterity, "Dextérité" },
            { Type.constitution, "Constitution" },
            { Type.intelligence, "Intelligence" },
            { Type.wisdom, "Sagesse" },
            { Type.charisma, "Charisme" }
        };
    }

    public static string GetName(Type type)
    {
        return names[type];
    }
}
