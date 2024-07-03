using Godot;
using System;

public partial class MasterableManager : Node3D
{
	//public override void _EnterTree()
	//{
	//	// = Abilities =
 //       _ = new Masterable("Strength", Masterable.Type.strength);
	//	_ = new Masterable("Dexterity", Masterable.Type.dexterity);
	//	_ = new Masterable("Constitution", Masterable.Type.constitution);
	//	_ = new Masterable("Intelligence", Masterable.Type.intelligence);
	//	_ = new Masterable("Wisdom", Masterable.Type.wisdom);
	//	_ = new Masterable("Charisma", Masterable.Type.charisma);



	//	// = Skills =
	//	// Strength
	//	_ = new Masterable("Athletics", Masterable.Type.athletics, Masterable.Type.strength);
		
	//	// Dexterity
	//	_ = new Masterable("Acrobatics", Masterable.Type.acrobatics, Masterable.Type.dexterity);
	//	_ = new Masterable("Sleight of hand", Masterable.Type.sleightOfHand, Masterable.Type.dexterity);
	//	_ = new Masterable("Stealth", Masterable.Type.stealth, Masterable.Type.dexterity);
		
	//	// Intelligence
	//	_ = new Masterable("Arcana", Masterable.Type.arcana, Masterable.Type.intelligence);
	//	_ = new Masterable("History", Masterable.Type.history, Masterable.Type.intelligence);
	//	_ = new Masterable("Investigation", Masterable.Type.investigation, Masterable.Type.intelligence);
	//	_ = new Masterable("Nature", Masterable.Type.nature, Masterable.Type.intelligence);
	//	_ = new Masterable("Religion", Masterable.Type.religion, Masterable.Type.intelligence);
		
	//	// Wisdom
	//	_ = new Masterable("Animal handling", Masterable.Type.animalHandling, Masterable.Type.wisdom);
	//	_ = new Masterable("Insight", Masterable.Type.insight, Masterable.Type.wisdom);
	//	_ = new Masterable("Medicine", Masterable.Type.medicine, Masterable.Type.wisdom);
	//	_ = new Masterable("Perception", Masterable.Type.perception, Masterable.Type.wisdom);
	//	_ = new Masterable("Survival", Masterable.Type.survival, Masterable.Type.wisdom);
		
	//	// Charisma
	//	_ = new Masterable("Deception", Masterable.Type.deception, Masterable.Type.charisma);
	//	_ = new Masterable("Intimidation", Masterable.Type.intimidation, Masterable.Type.charisma);
	//	_ = new Masterable("Performance", Masterable.Type.performance, Masterable.Type.charisma);
	//	_ = new Masterable("Persuasion", Masterable.Type.persuasion, Masterable.Type.charisma);
	//}

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
