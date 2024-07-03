using Godot;
using System;
using System.Collections.Generic;

public partial class Background
{
    public static readonly Dictionary<Type, Background> global = new();

    public string name;
    public List<Masterable.Type> proficiencies = new();
    public List<Language.Family> languages = new();

    public enum Type
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
        urchin
    }

    static Background()
    {
        // Acolyte
        Background acolyte = new("Acolyte");
        acolyte.proficiencies.Add(Masterable.Type.insight);
        acolyte.proficiencies.Add(Masterable.Type.religion);

        global.Add(Type.acolyte, acolyte);



        // CHARLATAN
        Background charlatan = new("Charlatan");
        charlatan.proficiencies.Add(Masterable.Type.deception);
        charlatan.proficiencies.Add(Masterable.Type.sleightOfHand);

        global.Add(Type.charlatan, charlatan);



        // CRIMINAL
        Background criminal = new("Criminal");
        criminal.proficiencies.Add(Masterable.Type.deception);
        criminal.proficiencies.Add(Masterable.Type.stealth);
        criminal.proficiencies.Add(Masterable.Type.thieveTool);

        global.Add(Type.criminal, criminal);



        // ENTERTAINER
        Background entertainer = new("Entertainer");
        entertainer.proficiencies.Add(Masterable.Type.acrobatics);
        entertainer.proficiencies.Add(Masterable.Type.performance);
        entertainer.proficiencies.Add(Masterable.Type.disguiseKit);

        global.Add(Type.entertainer, entertainer);



        // FOLK HERO
        Background folkHero = new("Folk hero");
        folkHero.proficiencies.Add(Masterable.Type.animalHandling);
        folkHero.proficiencies.Add(Masterable.Type.survival);
        folkHero.proficiencies.Add(Masterable.Type.landVehicle);

        global.Add(Type.folkHero, folkHero);



        // GLADIATOR
        Background gladiator = new("Gladiator");
        gladiator.proficiencies.Add(Masterable.Type.acrobatics);
        gladiator.proficiencies.Add(Masterable.Type.performance);
        gladiator.proficiencies.Add(Masterable.Type.disguiseKit);

        global.Add(Type.gladiator, gladiator);



        // GUILD ARTISAN
        Background guildArtisan = new("Guild artisan");
        guildArtisan.proficiencies.Add(Masterable.Type.insight);
        guildArtisan.proficiencies.Add(Masterable.Type.persuasion);

        global.Add(Type.guildArtisan, guildArtisan);



        // HERMIT
        Background hermit = new("Hermit");
        hermit.proficiencies.Add(Masterable.Type.medicine);
        hermit.proficiencies.Add(Masterable.Type.religion);
        hermit.proficiencies.Add(Masterable.Type.herbalismSet);

        global.Add(Type.hermit, hermit);



        // KNIGHT
        Background knight = new("Knight");
        knight.proficiencies.Add(Masterable.Type.history);
        knight.proficiencies.Add(Masterable.Type.persuasion);

        global.Add(Type.knight, knight);



        // NOBLE
        Background noble = new("Noble");
        noble.proficiencies.Add(Masterable.Type.history);
        noble.proficiencies.Add(Masterable.Type.persuasion);

        global.Add(Type.noble, noble);



        // OUTLANDER
        Background outlander = new("Outlander");
        outlander.proficiencies.Add(Masterable.Type.athletics);
        outlander.proficiencies.Add(Masterable.Type.survival);
        outlander.proficiencies.Add(Masterable.Type.musicalInstrument);

        global.Add(Type.outlander, outlander);



        // PIRATE
        Background pirate = new("Pirate");
        pirate.proficiencies.Add(Masterable.Type.athletics);
        pirate.proficiencies.Add(Masterable.Type.perception);
        pirate.proficiencies.Add(Masterable.Type.navigatorTool);
        pirate.proficiencies.Add(Masterable.Type.waterVehicle);

        global.Add(Type.pirate, pirate);



        // SAGE
        Background sage = new("Sage");
        sage.proficiencies.Add(Masterable.Type.arcana);
        sage.proficiencies.Add(Masterable.Type.history);

        global.Add(Type.sage, sage);



        // SAILOR
        Background sailor = new("Sailor");
        sailor.proficiencies.Add(Masterable.Type.athletics);
        sailor.proficiencies.Add(Masterable.Type.perception);
        sailor.proficiencies.Add(Masterable.Type.navigatorTool);
        sailor.proficiencies.Add(Masterable.Type.waterVehicle);

        global.Add(Type.sailor, sailor);



        // SOLDIER
        Background soldier = new("Soldier");
        soldier.proficiencies.Add(Masterable.Type.athletics);
        soldier.proficiencies.Add(Masterable.Type.intimidation);
        soldier.proficiencies.Add(Masterable.Type.landVehicle);

        global.Add(Type.soldier, soldier);



        // URCHIN
        Background urchin = new("Urchin");
        urchin.proficiencies.Add(Masterable.Type.sleightOfHand);
        urchin.proficiencies.Add(Masterable.Type.stealth);
        urchin.proficiencies.Add(Masterable.Type.disguiseKit);
        urchin.proficiencies.Add(Masterable.Type.thieveTool);

        global.Add(Type.urchin, urchin);
    }

    public Background(string name)
    {
        this.name = name;
    }
}
