using Godot;
using System;
using System.Collections.Generic;

public partial class Masterable
{
    public string name;
    public Type? parent;
    public Type type;
    public static readonly Dictionary<Type, Masterable> all = new()
    {
        // = Abilities =
        { Type.strength,  new("Strength", Type.strength)},
        { Type.dexterity,  new("Dexterity", Type.dexterity)},
        { Type.constitution,  new("Constitution", Type.constitution)},
        { Type.intelligence,  new("Intelligence", Type.intelligence)},
        { Type.wisdom,  new("Wisdom", Type.wisdom)},
        { Type.charisma,  new("Charisma", Type.charisma)},



        // = Skills =
        // Strength
        { Type.athletics,       new("Athletics",        Type.athletics,     Type.strength)},

        // Dexterity
        { Type.acrobatics,      new("Acrobatics",       Type.acrobatics,    Type.dexterity)},
        { Type.sleightOfHand,   new("Sleight of hand",  Type.sleightOfHand, Type.dexterity)},
        { Type.stealth,         new("Stealth",          Type.stealth,       Type.dexterity)},

        // Intelligence
        { Type.arcana,          new("Arcana",           Type.arcana,        Type.intelligence)},
        { Type.history,         new("History",          Type.history,       Type.intelligence)},
        { Type.investigation,   new("Investigation",    Type.investigation, Type.intelligence)},
        { Type.nature,          new("Nature",           Type.nature,        Type.intelligence)},
        { Type.religion,        new("Religion",         Type.religion,      Type.intelligence)},

        // Wisdom
        { Type.animalHandling,  new("Animal handling",  Type.animalHandling,Type.wisdom)},
        { Type.insight,         new("Insight",          Type.insight,       Type.wisdom)},
        { Type.medicine,        new("Medicine",         Type.medicine,      Type.wisdom)},
        { Type.perception,      new("Perception",       Type.perception,    Type.wisdom)},
        { Type.survival,        new("Survival",         Type.survival,      Type.wisdom)},

        // Charisma
        { Type.deception,       new("Deception",        Type.deception,     Type.charisma)},
        { Type.intimidation,    new("Intimidation",     Type.intimidation,  Type.charisma)},
        { Type.performance,     new("Performance",      Type.performance,   Type.charisma)},
        { Type.persuasion,      new("Persuasion",       Type.persuasion,    Type.charisma)},
    };

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
        //all.Add(type, this);
    }
    #nullable disable

    public bool IsSkill()
    {
        return parent != null;
    }

    public static Masterable Get(Type type)
    {
        return all[type];
    }
}
