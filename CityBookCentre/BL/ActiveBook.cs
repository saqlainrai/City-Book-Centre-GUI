using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBookCentre.BL
{
    public class ActiveBook : Book
    {
        public int stock { get; set; }
        public int lendingCost { get; set; }

        public ActiveBook(string name, int price, int stock, int lendingCost) : base(name, price)
        {
            this.stock = stock;
            this.lendingCost = lendingCost;
        }

        public int getStock()
        {
            return stock;
        }
        public int getLendingCost()
        {
            return lendingCost;
        }

        public void setStock(int stock)
        {
            this.stock = stock;
        }
        public void setLendingCost(int lendingCost)
        {
            this.lendingCost = lendingCost;
        }
    }
}
