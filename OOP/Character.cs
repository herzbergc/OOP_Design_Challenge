using System;

public abstract class Character 
{
    //Name of character
    public string Name { get; set; }
    //Hp of character
    public int Hp { get; set; }
    //Mp of character
    public int Mp { get; set; }
    //Strength of character
    public int Strength { get; set; }
    //Magic of character
    public int Magic { get; set; }

    public Character(string name, int hp, int mp, int strength, int magic)
    {
        Name = name;
        Hp = hp;
        Mp = mp;
        Strength = strength;
        Magic = magic;
    }

    //Calling Rest() heals the character, overridable.
    public virtual void Rest()
    {
        Hp += 5;
    }

   
}