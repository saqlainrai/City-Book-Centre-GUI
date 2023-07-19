using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBookCentre.BL
{
    public class UserBook : Book 
    {
        protected string username;
        protected string password;

        public UserBook(string username, string password, string name, int price) : base(name, price)
        {
            this.username = username;
            this.password = password;
        }

        public DL.UserBookDL UserBookDL
        {
            get => default;
            set
            {
            }
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
