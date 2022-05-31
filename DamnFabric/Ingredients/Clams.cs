namespace DamnFabric.Ingredients;

public abstract class Clams
{
   
}
public class FreshClams : Clams
{
    public FreshClams()
    {
        Console.WriteLine("add Fresh clams");
    }
}
public class FrozenClams : Clams
{
    public FrozenClams()
    {
        Console.WriteLine("add Frozen clams");
    }
}