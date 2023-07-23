using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBookCentre.BL
{
    public class UserBook : Book 
    {
        public string username { get; set; }
        public string password { get; set; }

        public UserBook(string username, string password, string name, int price) : base(name, price)
        {
            this.username = username;
            this.password = password;
        }
        public string getUserName()
        {
            return username;
        }
        public string getPassword()
        {
            return password;
        }
    }
}
