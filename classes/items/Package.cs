using Godot;
using System;
using System.Collections.Generic;

public partial class Package
{
    public string name;
    public int? goldPrice;
    public List<Bundle> items = new();
    public List<List<Bundle>> exclusiveItems = new();
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
        Package acolyte = new("Acolyte")
        {
            items =
            {
                new(Item.Type.holySymbol),
                new(Item.Type.stickOfIncense, 5),
                new(Item.Type.vestments),
                new(Item.Type.commonClothes),
                new(Item.Type.goldPiece, 15)
            },

            exclusiveItems =
            {
                new()
                {
                    { new(Item.Type.prayerBook) },
                    { new(Item.Type.prayerWheel) }
                }
            }
        };

        prefabs.Add(Prefab.acolyte, acolyte);





        // Charlatan
        Package charlatan = new("Charlatan")
        {
            items =
            {
                new(Item.Type.fineClothes),
                new(Item.Type.disguiseKit),
                new(Item.Type.goldPiece, 15)
            },

            exclusiveItems =
            {
                new()
                {
                    { new(Item.Type.weightedDice) },
                    { new(Item.Type.markedCards) },
                    { new(Item.Type.fakeSignetRing) }
                }
            }
        };

        prefabs.Add(Prefab.charlatan, charlatan);





        // Criminal
        Package criminal = new("Criminal")
        {
            items =
            {
                new(Item.Type.crowbar),
                new(Item.Type.commonClothes),
                new(Item.Type.goldPiece, 15)
            }
        };

        prefabs.Add(Prefab.criminal, criminal);





        // Entertainer
        Package entertainer = new("Entertainer")
        {
            items =
            {
                new(Item.Type.costumeClothes),
                new(Item.Type.goldPiece, 15)
            }
        };

        // Musical instruments
        List<Bundle> musicalInstruments = new();
        for (int i = 0; i < Item.musicalInstruments.Count; i++)
        {
            musicalInstruments.Add(new(Item.musicalInstruments[i]));
        }
        entertainer.exclusiveItems.Add(musicalInstruments);

        // Favors of an admirer
        List<Bundle> favorOfAnAdmirer = new();
        for (int i = 0; i < Item.favorOfAnAdmirer.Count; i++)
        {
            favorOfAnAdmirer.Add(new(Item.favorOfAnAdmirer[i]));
        }
        entertainer.exclusiveItems.Add(favorOfAnAdmirer);

        prefabs.Add(Prefab.entertainer, entertainer);





        // Folk hero
        Package folkHero = new("Folk hero")
        {
            items =
            {
                new(Item.Type.shovel),
                new(Item.Type.ironPot),
                new(Item.Type.commonClothes),
                new(Item.Type.goldPiece, 10)
            }
        };

        // Artisan's tools
        List<Bundle> artisanTools = new();
        for (int i = 0; i < Item.artisanTools.Count; i++)
        {
            artisanTools.Add(new(Item.artisanTools[i]));
        }
        folkHero.exclusiveItems.Add(artisanTools);

        prefabs.Add(Prefab.folkHero, folkHero);





        // Gladiator
        prefabs.Add(Prefab.gladiator, entertainer);





        // Guild artisan
        Package guildArtisan = new("Guild artisan")
        {
            items =
            {
                new(Item.Type.letterOfIntroduction),
                new(Item.Type.travelerClothes),
                new(Item.Type.goldPiece, 15)
            }
        };

        guildArtisan.exclusiveItems.Add(artisanTools);

        prefabs.Add(Prefab.guildArtisan, guildArtisan);





        // Hermit
        Package hermit = new("Hermit")
        {
            items =
            {
                new(Item.Type.blanket),
                new(Item.Type.commonClothes),
                new(Item.Type.herbalismKit),
                new(Item.Type.goldPiece, 5)
            }
        };

        prefabs.Add(Prefab.hermit, hermit);





        // Knight
        Package noble = new("Noble")
        {
            items =
            {
                new(Item.Type.fineClothes),
                new(Item.Type.signetRing),
                new(Item.Type.scrollOfPedigree),
                new(Item.Type.goldPiece, 25)
            }
        };

        prefabs.Add(Prefab.knight, noble);





        // Noble
        prefabs.Add(Prefab.noble, noble);





        // Outlander
        Package outlander = new("Outlander")
        {
            items =
            {
                new(Item.Type.staff),
                new(Item.Type.huntingTrap),
                new(Item.Type.huntingTrophy),
                new(Item.Type.travelerClothes),
                new(Item.Type.goldPiece, 10)
            }
        };

        prefabs.Add(Prefab.outlander, outlander);





        // Pirate
        Package sailor = new("Sailor")
        {
            items =
            {
                new(Item.Type.club),
                new(Item.Type.ropeSilk),
                new(Item.Type.luckyCharm),
                new(Item.Type.commonClothes),
                new(Item.Type.goldPiece, 10)
            }
        };

        prefabs.Add(Prefab.pirate, sailor);





