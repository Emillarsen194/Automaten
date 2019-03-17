using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    class Soda
    {
        private String brand;
        private String taste;
        private int price;

        #region makeitpublic
        public String Brand
        {
            get
            {
                return brand;
            }
            
            set
            {
                brand = value;
            }
        }
        
        public String Taste
        {
            get
            {
                return taste;
            }
            
            set
            {
                taste = value;
            }
        }

        public int Price
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
        #endregion

        public Soda(String br, String na, int price)
        {
            this.brand = br;
            this.taste = na;
            this.price = price;
        }
    }
}
