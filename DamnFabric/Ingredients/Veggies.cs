namespace DamnFabric.Ingredients;

public interface IVeggies
{
    public void GetName();
    
}

public class Tomato : IVeggies
{

    public  void GetName()
    {
        Console.WriteLine("add tomato");
    }
}

public class Mushrooms : IVeggies
{
    public  void GetName()
    {
        Console.WriteLine("add mushrooms");
    }
}

public class Cucumbers : IVeggies
{
    public void GetName()
    {
        Console.WriteLine("add cucumbers");
    }
}