        // Sage
        Package sage = new("Sage")
        {
            items =
            {
                new(Item.Type.quill),
                new(Item.Type.smallKnife),
                new(Item.Type.commonClothes),
                new(Item.Type.goldPiece, 10)
            }
        };

        prefabs.Add(Prefab.sage, sage);





        // Sailor
        prefabs.Add(Prefab.sailor, sailor);





        // Soldier
        Package soldier = new("Soldier")
        {
            items =
            {
                new(Item.Type.insignaOfRank),
                new(Item.Type.battleTrophy),
                new(Item.Type.commonClothes),
                new(Item.Type.goldPiece, 10)
            },

            exclusiveItems =
            {
                new()
                {
                    new(Item.Type.playingCardSet),
                    new(Item.Type.diceSet)
                }
            }
        };

        prefabs.Add(Prefab.soldier, soldier);





        // Urchin
        Package urchin = new("Urchin")
        {
            items =
            {
                new(Item.Type.smallKnife),
                new(Item.Type.commonClothes),
                new(Item.Type.goldPiece, 10)
            }
        };

        prefabs.Add(Prefab.urchin, urchin);





        // Burglar's pack
        Package burglarPack = new("Burglar's pack", 16)
        {
            items =
            {
                new(Item.Type.backpack),
                new(Item.Type.ballBearings, 1000),
                new(Item.Type.stringItem),
                new(Item.Type.bell),
                new(Item.Type.candle, 5),
                new(Item.Type.crowbar),
                new(Item.Type.hammer),
                new(Item.Type.piton, 10),
                new(Item.Type.lanternHooded),
                new(Item.Type.rations, 5),
                new(Item.Type.tinderbox),
                new(Item.Type.waterskin),
                new(Item.Type.ropeHempen)
            }
        };

        prefabs.Add(Prefab.burglarPack, burglarPack);





        // Diplomat's pack
        Package diplomatPack = new("Diplomat's pack", 39)
        {
            items =
            {
                new(Item.Type.chest),
                new(Item.Type.fineClothes),
                new(Item.Type.lamp),
                new(Item.Type.paper, 5),
                new(Item.Type.sealingWax),
                new(Item.Type.soap)
            }
        };

        prefabs.Add(Prefab.diplomatPack, diplomatPack);





        // Dungeoneer's pack
        Package dungeoneerPack = new("Dungeoneer's pack", 12)
        {
            items =
            {
                new(Item.Type.backpack),
                new(Item.Type.crowbar),
                new(Item.Type.hammer),
                new(Item.Type.piton, 10),
                new(Item.Type.torch, 10),
                new(Item.Type.tinderbox),
                new(Item.Type.rations, 10),
                new(Item.Type.waterskin),
                new(Item.Type.ropeHempen)
            }
        };

        prefabs.Add(Prefab.dungeoneerPack, dungeoneerPack);





        // Entertainer's pack
        Package entertainerPack = new("Entertainer's pack", 40)
        {
            items =
            {
                new(Item.Type.backpack),
                new(Item.Type.bedroll),
                new(Item.Type.costumeClothes, 2),
                new(Item.Type.candle, 5),
                new(Item.Type.rations, 5),
                new(Item.Type.waterskin),
                new(Item.Type.disguiseKit)
            }
        };

        prefabs.Add(Prefab.entertainerPack, entertainerPack);





        // Explorer's pack
        Package explorerPack = new("Explorer's pack", 10)
        {
            items =
            {
                new(Item.Type.backpack),
                new(Item.Type.bedroll),
                new(Item.Type.messKit),
                new(Item.Type.tinderbox),
                new(Item.Type.torch, 10),
                new(Item.Type.rations, 10),
                new(Item.Type.waterskin),
                new(Item.Type.ropeHempen)
            }
        };

        prefabs.Add(Prefab.explorerPack, explorerPack);





        // Priest's pack
        Package priestPack = new("Priest's pack", 19)
        {
            items =
            {
                new(Item.Type.backpack),
                new(Item.Type.blanket),
                new(Item.Type.candle, 10),
                new(Item.Type.tinderbox),
                new(Item.Type.almsBox),
                new(Item.Type.stickOfIncense, 2),
                new(Item.Type.censer),
                new(Item.Type.vestments),
                new(Item.Type.rations, 2),
                new(Item.Type.waterskin)
            }
        };

        prefabs.Add(Prefab.priestPack, priestPack);





        // Scholar's pack
        Package scholarPack = new("Scholar's pack", 40)
        {
            items =
            {
                new(Item.Type.backpack),
                new(Item.Type.bookOfLore),
                new(Item.Type.inkPen),
                new(Item.Type.parchment, 10),
                new(Item.Type.smallKnife)
            }
        };

        prefabs.Add(Prefab.scholarPack, scholarPack);
    }

    public Package(string name, int? goldPrice = null)
    {
        this.name = name;
        this.goldPrice = goldPrice;
    }
}
