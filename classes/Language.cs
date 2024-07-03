using Godot;
using System;
using System.Collections.Generic;

public partial class Language
{
    public string name;
    public Script? script;

    public static Dictionary<Family, Language> Global;

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

    static Language()
    {
        Global = new()
        {
            { Family.common,        new("Common",       Script.common) },
            { Family.dwarvish,      new("Dwarvish",     Script.dwarvish) },
            { Family.elvish,        new("Elvish",       Script.elvish) },
            { Family.giant,         new("Giant",        Script.dwarvish) },
            { Family.gnomish,       new("Gnomish",      Script.dwarvish) },
            { Family.goblin,        new("Goblin",       Script.dwarvish) },
            { Family.halfling,      new("Halfling",     Script.common) },
            { Family.orc,           new("Orc",          Script.dwarvish) },
            { Family.abyssal,       new("Abyssal",      Script.infernal) },
            { Family.celestial,     new("Celestial",    Script.celestial) },
            { Family.draconic,      new("Draconic",     Script.draconic) },
            { Family.deepSpeech,    new("Deep Speech") },
            { Family.infernal,      new("Infernal",     Script.infernal) },
            { Family.primordial,    new("Primordial",   Script.dwarvish) },
            { Family.sylvan,        new("Sylvan",       Script.elvish) },
            { Family.undercommon,   new("Undercommon",  Script.elvish) },
        };
    }

    public Language(string name, Script? script = null)
    {
        this.name = name;
        this.script = script;
    }


}
