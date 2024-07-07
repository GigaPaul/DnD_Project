using Godot;
using System;

public partial class Bundle
{
    public Item.Type Item { get; set; }
    public int amount;

    public Bundle(Item.Type item, int amount = 1)
    {
        Item = item;
        this.amount = amount;
    }
}
