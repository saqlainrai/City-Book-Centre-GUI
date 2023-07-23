using CityBookCentre.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using CityBookCentre.BL;
using CityBookCentre.Admin;
using CityBookCentre.UserMenu;

namespace CityBookCentre
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static string refUserName = "";                          // this is the username of user which is currently working in the program
        public static string refUserPassword = "";                      // this is the password of user which is currently working in the program
        public static int idx = 0;
        public static int ordersCounter = 0;
        public static int incomeCounter = 0;
        public static Form main_welcome_window;

        [STAThread]
        static void Main()
        {
            if(Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }

            UserDL.addUserDatafromFile(UserDL.allUsers);
            ActiveBookDL.addBookDatafromFile(ActiveBookDL.allActiveBooks);
            UserBookDL.addWholePurchasedBooksDatafromFile();                    // the list in which these function prompt data are already in that class
            UserBookDL.addWholeBoughtBooksDatafromFile();                       // that's why we are not providing the list attribute
            commonDL.loadIncomeData();                                 // the function directly access the variables
            SuggestionDL.loadSuggestions();                            // list is in respective class

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            main_welcome_window = new Welcome();
            Application.Run(main_welcome_window);
            //Application.Run(new Admin.Main());
            //Application.Run(new UserMenu.Main());
        }
        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
