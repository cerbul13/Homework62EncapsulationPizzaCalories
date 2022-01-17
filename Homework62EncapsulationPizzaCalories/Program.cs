using System;

namespace Homework62EncapsulationPizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            Topping toppingMeat = new Topping("Meat", 50);
            Topping toppingCheese = new Topping("Cheese", 30);
            Pizza pizza = new Pizza("Pizza Margherita", "White", "Chewy", 200);
            pizza.AddTopping(toppingMeat);
            pizza.AddTopping(toppingCheese);
            Console.WriteLine($"Pizza {pizza.Name} has a total of {pizza.Calories} calories.");
        }
    }
}
