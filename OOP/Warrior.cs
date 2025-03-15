public class Warrior : Character, IAction
{
    public Warrior(string name, int hp, int mp, int attack, int magic) : base(name, hp, mp, attack, magic)
    {
    }

    //Method for attacking inherited from IAction
    //Targets a selected Character object and subtracts their health by this warrior's strength. If strength is higher than target's strength, perform a bonus attack.
    //Example of Data Coupling
    public void Attack(Character target)
    {
        target.Hp -= Strength;
        BonusAttack(StrengthComparison(target.Strength), target);
    }

    //Overloaded Attack method inherited from IAction
    //Targets a selected Character object and subtracts their health by this warrior's strength. If it is daytime, add +5 damage. If strength is higher than target's strength, perform a bonus attack.
    public void Attack(Character target, bool isDaytime)
    {
        target.Hp -= Strength + 5;
        BonusAttack(StrengthComparison(target.Strength), target);
    }

    //Determines if the target or this warrior have higher strength. If the warrior's strength is higher returns true else false
    public bool StrengthComparison(int targetStrength)
    {
        if(Strength > targetStrength)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //Deals half of strength as damage to enemy target if canBonusAttack is true
    public void BonusAttack(bool canBonusAttack, Character target)
    {
        if (canBonusAttack == true)
        {
            target.Hp -= Strength / 2;
        }
    }
   
}