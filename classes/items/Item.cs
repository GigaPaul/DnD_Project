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
        backpack,
        rapier
    }

    static Item()
    {
        global.Add(Type.backpack, new("Backpack"));
        global.Add(Type.rapier, new Equippable("Rapier"));
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
