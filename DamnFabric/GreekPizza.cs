namespace DamnFabric;

public class GreekPizza : Pizza
{
    private IPizzaIngredientFactory ingredientFactory;
    

    public GreekPizza(IPizzaIngredientFactory ingredientFactory)
    {
        this.ingredientFactory = ingredientFactory;
    }
    
    public override void prepare()
    {
        this.dough = ingredientFactory.CreateDough();
        this.sause = ingredientFactory.CreateSause();
        this.cheese = ingredientFactory.CreateCheese();
        this.veggies = ingredientFactory.CreateVeggies();
    }
}