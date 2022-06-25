namespace DungeonsAndDragons;

public class Trap:Enemy
{
    public int VisibilityTime;
    public int InvisibilityTime;
    public int TicksCount;
    public bool Visible;

    public Trap(int invisibilityTime, int visibilityTime)
    {
        Visible = true;
        TicksCount = 0;
        InvisibilityTime = invisibilityTime;
        VisibilityTime = visibilityTime;
    }
}