using Godot;
using System;

public partial class Equippable : Item
{
    public Equippable(string name) : base(name) { }
    public Equippable(string name, Masterable.Type masterableType) : base(name, masterableType) { }
}
