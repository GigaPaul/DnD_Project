using Godot;
using System;
using System.Collections.Generic;

public partial class Masterable
{
    public string name;
    public Type? parent;
    public Type type;

    static Masterable()
    {
        GD.Print("Test");
    }





    public static readonly Dictionary<Type, Masterable> all = new()
    {
        // = Abilities =
        { Type.strength,            new("Strength", Type.strength)},
        { Type.dexterity,           new("Dexterity", Type.dexterity)},
        { Type.constitution,        new("Constitution", Type.constitution)},
        { Type.intelligence,        new("Intelligence", Type.intelligence)},
        { Type.wisdom,              new("Wisdom", Type.wisdom)},
        { Type.charisma,            new("Charisma", Type.charisma)},



        // = Skills =
        // Strength
        { Type.athletics,           new("Athletics",            Type.athletics,     Type.strength)},

        // Dexterity
        { Type.acrobatics,          new("Acrobatics",           Type.acrobatics,    Type.dexterity)},
        { Type.sleightOfHand,       new("Sleight of hand",      Type.sleightOfHand, Type.dexterity)},
        { Type.stealth,             new("Stealth",              Type.stealth,       Type.dexterity)},

        // Intelligence
        { Type.arcana,              new("Arcana",               Type.arcana,        Type.intelligence)},
        { Type.history,             new("History",              Type.history,       Type.intelligence)},
        { Type.investigation,       new("Investigation",        Type.investigation, Type.intelligence)},
        { Type.nature,              new("Nature",               Type.nature,        Type.intelligence)},
        { Type.religion,            new("Religion",             Type.religion,      Type.intelligence)},

        // Wisdom
        { Type.animalHandling,      new("Animal handling",      Type.animalHandling,Type.wisdom)},
        { Type.insight,             new("Insight",              Type.insight,       Type.wisdom)},
        { Type.medicine,            new("Medicine",             Type.medicine,      Type.wisdom)},
        { Type.perception,          new("Perception",           Type.perception,    Type.wisdom)},
        { Type.survival,            new("Survival",             Type.survival,      Type.wisdom)},

        // Charisma
        { Type.deception,           new("Deception",            Type.deception,     Type.charisma)},
        { Type.intimidation,        new("Intimidation",         Type.intimidation,  Type.charisma)},
        { Type.performance,         new("Performance",          Type.performance,   Type.charisma)},
        { Type.persuasion,          new("Persuasion",           Type.persuasion,    Type.charisma)},



        // = Weapons =
        { Type.simpleWeapon,        new("Simple weapons",       Type.simpleWeapon)},
        { Type.martialWeapon,       new("Martial weapons",      Type.martialWeapon)},
        { Type.improvisedWeapon,    new("Improvised weapons",   Type.improvisedWeapon)},



        // = Armors =
        { Type.clothing,            new("Clothing",             Type.clothing)},
        { Type.lightArmor,          new("Light armor",          Type.lightArmor)},
        { Type.mediumArmor,         new("Medium armor",         Type.mediumArmor)},
        { Type.heavyArmor,          new("Heavy armor",          Type.heavyArmor)},
        { Type.shield,              new("Shield",               Type.shield)},



        // = Tools =
        { Type.artisanTool,         new("Clothing",             Type.clothing)},
        { Type.disguiseKit,         new("Light armor",          Type.lightArmor)},
        { Type.forgeryKit,          new("Medium armor",         Type.mediumArmor)},
        { Type.gamingSet,           new("Heavy armor",          Type.heavyArmor)},
        { Type.herbalismSet,        new("Shield",               Type.shield)},
        { Type.musicalInstrument,   new("Shield",               Type.shield)},
        { Type.navigatorTool,       new("Shield",               Type.shield)},
        { Type.poisonerKit,         new("Shield",               Type.shield)},
        { Type.thieveTool,          new("Shield",               Type.shield)},
        { Type.landVehicle,         new("Shield",               Type.shield)},
        { Type.waterVehicle,        new("Shield",               Type.shield)},
    };





    public static readonly List<Type> skills = new() {
        Type.strength,
        Type.dexterity,
        Type.constitution,
        Type.intelligence,
        Type.wisdom,
        Type.charisma
    };





    public static readonly List<Type> abilities = new()
    {
        // Strength
        Type.athletics,
        Type.sleightOfHand,

        // Dexterity
        Type.acrobatics,
        Type.sleightOfHand,
        Type.stealth,

        // Intelligence
        Type.arcana,
        Type.history,
        Type.investigation,
        Type.nature,
        Type.religion,

        // Intelligence
        Type.arcana,
        Type.history,
        Type.investigation,
        Type.nature,
        Type.religion,

        // Wisdom
        Type.animalHandling,
        Type.insight,
        Type.medicine,
        Type.perception,
        Type.survival,

        // Charisma
        Type.deception,
        Type.intimidation,
        Type.performance,
        Type.persuasion
    };





    public static readonly List<Type> weapons = new()
    {
        Type.simpleWeapon,
        Type.martialWeapon,
        Type.improvisedWeapon
    };





    public static readonly List<Type> armors = new()
    {
        Type.clothing,
        Type.lightArmor,
        Type.mediumArmor,
        Type.heavyArmor,
        Type.shield
    };





    public static readonly List<Type> tools = new()
    {
        Type.artisanTool,
        Type.disguiseKit,
        Type.forgeryKit,
        Type.gamingSet,
        Type.herbalismSet,
        Type.musicalInstrument,
        Type.navigatorTool,
        Type.poisonerKit,
        Type.thieveTool,
        Type.landVehicle,
        Type.waterVehicle
    };





    public enum Type
    {
        // Abilities
        strength,
        dexterity,
        constitution,
        intelligence,
        wisdom,
        charisma,

        // Skills
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
        survival,

        // Weapons
        simpleWeapon,
        martialWeapon,
        improvisedWeapon,

        // Armors
        clothing,
        lightArmor,
        mediumArmor,
        heavyArmor,
        shield,

        // Tools
        artisanTool,
        disguiseKit,
        forgeryKit,
        gamingSet,
        herbalismSet,
        musicalInstrument,
        navigatorTool,
        poisonerKit,
        thieveTool,
        landVehicle,
        waterVehicle,
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
