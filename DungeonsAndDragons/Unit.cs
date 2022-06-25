namespace DungeonsAndDragons;

public class Unit
{
    public string Name;
    public int HealthPool;
    public int HealthAmount;
    public int AttackPoints;
    public int DefensePoints;
    
    public Unit(string name, int healthPool, int healthAmount, int attackPoints, int defensePoints)
    {
        Name = name;
        HealthPool = healthPool;
        HealthAmount = healthAmount;
        AttackPoints = attackPoints;
        DefensePoints = defensePoints;
    }
}
