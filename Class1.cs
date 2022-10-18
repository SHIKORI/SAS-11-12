using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brrt_brrt_4
{
    internal class Class
    {
        public string item { get; set; }
        public int quantity;
        public string unit { get; set; }
        private double price;
        
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
    }


}
