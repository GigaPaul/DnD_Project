using Godot;
using System;

public partial class Character : Node3D
{
	public StatBlock statBlock;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		StatBlock roturier = new("Roturier", charisma: 8);
		statBlock = roturier;

		statBlock.proficiencies[Masterable.Type.acrobatics] = true;

		GD.Print(statBlock.IsProficientIn(Masterable.Type.acrobatics));

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}
}
