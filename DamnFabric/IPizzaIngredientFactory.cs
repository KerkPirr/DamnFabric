using DamnFabric.Ingredients;

namespace DamnFabric;

public interface IPizzaIngredientFactory {
    public Dough CreateDough();
    public Sause CreateSause();
    public Cheese CreateCheese();
    public IVeggies[] CreateVeggies();
    public Clams CreateClams();
}




