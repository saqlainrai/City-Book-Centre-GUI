using CityBookCentre.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CityBookCentre.DL
{
    public class UserDL
    {
        public static List<User> allUsers = new List<User>();

        public static void addUserDatafromFile(List<User> allUsers)
        {
            string data;

            string path = "UsersData.txt";
            StreamReader file = new StreamReader(path);
            while (!(file.EndOfStream))
            {
                data = file.ReadLine();
                string[] splittedArray = data.Split(',');
                allUsers.Add(new User(splittedArray[0], splittedArray[1], splittedArray[2]));
            }
            file.Close();
        }
    }
}
