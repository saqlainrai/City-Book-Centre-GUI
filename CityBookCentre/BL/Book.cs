using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBookCentre.BL
{
    public class Book
    {
        public string name { get; set; }
        public int price { get; set; }   

        public Book(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        public string getName()
        {
            return name;
        }
        public int getPrice()
        {
            return price;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public void setPrice(int price)
        {
            this.price = price;
        }
    }
}
