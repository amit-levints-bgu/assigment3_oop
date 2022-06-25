namespace DungeonsAndDragons;

public class Player:Unit
{
    public int Experience;  // Increased by killing enemies
    public int PlayerLevel; // Increased When Experience reached to 50 X level

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

    public void LevelingUp()
    {
        if(this.PlayerLevel * 50 <= this.Experience){
            this.PlayerLevel ++
            this.Experience = 0;
        }
    }


   
}