using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp
{
    [Serializable]
    public class Commodity
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Commodity()
        {
            this.Name = "";
            this.Price = 0;
        }

        public Commodity(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"Commodity: {Name}\tPrice: {Price}";
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Commodity commodity) || commodity.Name != this.Name || commodity.Price != this.Price) return false;
            return true;
        }

        public override int GetHashCode()
        {
            var bytes = Encoding.Default.GetBytes(Name);
            int nameInt = 0;
            foreach (var b in bytes)
            {
                nameInt = nameInt * 10 + Convert.ToInt32(b);
            }
            return nameInt + Convert.ToInt32(Price);
        }
    }
}
