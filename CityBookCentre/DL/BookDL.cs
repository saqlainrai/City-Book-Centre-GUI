using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityBookCentre.Admin;
using CityBookCentre.BL;

namespace CityBookCentre.DL
{
    public class BookDL
    {
        public static List<Book> purchasedBooks = new List<Book>();
        public static List<Book> boughtBooks = new List<Book>();
        public static bool findBook(string checkBook, List<ActiveBook> allActiveBooks)
        {
            bool checkVariable = false;
            //foreach ( Books activeBook in allActiveBooks)
            for (int x = 0; x < allActiveBooks.Count; x++)
            {
                if (allActiveBooks[x].getName() == checkBook)
                {
                    Program.idx = x;
                    checkVariable = true;
                    break;
                }
            }
            return checkVariable;
        }
        public static void addPurchasedBookDatafromArray(string username, string password, List<UserBook> wholePurchasedBooks)
        {
            for (int x = 0; x < wholePurchasedBooks.Count; x++)
            {
                if (wholePurchasedBooks[x].getName() == username && wholePurchasedBooks[x].getPassword() == password)
                {
                    purchasedBooks.Add(new Book(wholePurchasedBooks[x].getName(), wholePurchasedBooks[x].getPrice()));
                }
            }
        }
        public static void purchaseBook(List<ActiveBook> allActiveBooks, List<Book> purchasedBooks)
        {
            purchasedBooks.Add(new Book(allActiveBooks[Program.idx].getName(), allActiveBooks[Program.idx].getPrice()));

            string path = "UserPurchasedBooks.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(Program.refUserName + "," + Program.refUserPassword + "," + allActiveBooks[Program.idx].getName() + "," + allActiveBooks[Program.idx].getPrice());
            file.Close();

            allActiveBooks[Program.idx].setStock(allActiveBooks[Program.idx].getStock() - 1);
            
        }
        public static void addBook(ActiveBook newBook, List<ActiveBook> allActiveBooks)
        {
            allActiveBooks.Add(newBook);

            string path = "BooksData.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(newBook.getName() + "," + newBook.getPrice() + "," + newBook.getStock() + "," + newBook.getLendingCost());
            file.Close();
        }
        public static void updateBook(ActiveBook temp, List<ActiveBook> allActiveBooks)
        {
            allActiveBooks.RemoveAt(Program.idx);
            allActiveBooks.Insert(Program.idx, temp);
        }
        public static void removeBook(int idx, List<ActiveBook> allActiveBooks)
        {
            allActiveBooks.RemoveAt(idx);
        }
    }
}