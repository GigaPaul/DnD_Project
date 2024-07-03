using Godot;
using System;
using System.Collections.Generic;
using System.Linq;

public partial class StatBlock
{
    public string name;
    public List<Bonus> bonus = new();
    public Dictionary<Masterable, int> capabilities;
    public Dictionary<Masterable.Type, bool> proficiencies = new();


    public StatBlock(string name = "Unamed", int strength = 10, int dexterity = 10, int constitution = 10, int intelligence = 10, int wisdom = 10, int charisma = 10)
    {
        this.name = name;

        

        capabilities = new()
        {
            { Masterable.Get(Masterable.Type.strength), strength },
            { Masterable.Get(Masterable.Type.dexterity), dexterity },
            { Masterable.Get(Masterable.Type.constitution), constitution },
            { Masterable.Get(Masterable.Type.intelligence), intelligence },
            { Masterable.Get(Masterable.Type.wisdom), wisdom },
            { Masterable.Get(Masterable.Type.charisma), charisma }
        };


        int count = Enum.GetNames(typeof(Masterable.Type)).Length;
        List<Masterable.Type> isProficientIn = new()
        {
            { Masterable.Type.intimidation }
        };

        for(int i = 0; i < count; i++)
        {
            Masterable.Type type = (Masterable.Type)i;
            bool isProficient = isProficientIn.Contains(type);
            proficiencies.Add(type, isProficient);
        }
    }





    public int GetScore(Masterable.Type type)
    {
        Masterable masterable = Masterable.Get(type);
        int score;

        if(masterable.IsSkill())
        {
            score = GetSkillScore(masterable);
        }
        else
        {
            score = GetAbilityScore(masterable);
        }

        return score;
    }





    public int GetAbilityScore(Masterable masterable)
    {
        int baseScore = capabilities[masterable];
        List<int> bonusList = bonus.Where(e => e.type == masterable.type).Select(e => e.bonus).ToList();

        int score = GetScore(baseScore, bonusList);

        return score;
    }





    public int GetSkillScore(Masterable masterable)
    {
        Masterable.Type parent = (Masterable.Type)masterable.parent;

        int score = 10;
        int parentModifier = GetModifier(parent);
        int proficiency = GetProficiencyBonus(masterable.type);

        score += parentModifier * 2 + proficiency * 2;

        return score;
    }





    public static int GetScore(int baseScore, List<int> bonusList)
    {
        for (int i = 0; i < bonusList.Count; i++)
        {
            baseScore += bonusList[i];
        }

        return baseScore;
    }





    public int GetModifier(Masterable.Type type)
    {
        int score = GetScore(type);

        return GetModifier(score);
    }





    public static int GetModifier(int score)
    {
        return (int)Math.Floor((score - 10) / 2f);
    }





    public int GetProficiencyBonus(Masterable.Type type)
    {
        int proficiency = 0;

        if(IsProficientIn(type))
        {
            proficiency = 2;
        }

        return proficiency;
    }





    // Proficiency Bool
    public bool IsProficientIn(Masterable.Type skill)
    {
        return proficiencies[skill];
    }
}
