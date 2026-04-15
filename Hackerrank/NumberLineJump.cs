using Microsoft.VisualBasic;

internal class NumberLineJump
{
    public void test()
    {
        
    }
}
internal class Kangarro
{
    private string id;
    private Position position;
    private Distance distance;
    public Kangarro(string id, Position position, Distance distance)
    {
        this.id = id;
        this.position = position;
        this.distance = distance;
    }
}
internal class Position
{
    private readonly int value;
    public Position(int value)
    {
        this.value = value;
    }
}
internal class Distance
{
    private readonly int value;
    public Distance(int value)
    {
        this.value = value > 0 ? value : throw new Exception("distance must be greater than 0");
    }
}
// internal class CheckIfKangaroosMeet
// {
//     public NumberLineJump()
//     {
        
//     }
// }