using Godot;
using System;
using System.Collections.Generic;

public partial class Masterable
{
    // = CONST =
    public static readonly Dictionary<Type, Masterable> global = new();
    public static readonly List<Type> skills = new();
    public static readonly List<Type> abilities = new();
    public static readonly List<Type> weapons = new();
    public static readonly List<Type> armors = new();
    public static readonly List<Type> tools = new();





    // = VARIABLES =
    public string name;
    public Type? parent;
    //public Type type;





    // = ENUMS =
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
        simpleWeapons,
        martialWeapons,
        improvisedWeapons,

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





    // = CONSTRUCTORS =
    static Masterable()
    {
        InitGlobal();
        InitAbilities();
        InitSkills();
        InitWeapons();
        InitArmors();
        InitTools();
    }

    #nullable enable
    //public Masterable(string name, Type type, Type? parent = null)
    public Masterable(string name, Type? parent = null)
    {
        this.name = name;
        this.parent = parent;
    }
    #nullable disable





    // = METHODS =
    // Public methods
    public bool IsSkill()
    {
        return parent != null;
    }

    public static Dictionary<Type, bool> GetBlankProficiencyTable()
    {
        Dictionary<Type, bool> result = new();

        int count = Enum.GetNames(typeof(Type)).Length;
        for (int i = 0; i < count; i++)
        {
            Type type = (Type)i;
            result.Add(type, false);
        }

        return result;
    }










    // Protected methods










    // Private methods
    private static void InitGlobal()
    {
        // = Abilities =
        global.Add(Type.strength,           new("Strength"));
        global.Add(Type.dexterity,          new("Dexterity"));
        global.Add(Type.constitution,       new("Constitution"));
        global.Add(Type.intelligence,       new("Intelligence"));
        global.Add(Type.wisdom,             new("Wisdom"));
        global.Add(Type.charisma,           new("Charisma"));



        // = Skills =
        // Strength
        global.Add(Type.athletics,          new("Athletics",        Type.strength));

        // Dexterity
        global.Add(Type.acrobatics,         new("Acrobatics",       Type.dexterity));
        global.Add(Type.sleightOfHand,      new("Sleight of hand",  Type.dexterity));
        global.Add(Type.stealth,            new("Stealth",          Type.dexterity));

        // Intelligence
        global.Add(Type.arcana,             new("Arcana",           Type.intelligence));
        global.Add(Type.history,            new("History",          Type.intelligence));
        global.Add(Type.investigation,      new("Investigation",    Type.intelligence));
        global.Add(Type.nature,             new("Nature",           Type.intelligence));
        global.Add(Type.religion,           new("Religion",         Type.intelligence));

        // Wisdom
        global.Add(Type.animalHandling,     new("Animal handling",  Type.wisdom));
        global.Add(Type.insight,            new("Insight",          Type.wisdom));
        global.Add(Type.medicine,           new("Medicine",         Type.wisdom));
        global.Add(Type.perception,         new("Perception",       Type.wisdom));
        global.Add(Type.survival,           new("Survival",         Type.wisdom));

        // Charisma
        global.Add(Type.deception,          new("Deception",        Type.charisma));
        global.Add(Type.intimidation,       new("Intimidation",     Type.charisma));
        global.Add(Type.performance,        new("Performance",      Type.charisma));
        global.Add(Type.persuasion,         new("Persuasion",       Type.charisma));



        // = Weapons =
        global.Add(Type.simpleWeapons,      new("Simple weapons"));
        global.Add(Type.martialWeapons,     new("Martial weapons"));
        global.Add(Type.improvisedWeapons,  new("Improvised weapons"));



        // = Armors =
        global.Add(Type.clothing,           new("Clothing"));
        global.Add(Type.lightArmor,         new("Light armor"));
        global.Add(Type.mediumArmor,        new("Medium armor"));
        global.Add(Type.heavyArmor,         new("Heavy armor"));
        global.Add(Type.shield,             new("Shield"));



        // = Tools =
        global.Add(Type.artisanTool,        new("Artisan's tool"));
        global.Add(Type.disguiseKit,        new("Disguise kit"));
        global.Add(Type.forgeryKit,         new("Forgery kit"));
        global.Add(Type.gamingSet,          new("Gaming set"));
        global.Add(Type.herbalismSet,       new("Herbalism set"));
        global.Add(Type.musicalInstrument,  new("Musical instrument"));
        global.Add(Type.navigatorTool,      new("Navigator's tool"));
        global.Add(Type.poisonerKit,        new("Poisoner's kit"));
        global.Add(Type.thieveTool,         new("Thieve's tool"));
        global.Add(Type.landVehicle,        new("Land vehicle"));
        global.Add(Type.waterVehicle,       new("Water vehicle"));
    }

    private static void InitSkills()
    {
        skills.Add(Type.strength);
        skills.Add(Type.dexterity);
        skills.Add(Type.constitution);
        skills.Add(Type.intelligence);
        skills.Add(Type.wisdom);
        skills.Add(Type.charisma);
    }

    private static void InitAbilities()
    {
        // Strength
        abilities.Add(Type.athletics);

        // Dexterity
        abilities.Add(Type.acrobatics);
        abilities.Add(Type.sleightOfHand);
        abilities.Add(Type.stealth);

        // Intelligence
        abilities.Add(Type.arcana);
        abilities.Add(Type.history);
        abilities.Add(Type.investigation);
        abilities.Add(Type.nature);
        abilities.Add(Type.religion);

        // Wisdom
        abilities.Add(Type.animalHandling);
        abilities.Add(Type.insight);
        abilities.Add(Type.medicine);
        abilities.Add(Type.perception);
        abilities.Add(Type.survival);

        // Charisma
        abilities.Add(Type.deception);
        abilities.Add(Type.intimidation);
        abilities.Add(Type.performance);
        abilities.Add(Type.persuasion);
    }

    private static void InitWeapons()
    {
        weapons.Add(Type.simpleWeapons);
        weapons.Add(Type.martialWeapons);
        weapons.Add(Type.improvisedWeapons);
    }

    private static void InitArmors()
    {
        armors.Add(Type.clothing);
        armors.Add(Type.lightArmor);
        armors.Add(Type.mediumArmor);
        armors.Add(Type.heavyArmor);
        armors.Add(Type.shield);
    }

    private static void InitTools()
    {
        tools.Add(Type.artisanTool);
        tools.Add(Type.disguiseKit);
        tools.Add(Type.forgeryKit);
        tools.Add(Type.gamingSet);
        tools.Add(Type.herbalismSet);
        tools.Add(Type.musicalInstrument);
        tools.Add(Type.navigatorTool);
        tools.Add(Type.poisonerKit);
        tools.Add(Type.thieveTool);
        tools.Add(Type.landVehicle);
        tools.Add(Type.waterVehicle);
    }
}
