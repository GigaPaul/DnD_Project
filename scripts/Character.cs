using Godot;
using System;

public partial class Character : Node3D
{
	public StatBlock statBlock;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		statBlock = new("Roturier", charisma: 8);

		Bonus bonusCha = new(Ability.Type.charisma, 5);
		statBlock.bonus.Add(bonusCha);
        int charismaSc = statBlock.GetScore(Ability.Type.charisma);
		int charismaMod = statBlock.GetModifier(Ability.Type.charisma);
		GD.Print($"Charisme : {charismaSc} => {charismaMod}");

		int intimidationSc = statBlock.GetScore(Skill.Type.intimidation);
		int intimidationMod = statBlock.GetModifier(Skill.Type.intimidation);
		GD.Print($"Intimidation : {intimidationSc} => {intimidationMod}");


		Bonus bonusCon = new(Ability.Type.constitution, -5);
		statBlock.bonus.Add(bonusCon);
		int conSc = statBlock.GetScore(Ability.Type.constitution);
		int conMod = statBlock.GetModifier(Ability.Type.constitution);
		GD.Print($"Constitution : {conSc} => {conMod}");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}
}
