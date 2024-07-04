using Godot;
using System;
using System.Collections.Generic;

public partial class Origin
{
    public static readonly Dictionary<Type, Origin> global = new();


    public string name;
    public List<Masterable.Type> availableSkills = new();
    public List<Masterable.Type> availaibleTools = new();

    public enum Type
    {
        acolyte,
        charlatan,
        criminal,
        custom,
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

    static Origin()
    {
        // Acolyte
        Origin acolyte = new("Acolyte");
        acolyte.availableSkills.Add(Masterable.Type.insight);
        acolyte.availableSkills.Add(Masterable.Type.religion);

        global.Add(Type.acolyte, acolyte);



        // CHARLATAN
        Origin charlatan = new("Charlatan");
        charlatan.availableSkills.Add(Masterable.Type.deception);
        charlatan.availableSkills.Add(Masterable.Type.sleightOfHand);

        global.Add(Type.charlatan, charlatan);



        // CRIMINAL
        Origin criminal = new("Criminal");
        criminal.availableSkills.Add(Masterable.Type.deception);
        criminal.availableSkills.Add(Masterable.Type.stealth);
        criminal.availaibleTools.Add(Masterable.Type.thieveTool);

        global.Add(Type.criminal, criminal);



        // ENTERTAINER
        Origin entertainer = new("Entertainer");
        entertainer.availableSkills.Add(Masterable.Type.acrobatics);
        entertainer.availableSkills.Add(Masterable.Type.performance);
        entertainer.availaibleTools.Add(Masterable.Type.disguiseKit);

        global.Add(Type.entertainer, entertainer);



        // FOLK HERO
        Origin folkHero = new("Folk hero");
        folkHero.availableSkills.Add(Masterable.Type.animalHandling);
        folkHero.availableSkills.Add(Masterable.Type.survival);
        folkHero.availaibleTools.Add(Masterable.Type.landVehicle);

        global.Add(Type.folkHero, folkHero);



        // GLADIATOR
        Origin gladiator = new("Gladiator");
        gladiator.availableSkills.Add(Masterable.Type.acrobatics);
        gladiator.availableSkills.Add(Masterable.Type.performance);
        gladiator.availaibleTools.Add(Masterable.Type.disguiseKit);

        global.Add(Type.gladiator, gladiator);



        // GUILD ARTISAN
        Origin guildArtisan = new("Guild artisan");
        guildArtisan.availableSkills.Add(Masterable.Type.insight);
        guildArtisan.availableSkills.Add(Masterable.Type.persuasion);

        global.Add(Type.guildArtisan, guildArtisan);



        // HERMIT
        Origin hermit = new("Hermit");
        hermit.availableSkills.Add(Masterable.Type.medicine);
        hermit.availableSkills.Add(Masterable.Type.religion);
        hermit.availaibleTools.Add(Masterable.Type.herbalismSet);

        global.Add(Type.hermit, hermit);



        // KNIGHT
        Origin knight = new("Knight");
        knight.availableSkills.Add(Masterable.Type.history);
        knight.availableSkills.Add(Masterable.Type.persuasion);

        global.Add(Type.knight, knight);



        // NOBLE
        Origin noble = new("Noble");
        noble.availableSkills.Add(Masterable.Type.history);
        noble.availableSkills.Add(Masterable.Type.persuasion);

        global.Add(Type.noble, noble);



        // OUTLANDER
        Origin outlander = new("Outlander");
        outlander.availableSkills.Add(Masterable.Type.athletics);
        outlander.availableSkills.Add(Masterable.Type.survival);
        outlander.availaibleTools.Add(Masterable.Type.musicalInstrument);

        global.Add(Type.outlander, outlander);



        // PIRATE
        Origin pirate = new("Pirate");
        pirate.availableSkills.Add(Masterable.Type.athletics);
        pirate.availableSkills.Add(Masterable.Type.perception);
        pirate.availaibleTools.Add(Masterable.Type.navigatorTool);
        pirate.availaibleTools.Add(Masterable.Type.waterVehicle);

        global.Add(Type.pirate, pirate);



        // SAGE
        Origin sage = new("Sage");
        sage.availableSkills.Add(Masterable.Type.arcana);
        sage.availableSkills.Add(Masterable.Type.history);

        global.Add(Type.sage, sage);



        // SAILOR
        Origin sailor = new("Sailor");
        sailor.availableSkills.Add(Masterable.Type.athletics);
        sailor.availableSkills.Add(Masterable.Type.perception);
        sailor.availaibleTools.Add(Masterable.Type.navigatorTool);
        sailor.availaibleTools.Add(Masterable.Type.waterVehicle);

        global.Add(Type.sailor, sailor);



        // SOLDIER
        Origin soldier = new("Soldier");
        soldier.availableSkills.Add(Masterable.Type.athletics);
        soldier.availableSkills.Add(Masterable.Type.intimidation);
        soldier.availaibleTools.Add(Masterable.Type.landVehicle);

        global.Add(Type.soldier, soldier);



        // URCHIN
        Origin urchin = new("Urchin");
        urchin.availableSkills.Add(Masterable.Type.sleightOfHand);
        urchin.availableSkills.Add(Masterable.Type.stealth);
        urchin.availaibleTools.Add(Masterable.Type.disguiseKit);
        urchin.availaibleTools.Add(Masterable.Type.thieveTool);

        global.Add(Type.urchin, urchin);



        // CUSTOM
        Origin custom = new("Custom");

        for (int i = 0; i < Masterable.skills.Count; i++)
        {
            custom.availableSkills.Add(Masterable.skills[i]);
        }

        for (int i = 0; i < Masterable.tools.Count; i++)
        {
            custom.availaibleTools.Add(Masterable.tools[i]);
        }

        global.Add(Type.custom, custom);
    }

    public Origin(string name)
    {
        this.name = name;
    }
}
