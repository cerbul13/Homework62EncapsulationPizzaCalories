using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework62EncapsulationPizzaCalories
{
    public enum FlourTypes
    {
        White =150,
        Wholegrain = 100
    }
    public enum BakingTypes
    {
        Crispy = 90, 
        Chewy = 110,
        Homemade = 100
    }
    public class Pizza
    {
        private string name;
        private FlourTypes flourType;
        private BakingTypes bakingType;
        private int weight;
        private List<Topping> toppingsList;
        public string Name 
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string FlourType
        {
            set
            {
                if (Enum.IsDefined(typeof(FlourTypes), value))
                {
                    this.flourType = (FlourTypes)Enum.Parse(typeof(FlourTypes), value);
                }
                else
                {
                    throw new ArgumentException($"Invalid type of dough.");
                }
            }
        }
        public string BakingType
        {
            set
            {
                if (Enum.IsDefined(typeof(BakingTypes), value))
                {
                    this.bakingType = (BakingTypes)Enum.Parse(typeof(BakingTypes), value);
                }
                else
                {
                    throw new ArgumentException($"Invalid type of dough.");
                }
            }
        }
        public int Weight
        {
            set
            {
                if (value < 1 || value > 200) { throw new ArgumentException($"Dough weight should be in the range [1..200]"); }
                else
                { this.weight = value; }
            }
        }
        public decimal DoughCalories
        {
            get
            {
                return (int)flourType / (decimal)100 * (int)bakingType / (decimal)100 * (decimal)2 * (decimal)weight;
            }

        }
        public void AddTopping(Topping topping)
        {
            toppingsList.Add(topping);
        }
        public decimal Calories
        {
            get
            { 
                decimal calories = 0;
                calories += DoughCalories;
                foreach (Topping topping in toppingsList)
                {
                    calories += topping.Calories;
                }
                //Console.WriteLine($"Pizza {name} has a total of {calories} calories.");
                return calories;
            }
        }
        public Pizza(string name, string flourType,string bakingType, int weight)
        {
            this.Name = name;
            this.FlourType = flourType;
            this.BakingType = bakingType;
            this.Weight = weight;
            this.toppingsList = new List<Topping>();
        }
    }
}
