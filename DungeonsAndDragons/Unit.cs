using System.Transactions;

namespace DungeonsAndDragons;

public abstract class Unit: Tile
{
    public string Name;
    public int HealthPool;
    public int HealthAmount;
    public int AttackPoints;
    public int DefensePoints;
    
    public Unit(string name, int healthPool, int healthAmount, int attackPoints, int defensePoints): base()
    {
        Name = name;
        HealthPool = healthPool;
        HealthAmount = healthAmount;
        AttackPoints = attackPoints;
        DefensePoints = defensePoints;
    }
    
    protected void initialize(Position position, IMessageCallback messageCallback){
        ...
    }
	
    protected int attack(){
        ...
    }

    public int defend(){
        ...
    }

    // Should be automatically called once the unit finishes its turn
    public abstract void processStep();
	
    // What happens when the unit dies
    public abstract void onDeath();

    // This unit attempts to interact with another tile.
    public void interact(Tile tile){
        ...
    }

    public void visit(Empty e){
        ...
    }

    public abstract void visit(Player p);
    public abstract void visit(Enemy e);

    // Combat against another unit.
    protected void battle(Unit u){
        ...
    }


    public String describe() {
        return String.format("%s\t\tHealth: %s\t\tAttack: %d\t\tDefense: %d", getName(), getHealth(), getAttack(), getDefense());
    }
}
