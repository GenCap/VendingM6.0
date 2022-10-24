using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingM6._0.Models
{
    public abstract class Product
    {
        private readonly int id;
        public string Name { get; set; }
        public int Price { get; set; }

        public Product()
        {

        }
        public int Id
        {
            get
            {
                return id;
            }
        }
        public Product(int id, string name, int price)
        {
            this.id = id;
            Name = name;
            Price = price;

        }

        public virtual string Examine()
        {
            return $"\n--- {GetType().Name.ToUpper()} ---\nId: {Id} \nName: {Name}\nPrice: {Price}";
        }

        public abstract string Use();
    }
}
