using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBookCentre.BL
{
    public class Suggestion
    {
        public string name;
        public string suggestion;
        public Suggestion(string book, string review)
        {
            name = book;
            suggestion = review;
        }

        public DL.SuggestionDL SuggestionDL
        {
            get => default;
            set
            {
            }
        }
    }
}
