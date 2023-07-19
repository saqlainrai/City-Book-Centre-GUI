using CityBookCentre.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBookCentre.DL
{
    public class UserBookDL
    {
        public static List<UserBook> wholeBoughtBooks = new List<UserBook>();
        public static List<UserBook> wholePurchasedBooks = new List<UserBook>();

        public static void addBoughtBookDatafromFile(string username, string password, List<UserBook> wholeBoughtBooks, List<Book> boughtBooks)
        {

            foreach (UserBook ub in wholeBoughtBooks)
            {
                if (ub.getUserName() == username && ub.getPassword() == password)
                {
                    boughtBooks.Add(new Book(ub.getName(), ub.getPrice()));
                }
            }

            // This previous logic was actually again ready data from file and prompting them in reference list by checking name and password
            // INSTEAD WE WILL CHECK THE LOGIC FROM ARRAY AND FILL THE ARRAY COZ, IT IS ALREADY READED FROM FILE

            //string temporaryUser;
            //string temporaryPassword;
            //string boughtBookDataLine;

            //string path = "userBoughtBooks.txt";
            //StreamReader file = new StreamReader(path);
            //while (!file.EndOfStream)
            //{
            //    boughtBookDataLine = file.ReadLine();
            //    string[] booksData = boughtBookDataLine.Split(',');
            //    temporaryUser = booksData[0];
            //    temporaryPassword = booksData[1];

            //    if (temporaryPassword == password && temporaryUser == username)
            //    {
            //        boughtBooks[boughtBooksCount] = booksData[2];
            //        priceOfBoughtBooks[boughtBooksCount] = int.Parse(booksData[3]);
            //        boughtBooksCount++;
            //    }
            //}
        }
        public static void transferDatatoNextfile(string username, string password, List<UserBook> wholePurchasedBooks, List<Book> purchasedBooks, List<UserBook> wholeBoughtBooks)
        {
            string path = "userBoughtBooks.txt";
            StreamWriter file1 = new StreamWriter(path, true);
            for (int x = 0; x < purchasedBooks.Count; x++)
            {
                file1.WriteLine(username + "," + password + "," + purchasedBooks[x].getName() + "," + purchasedBooks[x].getPrice());

                Program.ordersCounter++;
                Program.incomeCounter += purchasedBooks[x].getPrice();
            }
            file1.Close();

            string path2 = "incomeData.txt";
            StreamWriter file2 = new StreamWriter(path2);
            file2.WriteLine(Program.ordersCounter);
            file2.WriteLine(Program.incomeCounter);
            file2.Close();

            for (int x = 0; x < wholePurchasedBooks.Count; x++)
            {
                //if (wholePurchasedBooksUser[x] == username && wholePurchasedBooksPassword[x] == password)
                if (wholePurchasedBooks[x].getName() == username && wholePurchasedBooks[x].getPassword() == password)
                {
                    //wholePurchasedBooksUser[x] = wholePurchasedBooksUser[x + 1];
                    //wholePurchasedBooksPassword[x] = wholePurchasedBooksPassword[x + 1];
                    //wholePurchasedBooksNames[x] = wholePurchasedBooksNames[x + 1];
                    //wholePurchasedBooksPrice[x] = wholePurchasedBooksPrice[x + 1];
                    //wholePurchasedBooksArrayCount--;
                    //x--;
                    wholePurchasedBooks.Remove(wholePurchasedBooks[x]);
                }
            }
            //purchasedBooksCount = 0;

            // this file function will rewrite list of purchased books after removing book of a specific user
            string path1 = "UserPurchasedBooks.txt";
            StreamWriter file = new StreamWriter(path1);
            for (int x = 0; x < wholePurchasedBooks.Count; x++)
            {
                file.WriteLine(wholePurchasedBooks[x].getUserName() + "," + wholePurchasedBooks[x].getPassword() + "," + wholePurchasedBooks[x].getName() + "," + wholePurchasedBooks[x].getPrice());
            }
            file.Close();

            for (int y = 0; y < purchasedBooks.Count; y++)
            {
                wholeBoughtBooks.Add(new UserBook(username, password, purchasedBooks[y].getName(), purchasedBooks[y].getPrice()));
            }
            purchasedBooks.Clear();
        }
        public static void addWholePurchasedBooksDatafromFile()
        {
            string path = "UserPurchasedBooks.txt";
            StreamReader file = new StreamReader(path);
            string bookDataLine;
            while (!(file.EndOfStream))
            {
                bookDataLine = file.ReadLine();

                string[] dataArray = bookDataLine.Split(',');

                wholePurchasedBooks.Add(new UserBook(dataArray[0], dataArray[1], dataArray[2], int.Parse(dataArray[3])));
            }
            file.Close();
        }
        public static void addWholeBoughtBooksDatafromFile()
        {
            string path = "UserBoughtBooks.txt";
            StreamReader file = new StreamReader(path);
            string bookDataLine;
            while ((!file.EndOfStream))
            {
                bookDataLine = file.ReadLine();
                string[] dataArray = bookDataLine.Split(',');

                wholeBoughtBooks.Add(new UserBook(dataArray[0], dataArray[1], dataArray[2], int.Parse(dataArray[3])));
            }
            file.Close();
        }
    }
}
