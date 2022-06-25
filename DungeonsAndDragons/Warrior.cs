namespace DungeonsAndDragons;

public class Warrior:Player
{
    int cooldown; //The Warrior cant use the ability if cooldown > 0


    public Warrior() :
    {
       super();
       cooldown = 0;
    }
}