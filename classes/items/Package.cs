using Godot;
using System;
using System.Collections.Generic;

public partial class Package
{
    public string name;
    public List<Item> items;
    public static readonly Dictionary<Prefab, Package> prefabs = new();

    public enum Prefab
    {
        acolyte,
        charlatan,
        criminal,
        entertainer,
        folkHero,
        gladiator,
        guildArtisan,
        hermit,
        knight,
        noble,
        outlander,
        pirate,
        sage,
        sailor,
        soldier,
        urchin,
        burglarPack,
        diplomatPack,
        dungeoneerPack,
        entertainerPack,
        explorerPack,
        priestPack,
        scholarPack
    }

    static Package()
    {
        // Acolyte
        prefabs.Add(Prefab.acolyte,         new("Acolyte"));

        // Charlatan
        prefabs.Add(Prefab.charlatan,       new("Charlatan"));

        // Criminal
        prefabs.Add(Prefab.criminal,        new("Criminal"));

        // Entertainer
        prefabs.Add(Prefab.entertainer,     new("Entertainer"));

        // Folk hero
        prefabs.Add(Prefab.folkHero,        new("Folk hero"));

        // Gladiator
        prefabs.Add(Prefab.gladiator,       new("Gladiator"));

        // Guild artisan
        prefabs.Add(Prefab.guildArtisan,    new("Guild artisan"));

        // Hermit
        prefabs.Add(Prefab.hermit,          new("Hermit"));

        // Knight
        prefabs.Add(Prefab.knight,          new("Knight"));

        // Noble
        prefabs.Add(Prefab.noble,           new("Noble"));

        // Outlander
        prefabs.Add(Prefab.outlander,       new("Outlander"));

        // Pirate
        prefabs.Add(Prefab.pirate,          new("Pirate"));

        // Sage
        prefabs.Add(Prefab.sage,            new("Sage"));

        // Sailor
        prefabs.Add(Prefab.sailor,          new("Sailor"));

        // Soldier
        prefabs.Add(Prefab.soldier,         new("Soldier"));

        // Urchin
        prefabs.Add(Prefab.urchin,          new("Urchin"));

        // Burglar's pack
        prefabs.Add(Prefab.burglarPack,     new("Burglar's pack"));

        // Diplomat's pack
        prefabs.Add(Prefab.diplomatPack,    new("Diplomat's pack"));

        // Dungeoneer's pack
        prefabs.Add(Prefab.dungeoneerPack,  new("Dungeoneer's pack"));

        // Entertainer's pack
        prefabs.Add(Prefab.entertainerPack, new("Entertainer's pack"));

        // Explorer's pack
        prefabs.Add(Prefab.explorerPack,    new("Explorer's pack"));

        // Priest's pack
        prefabs.Add(Prefab.priestPack,      new("Priest's pack"));

        // Scholar's pack
        prefabs.Add(Prefab.scholarPack,     new("Scholar's pack"));
    }

    public Package(string name)
    {
        this.name = name;
    }
}
