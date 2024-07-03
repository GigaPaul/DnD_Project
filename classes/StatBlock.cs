using Godot;
using System;
using System.Collections.Generic;
using System.Linq;

public partial class StatBlock
{
    // = CONSTS =
    public readonly List<Bonus> bonus = new();
    public readonly Dictionary<Masterable.Type, int> capabilities = new();
    public readonly Dictionary<Masterable.Type, bool> proficiencies = new();





    // = VARIABLES =
    public string name;
    public int ProficiencyBonus;





    // = CONSTRUCTORS =
    public StatBlock(string name = "Unamed", int strength = 10, int dexterity = 10, int constitution = 10, int intelligence = 10, int wisdom = 10, int charisma = 10)
    {
        this.name = name;

        

        capabilities = new()
        {
            { Masterable.Type.strength,     strength },
            { Masterable.Type.dexterity,    dexterity },
            { Masterable.Type.constitution, constitution },
            { Masterable.Type.intelligence, intelligence },
            { Masterable.Type.wisdom,       wisdom },
            { Masterable.Type.charisma,     charisma }
        };


        List<Masterable.Type> isProficientIn = new()
        {
            { Masterable.Type.intimidation }
        };

        int count = Enum.GetNames(typeof(Masterable.Type)).Length;
        for(int i = 0; i < count; i++)
        {
            Masterable.Type type = (Masterable.Type)i;
            bool isProficient = isProficientIn.Contains(type);
            proficiencies.Add(type, isProficient);
        }
    }





    // = METHODS =
    // Public methods
    public int GetScore(Masterable.Type type)
    {
        Masterable masterable = Masterable.global[type];
        int score;

        if (masterable.IsSkill())
        {
            score = GetSkillScore(type);
        }
        else
        {
            score = GetAbilityScore(type);
        }

        return score;
    }





    public int GetAbilityScore(Masterable.Type type)
    {
        int baseScore = capabilities[type];
        List<int> bonusList = bonus.Where(e => e.type == type).Select(e => e.bonus).ToList();

        int score = GetScore(baseScore, bonusList);

        return score;
    }





    public int GetSkillScore(Masterable.Type type)
    {
        Masterable.Type parentType = (Masterable.Type)Masterable.global[type].parent;

        int score = 10;
        int parentModifier = GetModifier(parentType);
        int proficiency = GetProficiencyBonus(type);

        score += parentModifier * 2 + proficiency * 2;

        return score;
    }





    public int GetModifier(Masterable.Type type)
    {
        int score = GetScore(type);

        return GetModifier(score);
    }





    public int GetProficiencyBonus(Masterable.Type type)
    {
        int proficiency = 0;

        if (IsProficientIn(type))
        {
            proficiency = 2;
        }

        return proficiency;
    }





    public bool IsProficientIn(Masterable.Type skill)
    {
        return proficiencies[skill];
    }







    // Protected methods

    // Private methods
    private static int GetScore(int baseScore, List<int> bonusList)
    {
        for (int i = 0; i < bonusList.Count; i++)
        {
            baseScore += bonusList[i];
        }

        return baseScore;
    }





    private static int GetModifier(int score)
    {
        return (int)Math.Floor((score - 10) / 2f);
    }
}
