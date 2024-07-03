using Godot;
using System;

public partial class Playable : Character
{
    [Export]
	public int level = 1;
	public int ProficiencyBonus
	{
		get
		{
			return (int)(Math.Ceiling(level / 4f) + 1);
		}
	}

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
