using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_V2
{
    public class Flower
    {
        public string Name { get; set; }
        public int Price { get; set; }


        public Flower(string name, int price)
        {
            Name = name;
            Price = price;

        }
    }

}
