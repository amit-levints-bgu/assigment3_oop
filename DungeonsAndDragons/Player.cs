namespace DungeonsAndDragons;

public class Player:Unit
{
    public int Experience;
    public int PlayerLevel; // Increased When Experience reached to 50

    public Player(int Experience, int PlayerLevel) : base()
    {
        this.Experience = Experience;
        this.PlayerLevel = PlayerLevel;
    }
    
    public Player() : base()
    {
        this.Experience = 0;
        this.PlayerLevel = 1;
    }
   
}