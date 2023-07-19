using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBookCentre.DL
{
    public class commonDL
    {
        public static void loadIncomeData()
        {
            string path = "incomeData.txt";
            StreamReader dataFile = new StreamReader(path);
            Program.ordersCounter = int.Parse(dataFile.ReadLine());
            Program.incomeCounter = int.Parse(dataFile.ReadLine());
            dataFile.Close();
        }
    }
}
