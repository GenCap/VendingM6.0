using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VendingM6._0.Models
{
    public class Toy:Product
    {
        public int RecommendedAge { get; set; }

        public Toy(int id, string name, int price, int recommendedAge) : base(id, name, price)
        {
            RecommendedAge = recommendedAge;
        }

        public override string Examine()
        {
            return base.Examine() + $"\nRecommended age: {RecommendedAge}\n";
        }

        public override string Use()
        {
            return ($"Here's your {Name}, have fun with it!");
        }
    }
}
