using Godot;
using System;
using System.Collections.Generic;

public partial class Ability
{
    private static Dictionary<Type, string> names;
    public enum Type
    {
        strength,
        dexterity,
        constitution,
        intelligence,
        wisdom,
        charisma
    }

    static Ability()
    {
        InitNames();
    }





    private static void InitNames()
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
