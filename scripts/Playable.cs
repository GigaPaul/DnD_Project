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
		GD.Print($"There are {Origin.global.Count} backgrounds available.");
		foreach (KeyValuePair<Origin.Type, Origin> entry in Origin.global)
		{
			GD.Print($"{entry.Key}, {entry.Value.name} has {entry.Value.availableSkills.Count} proficiencies.");
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
