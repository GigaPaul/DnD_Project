using Godot;
using System;
using System.Collections.Generic;
using System.Linq;

public partial class StatBlock
{
    public string name;
    public List<Bonus> bonus = new();
    public Dictionary<Ability.Type, int> abilities;
    public List<Skill.Type> proficiencies = new();


    public StatBlock(string name, int strength = 10, int dexterity = 10, int constitution = 10, int intelligence = 10, int wisdom = 10, int charisma = 10)
    {
        this.name = name;

        abilities = new()
        {
            { Ability.Type.strength, strength },
            { Ability.Type.dexterity, dexterity },
            { Ability.Type.constitution, constitution },
            { Ability.Type.intelligence, intelligence },
            { Ability.Type.wisdom, wisdom },
            { Ability.Type.charisma, charisma }
        };

        proficiencies.Add(Skill.Type.intimidation);
    }





    public int GetScore(Ability.Type ability)
    {
        int baseScore = abilities[ability];
        List<int> bonusList = bonus.Where(e => e.type == ability).Select(e => e.bonus).ToList();

        int score = GetScore(baseScore, bonusList);

        return score;
    }





    public int GetScore(Skill.Type skill)
    {
        Ability.Type parent = Skill.GetParent(skill);

        int score = 10;
        int parentModifier = GetModifier(parent);
        int proficiency = GetProficiencyBonus(skill);

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





    public int GetModifier(Ability.Type ability)
    {
        int score = GetScore(ability);

        return GetModifier(score);
    }





    public int GetModifier(Skill.Type skill)
    {
        int score = GetScore(skill);
        int modifier = GetModifier(score);
        //int proficiency = GetProficiencyBonus(skill);

        return modifier;
    }





    public static int GetModifier(int score)
    {
        return (int)Math.Floor((score - 10) / 2f);
    }





    public int GetProficiencyBonus(Skill.Type type)
    {
        int proficiency = 0;

        if(IsProficientIn(type))
        {
            proficiency = 2;
        }

        return proficiency;
    }





    public bool IsProficientIn(Skill.Type skill)
    {
        return proficiencies.Contains(skill);
    }
}
