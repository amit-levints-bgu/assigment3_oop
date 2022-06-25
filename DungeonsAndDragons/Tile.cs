namespace DungeonsAndDragons;

public abstract class Tile : IComparable<Tile>
{
    protected char tile;
    protected (int x, int y) position;

    protected Tile(char tile){
        this.tile = tile;
    }
    
    protected void initialize((int x, int y) position){
        this.position = position;
    }

    public char getTile() {
        return tile;
    }

    public (int x, int y) GetPosition() {
        return position;
    }

    public void SetPosition((int x, int y) position) {
        this.position = position;
    }

    public abstract void Accept(Unit unit);
    
    public int CompareTo(Tile tile) {
        return GetPosition().CompareTo(tile.GetPosition());
    }

    public double Range((int x, int y) other_position)
    {
        return Math.Sqrt(Math.Pow(other_position.x - position.x, 2) + Math.Pow(other_position.y - position.y, 2));
    }
    
    public String ToString() {
        return String.valueOf(tile);
    }
}