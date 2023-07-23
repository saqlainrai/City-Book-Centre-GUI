using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBookCentre.BL
{
    public class Suggestion
    {
        public string name { get; set; }
        public string suggestion { get; set; }
        public Suggestion(string book, string review)
        {
            name = book;
            suggestion = review;
        }
    }
}
