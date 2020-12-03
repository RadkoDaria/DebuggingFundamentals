using System;

namespace Task1
{
    public class Product 
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }

        public double Price { get; set; }


        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Product))
            {
                return false;
            }
            return (this.Name == ((Product)obj).Name)
                && (this.Price == ((Product)obj).Price);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Price.GetHashCode();
        }
    }
}
