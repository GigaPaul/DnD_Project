using Godot;
using System;
using System.Collections.Generic;

public partial class Item
{
    public static readonly Dictionary<Type, Item> global = new();

    public string name;
    public Masterable.Type? masterableType;

    public bool IsSkilled
    {
        get { return masterableType != null; }
    }

    public enum Type
    {
        // = Armor =
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

        // = Adventuring gear =
        abacus,
        ammunition,
        arcaneFocus,
        backpack,
        ballBearings,
        barrel,
        basket,
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
        commonClothes,
        costumeClothes,
        fineClothes,
        travelerClothes,
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
        inkPen,
        jug,
        ladder,
        lamp,
        lanternBullseye,
        lanternHooded,
        lockItem,
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
        quiver,
        ramPortable,
        rations,
        robes,
        sack,
        scaleMerchant,
        sealingWax,
        shovel,
        signalWhistle,
        signetRing,
        soap,
        spellBook,
        spikes,
        spyglass,
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

    }

    public Item(string name)
    {
        this.name = name;
    }

    public Item(string name, Masterable.Type masterableType)
    {
        this.name = name;
        this.masterableType = masterableType;
    }
}
