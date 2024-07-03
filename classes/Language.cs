using Godot;
using System;
using System.Collections.Generic;

public partial class Language
{
    // = CONST =
    public static readonly Dictionary<Family, Language> global = new();
    public static readonly List<Language> standardLanguages = new();





    // = VARIABLES =
    public string name;
    public Script? script;





    // = ENUMS =
    public enum Family
    {
        common,
        dwarvish,
        elvish,
        giant,
        gnomish,
        goblin,
        halfling,
        orc,
        abyssal,
        celestial,
        draconic,
        deepSpeech,
        infernal,
        primordial,
        sylvan,
        undercommon
    }

    public enum Script
    {
        common,
        dwarvish,
        elvish,
        infernal,
        celestial,
        draconic
    }





    // = CONSTRUCTORS =
    static Language()
    {
        // Languages
        global.Add(Family.common,       new("Common",       Script.common));
        global.Add(Family.dwarvish,     new("Dwarvish",     Script.dwarvish));
        global.Add(Family.elvish,       new("Elvish",       Script.elvish));
        global.Add(Family.giant,        new("Giant",        Script.dwarvish));
        global.Add(Family.gnomish,      new("Gnomish",      Script.dwarvish));
        global.Add(Family.goblin,       new("Goblin",       Script.dwarvish));
        global.Add(Family.halfling,     new("Halfling",     Script.common));
        global.Add(Family.orc,          new("Orc",          Script.dwarvish));
        global.Add(Family.abyssal,      new("Abyssal",      Script.infernal));
        global.Add(Family.celestial,    new("Celestial",    Script.celestial));
        global.Add(Family.draconic,     new("Draconic",     Script.draconic));
        global.Add(Family.deepSpeech,   new("Deep Speech"));
        global.Add(Family.infernal,     new("Infernal",     Script.infernal));
        global.Add(Family.primordial,   new("Primordial",   Script.dwarvish));
        global.Add(Family.sylvan,       new("Sylvan",       Script.elvish));
        global.Add(Family.undercommon,  new("Undercommon",  Script.elvish));

        // Standard Languages
        standardLanguages.Add(global[Family.common]);
        standardLanguages.Add(global[Family.dwarvish]);
        standardLanguages.Add(global[Family.elvish]);
        standardLanguages.Add(global[Family.giant]);
        standardLanguages.Add(global[Family.gnomish]);
        standardLanguages.Add(global[Family.goblin]);
        standardLanguages.Add(global[Family.halfling]);
        standardLanguages.Add(global[Family.orc]);
    }

    public Language(string name, Script? script = null)
    {
        this.name = name;
        this.script = script;
    }




    // = METHODS =
    // Public methods
    public bool IsStandard()
    {
        return standardLanguages.Contains(this);
    }
}
