using CityBookCentre.BL;
using CityBookCentre;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBookCentre.DL
{
    public class Person
    {
        public string name;
        public int age;
        public int id;
        public Person(string name, int age, int id)
        {
            this.name = name;
            this.age = age;
            this.id = id;
        }
    }
    public class ActiveBookDL
    {
        public static List<ActiveBook> allActiveBooks = new List<ActiveBook>();

        public static void addBookDatafromFile(List<ActiveBook> allActiveBooks)
        {
            //int op = 0;
            string bookDataLine;

            string path2 = "BooksData.txt";
            StreamReader file = new StreamReader(path2);

            while (!file.EndOfStream)
            {
                //Books newBook = new Books();
                bookDataLine = file.ReadLine();
                string[] dataArray = bookDataLine.Split(',');

                allActiveBooks.Add(new ActiveBook(dataArray[0], int.Parse(dataArray[1]), int.Parse(dataArray[2]), int.Parse(dataArray[3])));
            }
            file.Close();
        }
        public static void updateBooksDatainFile(List<ActiveBook> allActiveBooks)
        {
            string path = "BooksData.txt";
            StreamWriter file = new StreamWriter(path);
            for (int x = 0; x < allActiveBooks.Count; x++)
            {
                file.WriteLine(allActiveBooks[x].getName() + "," + allActiveBooks[x].getPrice() + "," + allActiveBooks[x].getStock() + "," + allActiveBooks[x].getLendingCost());
            }
            file.Close();
        }
    }
}
