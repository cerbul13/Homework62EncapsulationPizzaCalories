using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework62EncapsulationPizzaCalories
{
    public enum Types
    {
        Meat=120,
        Veggies=80,
        Cheese=150,
        Sauce=90
    }
    public class Topping
    {
        private Types type;
        private int weight;
        public string Type
        {
            set
            {
                if (Enum.IsDefined(typeof(Types),value))
                {
                    this.type = (Types)Enum.Parse(typeof(Types), value); 
                } else
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
            }
        }
        public int Weight
        {
            set
            {
                if (value<1 || value>50) { throw new ArgumentException($"{this.type} weight should be in the range [1..50]"); } else
                { this.weight = value; }
            }
        }
        public decimal Calories
        {
            get
            {
                return (int)type / (decimal)100*(decimal)2*(decimal)weight;
            }

        }
        public Topping(string type, int weight)
        {
            this.Type = type;
            this.Weight = weight;
        }
    }
}
