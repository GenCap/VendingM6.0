using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingM6._0.Models
{
    public class Food : Product
    {
        public string TypeOfFood { get; set; }

        public Food(int id, string name, int price, string typeOfFood) : base(id, name, price)
        {
            TypeOfFood = typeOfFood;
        }

        public override string Examine()
        {
            return base.Examine() + $"\nType of food: {TypeOfFood}\n";
        }

        public override string Use()
        {
            return ($"Here's your {Name}, enjoy your meal!");
        }
    }
}
