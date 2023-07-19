using CityBookCentre.BL;
using CityBookCentre.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBookCentre.CommonLogic
{
    public class commonFunction
    {
        public static string signIn(string userName, string password2)
        {
            List<User> allUsers = UserDL.allUsers;
            for (int x = 0; x < allUsers.Count; x++)
            {
                if (allUsers[x].name == userName && allUsers[x].password == password2)
                {
                    return allUsers[x].role;
                }
            }
            return "Undefined";
        }
    }
}
