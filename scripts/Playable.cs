using Godot;
using System;
using System.Collections.Generic;
using System.Linq;

public partial class Playable : Character
{
	public int ProficiencyBonus
	{
		get
		{
			return (int)(Math.Ceiling(level / 4f) + 1);
		}
	}
	public Dictionary<Masterable.Type, bool> Proficiencies
    {
		get
        {
			Dictionary<Masterable.Type, bool> result = Masterable.GetBlankProficiencyTable();

			List<Masterable.Type> proficiencies = new();

			if(background != null)
            {
				List<Masterable.Type> backgroundProficiencies = background.availableSkills;
				proficiencies = proficiencies.Concat(backgroundProficiencies).ToList();
			}

			// ...

			foreach(Masterable.Type proficiency in proficiencies)
            {
				result[proficiency] = true;
			}
			
			return result;
		}
    }
	public int level = 1;
	public Origin background;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Item Backpack = Item.global[Item.Type.backpack];
		GD.Print(Backpack.name);

		Equippable Rapier = Item.global[Item.Type.rapier] as Equippable;
		GD.Print($"{Rapier.name} : {Rapier.damages}");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
