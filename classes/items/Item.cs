using Godot;
using System;
using System.Collections.Generic;

public partial class Item
{
    public static readonly Dictionary<Type, Item> global = new();
    public static readonly List<Type> musicalInstruments = new();
    public static readonly List<Type> favorOfAnAdmirer = new();
    public static readonly List<Type> artisanTools = new();

    public bool Stackable
    {
        get {
            return stackSize > 1;
        }
    }

    public string name;
    public Masterable.Type? masterableType;
    public int stackSize;


    public bool IsSkilled
    {
        get { return masterableType != null; }
    }

    public enum Type
    {
        // = Armor =
        // Clothing
        commonClothes,
        costumeClothes,
        fineClothes,
        robes,
        travelerClothes,
        vestments,
        // Light armor
        padded,
        leather,
        studdedLeather,
        // Medium armor
        hide,
        chainShirt,
        scaleMail,
        breastPlate,
        halfPlate,
        // Heavy armor
        ringMail,
        chainMail,
        splint,
        plate,
        // Shield
        shield,

        // = Weapons =
        // Simple melee weapons
        club,
        dagger,
        greatClub,
        handaxe,
        javelin,
        lightHammer,
        mace,
        quarterStaff,
        sickle,
        spear,
        unarmedStrike,
        // Simple ranged weapons
        crossbowLight,
        dart,
        shortbow,
        sling,
        // Martial melee weapons
        battleaxe,
        flail,
        glaive,
        greataxe,
        greatsword,
        halberd,
        lance,
        longsword,
        maul,
        morningstar,
        pike,
        rapier,
        scimitar,
        shortsword,
        trident,
        warPick,
        warhammer,
        whip,

        // = Money =
        copperPiece,
        silverPiece,
        electrumPiece,
        goldPiece,
        platinumPiece,

        // = Adventuring gear =
        abacus,
        ammunition,
        arcaneFocus,
        backpack,
        ballBearings,
        barrel,
        basket,
        battleTrophy,
        bedroll,
        bell,
        blanket,
        blockAndTackle,
        book,
        bottle,
        bucket,
        caltrops,
        candle,
        chain,
        chalk,
        chest,
        climberKit,
        componentPouch,
        crowbar,
        druidicFocus,
        fishingTackle,
        flask,
        grapplingHook,
        hammer,
        hammerSledge,
        healerKit,
        holySymbol,
        hourglass,
        huntingTrap,
        huntingTrophy,
        inkPen,
        insignaOfRank,
        ironPot,
        jug,
        ladder,
        lamp,
        lanternBullseye,
        lanternHooded,
        letterOfIntroduction,
        lockItem,
        luckyCharm,
        magnifyingGlass,
        manacles,
        messKit,
        mirror,
        paper,
        parchment,
        pickMiner,
        piton,
        pole,
        pot,
        potionOfHealing,
        pouch,
        prayerBook,
        prayerWheel,
        quill,
        quiver,
        ramPortable,
        rations,
        ropeSilk,
        sack,
        scaleMerchant,
        scrollOfPedigree,
        sealingWax,
        shovel,
        signalWhistle,
        signetRing,
        smallKnife,
        soap,
        spellBook,
        spikes,
        spyglass,
        staff,
        stickOfIncense,
        tent,
        tinderbox,
        torch,
        vial,
        waterskin,
        whetstone,

        // = Tools =
        // Artisan's tools
        alchemistSupplies,
        brewerSupplies,
        CalligrapherSupplies,
        carpenterTools,
        cartographerTools,
        cobblerTools,
        jewelerTools,
        leatherworkerTools,
        masonTools,
        painterSupplies,
        potterTools,
        smithTools,
        tinkerTools,
        weaverTools,
        woodcarverTools,
        //
        disguiseKit,
        forgeryKit,
        // Gaming set
        diceSet,
        dragonchessSet,
        playingCardSet,
        threeDragonAnteSet,
        //
        herbalismKit,
        // Musical instruments
        bagPipes,
        drum,
        dulcimer,
        flute,
        lute,
        lyre,
        horn,
        panFlute,
        shawm,
        viol,
        //
        navigatorTools,
        poisonerKit,
        thieveTools,
        // Con tools
        weightedDice,
        markedCards,
        fakeSignetRing,
        // Favor of an admirer
        loveLetter,
        lockOfHair,
        trinket,
        // Land vehicles
        camel,
        donkey,
        elephant,
        horseDraft,
        horseRiding,
        mastiff,
        pony,
        warhorse,
        // Water vehicles
        galley,
        keelboat,
        longship,
        rowboat,
        sailingShip,
        warship,
        // Tack, harness, and drawn vehicles
        barding,
        bitAndBridle,
        carriage,
        cart,
        chariot,
        feed,
        exoticSaddle,
        militarySaddle,
        packSaddle,
        ridingSaddle,
        saddlebags,
        sled,
        stabling,
        wagon
    }

    static Item()
    {
        // Musical instruments
        musicalInstruments.Add(Type.bagPipes);
        musicalInstruments.Add(Type.drum);
        musicalInstruments.Add(Type.dulcimer);
        musicalInstruments.Add(Type.flute);
        musicalInstruments.Add(Type.lute);
        musicalInstruments.Add(Type.lyre);
        musicalInstruments.Add(Type.horn);
        musicalInstruments.Add(Type.panFlute);
        musicalInstruments.Add(Type.shawm);
        musicalInstruments.Add(Type.viol);

        // Favor of an admirer
        favorOfAnAdmirer.Add(Type.loveLetter);
        favorOfAnAdmirer.Add(Type.lockOfHair);
        favorOfAnAdmirer.Add(Type.trinket);

        // Artisan's tools
        artisanTools.Add(Type.alchemistSupplies);
        artisanTools.Add(Type.brewerSupplies);
        artisanTools.Add(Type.CalligrapherSupplies);
        artisanTools.Add(Type.carpenterTools);
        artisanTools.Add(Type.cartographerTools);
        artisanTools.Add(Type.cobblerTools);
        artisanTools.Add(Type.jewelerTools);
        artisanTools.Add(Type.leatherworkerTools);
        artisanTools.Add(Type.masonTools);
        artisanTools.Add(Type.painterSupplies);
        artisanTools.Add(Type.potterTools);
        artisanTools.Add(Type.smithTools);
        artisanTools.Add(Type.tinkerTools);
        artisanTools.Add(Type.weaverTools);
        artisanTools.Add(Type.woodcarverTools);
    }

    public Item(string name, int stackSize = 1)
    {
        this.name = name;
        this.stackSize = stackSize;
    }

    public Item(string name, Masterable.Type masterableType, int stackSize = 1)
    {
        this.name = name;
        this.masterableType = masterableType;
        this.stackSize = stackSize;
    }
}
