using Godot;
using System;

public partial class Item
{
    public string name;
    public Masterable.Type? type;

    public bool IsSkilled
    {
        get { return type != null; }
    }

    public Item(string name)
    {
        this.name = name;
    }

    public Item(string name, Masterable.Type type)
    {
        this.name = name;
        this.type = type;
    }
}
