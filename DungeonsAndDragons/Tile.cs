namespace DungeonsAndDragons;

public abstract class Tile : IComparable<Tile>
{
    protected char tile;
    protected Position position;

    protected Tile(char tile){
        this.tile = tile;
    }
    
    protected void initialize(Position position){
        this.position = position;
    }

    public char getTile() {
        return tile;
    }

    public Position GetPosition() {
        return position;
    }

    public void SetPosition(Position position) {
        this.position = position;
    }

    public abstract void Accept(Unit unit);
    
    public int CompareTo(Tile tile) {
        return GetPosition().CompareTo(tile.GetPosition());
    }
    
    public String ToString() {
        return String.valueOf(tile);
    }
}