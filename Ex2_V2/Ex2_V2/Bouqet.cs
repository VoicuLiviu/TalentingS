using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_V2
{
    public class Bouquet
    {
        public string Name { get; set; }
        public int Price {  get; set; }
        public Bouquet(string name, int price)
        {

            Name = name;
            Price = price;
        }

    }
}
