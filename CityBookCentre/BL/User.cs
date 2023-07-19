using CityBookCentre.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBookCentre.BL
{
    public class User
    {
        public string name;
        public string password;
        public string role;

        public User(string name, string password, string role)
        {
            this.name = name;
            this.password = password;
            this.role = role;
        }

        public UserDL UserDL
        {
            get => default;
            set
            {
            }
        }
    }
}
