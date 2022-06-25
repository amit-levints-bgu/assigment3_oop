namespace DungeonsAndDragons;

public class Player:Unit
{
    public int Experience;  // Increased by killing enemies
    public int PlayerLevel; // Increased When Experience reached to 50 X level
    public int HealthPool;
    public int HealthAmount;


    public Player(int Experience, int PlayerLevel, int HealthPool, int HealthAmount) : base()
    {
        this.Experience = Experience;
        this.PlayerLevel = PlayerLevel;
        this.HealthPool = HealthPool;
        this.HealthAmount = HealthAmount;
    }
    
    public Player() : base()
    {
        this.Experience = 0;
        this.PlayerLevel = 1;
    }

    public void LevelingUp()
    {
        if(this.PlayerLevel * 50 <= this.Experience){
            this.Experience = this.Experience - this.PlayerLevel*50;
            this.PlayerLevel ++;
        }
    }


   
}