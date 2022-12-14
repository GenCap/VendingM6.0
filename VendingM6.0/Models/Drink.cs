using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingM6._0.Models
{
    public class Drink : Product
    {
        public string TypeOfDrink { get; set; }


        public Drink(int id, string name, int price, string typeOfDrink) : base(id, name, price)
        {
            TypeOfDrink = typeOfDrink;
        }



        public override string Examine()
        {
            return base.Examine() + $"\nType of drink: {TypeOfDrink}\n";
        }

        public override string Use()
        {
            return ($"Here's your {Name}, enjoy your drink!");
        }
    }
}
