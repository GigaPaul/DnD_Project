using Godot;
using System;

public partial class Character : Node3D
{
	public StatBlock statBlock;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		statBlock = new("Roturier", charisma: 8);
        GD.Print(statBlock.IsProficientIn(Masterable.Type.intimidation));

		Masterable charisma = Masterable.Get(Masterable.Type.charisma);
		GD.Print($"{charisma.name} : {statBlock.GetScore(Masterable.Type.charisma)} => {statBlock.GetModifier(Masterable.Type.charisma)}");

		Masterable intimidation = Masterable.Get(Masterable.Type.intimidation);
		GD.Print($"{intimidation.name} : {statBlock.GetScore(Masterable.Type.intimidation)} => {statBlock.GetModifier(Masterable.Type.intimidation)}");

		Masterable constitution = Masterable.Get(Masterable.Type.constitution);
		GD.Print($"{constitution.name} : {statBlock.GetScore(Masterable.Type.constitution)} => {statBlock.GetModifier(Masterable.Type.constitution)}");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}

	//public int RollFor(Ability ability, bool isSave = false)
 //   {
	//	return 0;
 //   }

	//public int RollFor(Skill skill, bool isSave = false)
 //   {
	//	return 0;
 //   }
}
