namespace DamnFabric.Ingredients;

public abstract class Dough
{
}
public class ThickCrustDough : Dough
{
    public ThickCrustDough()
    {
        Console.WriteLine("add ThickCrustDough");
    }
}
public class ThinCrustDough : Dough
{
    public ThinCrustDough()
    {
        Console.WriteLine("add ThinCrustDough");
    }
}