namespace DamnFabric.Ingredients;

public abstract class Sause
{
}
public class MarinaraSause : Sause
{
    public MarinaraSause()
    {
        Console.WriteLine("add Miranana Sause");
    }
}
public class PlumTomatoSause : Sause
{
    public PlumTomatoSause()
    {
        Console.WriteLine("add Plum tomato sauce");
    }
}