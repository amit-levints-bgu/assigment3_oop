namespace DungeonsAndDragons;

public class Warrior:Player
{
    int abilityCooldown; // number of game ticks required to pass before using the ability.
    int remainingCooldown;  //number of ticks remained until the warrior can use its special ability.


    public Warrior(int abilityCooldown) :base()
    {
        this.abilityCooldown = abilityCooldown;
       this.remainingCooldown = 0;
    }

    public void levelingUpWarrior()
    {

    }
}