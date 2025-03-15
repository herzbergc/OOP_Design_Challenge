public class Mage : Character, IAction
{
    public Mage(string name, int hp, int mp, int attack, int magic) : base(name, hp, mp, attack, magic)
    {
    }

    //Method for attacking inherited from IAction
    //Targets a selected Character object and subtracts their health by this mage's magic and then subtracts 5 mp
    //Example of Stamp Coupling
    public void Attack(Character target)
    {
        LifeSteal(target);
        Mp -= 5;
    }

    //Override of Rest() from Character that adds 5 HP like Character's Rest() and additionally adds 5 MP.
    public override void Rest()
    {
        base.Rest();
        Mp += 5;
    }

    //Takes the damage dealt to target and heals Mage by that amount
    //Example of Stamp coupling.
    public void LifeSteal(Character target)
    {
        int targetTempHp = target.Hp;
        target.Hp -= Magic;
        Hp += (targetTempHp - target.Hp); //Adds the amount of damage dealt to Mage's HP
    }


}