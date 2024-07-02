using Godot;
using System;
using System.Collections.Generic;

public partial class Skill : Ability
{
    private static Dictionary<Type, string> names;
    private static Dictionary<Type, Ability.Type> parents;

    new public enum Type
    {
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

    static Skill()
    {
        InitNames();
        InitParents();
    }





    private static void InitNames()
    {
        names = new()
        {
            { Type.acrobatics, "Acrobaties" },
            { Type.animalHandling, "Dressage" },
            { Type.arcana, "Arcanes" },
            { Type.athletics, "Athlétisme" },
            { Type.deception, "Tromperie" },
            { Type.history, "Histoire" },
            { Type.insight, "Intuition" },
            { Type.intimidation, "Intimidation" },
            { Type.investigation, "Investigation" },
            { Type.medicine, "Médecine" },
            { Type.nature, "Nature" },
            { Type.perception, "Perception" },
            { Type.performance, "Représentation" },
            { Type.persuasion, "Persuasion" },
            { Type.religion, "Religion" },
            { Type.sleightOfHand, "Escamotage" },
            { Type.stealth, "Discrétion" },
            { Type.survival, "Survie" }
        };
    }





    private static void InitParents()
    {
        parents = new()
        {
            { Type.acrobatics, Ability.Type.dexterity },
            { Type.animalHandling, Ability.Type.wisdom },
            { Type.arcana, Ability.Type.intelligence },
            { Type.athletics, Ability.Type.strength },
            { Type.deception, Ability.Type.charisma },
            { Type.history, Ability.Type.intelligence },
            { Type.insight, Ability.Type.wisdom },
            { Type.intimidation, Ability.Type.charisma },
            { Type.investigation, Ability.Type.intelligence },
            { Type.medicine, Ability.Type.wisdom },
            { Type.nature, Ability.Type.intelligence },
            { Type.perception, Ability.Type.wisdom },
            { Type.performance, Ability.Type.charisma },
            { Type.persuasion, Ability.Type.charisma },
            { Type.religion, Ability.Type.intelligence },
            { Type.sleightOfHand, Ability.Type.dexterity },
            { Type.stealth, Ability.Type.dexterity },
            { Type.survival, Ability.Type.wisdom }
        };
    }





    public static string GetName(Type type)
    {
        return names[type];
    }





    public static Ability.Type GetParent(Type type)
    {
        return parents[type];
    }
}
